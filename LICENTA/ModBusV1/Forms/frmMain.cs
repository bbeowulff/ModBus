using Modbus.Device;
using ModBusV1.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Modbus.Utility;
using System.Net;
using System.Threading.Tasks;
using Modbus;
using Microsoft.Win32;
using System.Web.UI.WebControls;

namespace ModBusV1
{
    public partial class FrmMain : Form
    {
        static void Function()
        {
            // IP address and port of the Modbus TCP device
            string ipAddress = "192.168.0.7";
            int port = 502;
            try
            {
                // Create a TCP client
                using (TcpClient tcpClient = new TcpClient(ipAddress, port))
                {
                    if (!tcpClient.Connected) tcpClient.BeginConnect(ipAddress, port, null, null);
                    using (NetworkStream stream = tcpClient.GetStream())
                    {
                        // Modbus RTU request parameters
                        byte slaveId = 1;
                        ushort startAddress = 0;
                        ushort numberOfPoints = 10; // Number of points to read
                        // Create the Modbus RTU request
                        byte[] rtuRequest = CreateModbusRtuRequest(slaveId, startAddress, numberOfPoints);
                        // Build the Modbus TCP request with the RTU request inside
                        //byte[] tcpRequest = BuildModbusTcpRequest(rtuRequest);
                        // Send the Modbus TCP request
                        stream.Write(rtuRequest, 0, rtuRequest.Length);
                        Console.WriteLine("TCP Request:");
                        foreach (byte b in rtuRequest)
                        {
                            Console.Write($"{b:X2} ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("merge");
                        // Receive and handle the Modbus TCP response
                        byte[] tcpResponse = new byte[1024];
                        int bytesRead = stream.Read(tcpResponse, 0, tcpResponse.Length);
                        // Handle the Modbus TCP response and extract the Modbus RTU response
                        byte[] rtuResponse = ExtractModbusRtuResponse(tcpResponse, bytesRead);
                        Console.WriteLine("TCP Response:");

                        foreach (byte b in tcpResponse)
                        {
                            if(bytesRead!=0)
                            Console.Write($"{b:X2} ");
                            if (bytesRead == 0) break;
                            bytesRead--;
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static byte[] CreateModbusRtuRequest(byte slaveId, ushort startAddress, ushort numberOfPoints)
        {
            // Create your Modbus RTU request here
            // This example assumes a simple ReadHoldingRegisters request

            byte functionCode = 4; // Read Holding Registers

            byte[] request = new byte[8];
            request[0] = slaveId;
            request[1] = functionCode;
            request[2] = (byte)(startAddress >> 8);
            request[3] = (byte)(startAddress & 0xFF);
            request[4] = (byte)(numberOfPoints >> 8);
            request[5] = (byte)(numberOfPoints & 0xFF);
            byte[] req = { request[0], request[1], request[2], request[3], request[4], request[5] };
            byte[] crcBytes = ModbusUtility.CalculateCrc(req);

            // Ensure crcBytes is at least 2 bytes long before assigning
            if (crcBytes.Length >= 2)
            {
                request[6] = crcBytes[0]; // High byte of CRC
                request[7] = crcBytes[1]; // Low byte of CRC
            }
            return request;
        }
        static byte[] BuildModbusTcpRequest(byte[] rtuRequest)
        {
            // Build the Modbus TCP request using the RTU request

            ushort transactionId = 0; // Choose a suitable transaction ID
            ushort protocolId = 0; // Modbus protocol ID
            ushort length = (ushort)(rtuRequest.Length -2); 

            byte[] tcpRequest = new byte[6 + rtuRequest.Length-2];
            tcpRequest[0] = (byte)(transactionId >> 8);
            tcpRequest[1] = (byte)(transactionId & 0xFF);
            tcpRequest[2] = (byte)(protocolId >> 8);
            tcpRequest[3] = (byte)(protocolId & 0xFF);
            tcpRequest[4] = (byte)(length >> 8);
            tcpRequest[5] = (byte)(length & 0xFF);
            Array.Copy(rtuRequest, 0, tcpRequest, 6, rtuRequest.Length-2);
            return tcpRequest;
        }
        static byte[] ExtractModbusRtuResponse(byte[] tcpResponse, int bytesRead)
        {
            byte[] rtuResponse = new byte[bytesRead - 7];
            Array.Copy(tcpResponse, 7, rtuResponse, 0, bytesRead - 7);
            return rtuResponse;
        }
        private void InitializeRoundedCorners()
        {
            int radius = 15; // Adjust the value to change the roundness of the corners

            // Create a region with rounded corners using Win32 function CreateRoundRectRgn
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius * 2, radius * 2));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
        SerialPort serialPort;
        IModbusSerialMaster master;
        TcpClient client;
        ModbusIpMaster master2;
        byte slaveAddress = Properties.Settings.Default.Address;
        public static int[] BaudRate = new int[] { 4800, 9600, 19200, 38400, 57600, 115200 };
        public static int[] Read_type = new int[] { 3, 4 };
        public static int[] DataBits = new int[] { 7, 8 };
        public static int[] StepBits = new int[] { 1, 2 };
        int timer = 0;
        int TCPtimer = 0;
        int timer2 = -1;

        public FrmMain()
        {
            InitializeComponent();
            InitializeRoundedCorners();
            ushort[] registers= { 12345, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            for (int i = 0; i < registers.Length; i++)
            {
                listBox1.Items.Add("registrul " + i + " :" + registers[i]);
            }
            sidemenu.Width = 40;
            filebutton.Visible = false;
            settingsbutton.Visible = false;
            functionsbutton.Visible = false;
            button5.Visible = false;
            button10.Visible = false;
            serialPort = new SerialPort();
            client = new TcpClient();
            string imagePath = "..\\..\\..\\..\\LICENTA\\ModBusV1\\Resources\\dino_offline.jpg"; // Calea către imaginea "dino.jpeg"
            System.Drawing.Image backgroundImg = System.Drawing.Image.FromFile(imagePath);

            this.BackgroundImage = backgroundImg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateStatus();
            tmr.Interval = Properties.Settings.Default.Refresh;
        }
        public void connectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = Properties.Settings.Default.ComPort;
                serialPort.BaudRate = Properties.Settings.Default.Baudrate;
                int Read_type1 = Properties.Settings.Default.Read_type;
                serialPort.DataBits = Properties.Settings.Default.DataBits;
                serialPort.Parity = (Parity)Properties.Settings.Default.ParityBits;
                serialPort.StopBits = (StopBits)Properties.Settings.Default.StopBits;
                serialPort.RtsEnable = true;
                if (!serialPort.IsOpen) serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.ReadTimeout = 1000;
                master.Transport.WriteTimeout = 1000;
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel2.Visible = true;
                toolStripStatusLabel3.Visible = true;
                toolStripStatusLabel4.Visible = true;
                toolStripStatusLabel5.Visible = true;
                toolStripStatusLabel6.Text = "Connected";
                toolStripStatusLabel6.ForeColor = Color.DarkGreen;
                toolStripStatusLabel7.Visible = false;
                toolStripStatusLabel8.Visible = false;
                ////////////////////////////////////////
                connectRTU.Enabled = false;
                connectTCP.Enabled = false;
                Settings.Enabled = false;
                disconnectRTU.Enabled = true;
                disconnectTCP.Enabled = false;
                ////////////////////////////////////////
                int n;
                for (n = 30; n < Properties.Settings.Default.quantityTCP+30; n++)
                {
                    string labelName = "label" + n;
                    Control[] controls = this.Controls.Find(labelName, true);
                    if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                    {
                        targetLabel.Visible = true;
                    }
                }
                if (Properties.Settings.Default.Read_type==4)
                {
                    nregisters.Text = "ReadMultipleInputRegisters";
                    nregisters.Visible = true; 
                }
                if (Properties.Settings.Default.Read_type == 3)
                {
                    nregisters.Text = "ReadMultipleHoldingRegisters";
                    nregisters.Visible = true;
                }
                sendaddress.Visible = true;
                newaddress.Visible = true;
                numAddress.Visible = true;
                if (Properties.Settings.Default.Read_type == 4)
                {
                    label4.Text = "ReadInputRegisters One-by-One";
                }
                if (Properties.Settings.Default.Read_type == 3)
                {
                    label4.Text = "ReadHoldingRegisters One-by-One";
                }
                label4.Visible = true;
                label3.Visible = true;
                LblAddress.Visible = true;
                checkedListBox1.Visible = true;
                BackgroundImage = null;
                tmr.Start();
            }
            catch (IOException exIO)
            {
                if (exIO.HResult == -2146232800)
                    MessageBox.Show(this, "SerialPort is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(this, exIO.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void disConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            timer2 = timer2 % 10;
            if(serialPort.IsOpen)
            {
                serialPort.Close();
                serialPort.Dispose();
                master.Dispose();
            }
            toolStripStatusLabel1.Visible = false;
            toolStripStatusLabel2.Visible = false;
            toolStripStatusLabel3.Visible = false;
            toolStripStatusLabel4.Visible = false;
            toolStripStatusLabel5.Visible = false;
            toolStripStatusLabel6.Text = "Disconnected";
            toolStripStatusLabel6.ForeColor = Color.DarkRed;
            toolStripStatusLabel7.Visible = false;
            toolStripStatusLabel8.Visible = false;
            /////////////////////////////////////
            connectRTU.Enabled = true;
            connectTCP.Enabled = true;
            Settings.Enabled = true;
            disconnectRTU.Enabled = false;
            disconnectTCP.Enabled = false;
            /////////////////////////////////////
            int n;
            for (n = 30; n < 60; n++)
            {
                string labelName = "label" + n;
                Control[] controls = this.Controls.Find(labelName, true);
                if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                {
                     targetLabel.Visible = false; 
                }
            }
            nregisters.Visible = false;
            sendaddress.Visible = false;
            newaddress.Visible = false;
            numAddress.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            LblAddress.Visible = false;
            label3.Text = "0.0";

            checkedListBox1.Visible = false;
            string imagePath = "..\\..\\..\\..\\LICENTA\\ModBusV1\\Resources\\dino_offline.jpg";
            System.Drawing.Image backgroundImg = System.Drawing.Image.FromFile(imagePath);
            this.BackgroundImage = backgroundImg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void connectTCPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Adresa IP și portul serverului Modbus TCP
                string ipAddress = Properties.Settings.Default.ipAddress;
                int port = Properties.Settings.Default.Port;

                // Crearea unei conexiuni TCP către serverul Modbus
                client = new TcpClient(ipAddress, port);
                if (!client.Connected) client.BeginConnect(ipAddress, port, null, null);
                master2 = ModbusIpMaster.CreateIp(client);
                master2.Transport.ReadTimeout = 2000;
                    master2.Transport.WriteTimeout = 2000;
                toolStripStatusLabel6.Text = "Connected";
                toolStripStatusLabel6.ForeColor = Color.DarkGreen;
                toolStripStatusLabel1.Visible = false;
                toolStripStatusLabel2.Visible = false;
                toolStripStatusLabel3.Visible = false;
                toolStripStatusLabel4.Visible = false;
                toolStripStatusLabel5.Visible = false;
                toolStripStatusLabel7.Visible = true;
                toolStripStatusLabel8.Visible = true;
                //////////////////////////////////////////////
                connectRTU.Enabled = false;
                connectTCP.Enabled = false;
                Settings.Enabled = true;
                disconnectRTU.Enabled = false;
                disconnectTCP.Enabled = true;
                //////////////////////////////////////////////
                int n;
                for (n = 30; n < Properties.Settings.Default.quantityTCP+30; n++)
                {
                    string labelName = "label" + n;
                    Control[] controls = this.Controls.Find(labelName, true);
                    if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                    {
                        targetLabel.Visible = true;
                    }
                }
                
                if (Properties.Settings.Default.Read_type == 4)
                {
                    nregisters.Text = "ReadMultipleInputRegisters";
                    nregisters.Visible = true;
                }
                if (Properties.Settings.Default.Read_type == 3)
                {
                    nregisters.Text = "ReadMultipleHoldingRegisters";
                    nregisters.Visible = true;
                }
                sendaddress.Visible = true;
                newaddress.Visible = true;
                numAddress.Visible = true;
                if (Properties.Settings.Default.Read_type == 4)
                {
                    label4.Text = "ReadInputRegisters One-by-One";
                }
                if (Properties.Settings.Default.Read_type == 3)
                {
                    label4.Text = "ReadHoldingRegisters One-by-One";
                }
                label4.Visible = true;
                label3.Visible = true;
                LblAddress.Visible = true;
                checkedListBox1.Visible = true;
                BackgroundImage = null;
                numAddress.Value = 1001;
                tmr.Start();
            }
            catch (IOException exIO)
            {
                if (exIO.HResult == -2146232800)
                    MessageBox.Show(this, "TCP is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(this, exIO.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void disConnectTCPToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            tmr.Stop();
            timer2 = timer2 % 10;
            if (client.Connected)
            {
                client.Close();
                client.Dispose();
                master2.Dispose();
            }
            toolStripStatusLabel6.Text = "Disconnected";
            toolStripStatusLabel6.ForeColor = Color.DarkRed;
            toolStripStatusLabel1.Visible = false;
            toolStripStatusLabel2.Visible = false;
            toolStripStatusLabel3.Visible = false;
            toolStripStatusLabel4.Visible = false;
            toolStripStatusLabel5.Visible = false;
            toolStripStatusLabel7.Visible = false;
            toolStripStatusLabel8.Visible = false;

            /////////////////////////////////////////////////
            connectRTU.Enabled = true;
            connectTCP.Enabled = true;
            Settings.Enabled = true;
            disconnectRTU.Enabled = false;
            disconnectTCP.Enabled = false;
            /////////////////////////////////////////////////
            int n;
            for (n = 30; n < 60; n++)
            {
                string labelName = "label" + n;
                Control[] controls = this.Controls.Find(labelName, true);
                if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                {
                    targetLabel.Visible = false;
                }
            }
            nregisters.Visible = false;
            sendaddress.Visible = false;
            newaddress.Visible = false;
            numAddress.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            LblAddress.Visible = false;
            label3.Text = "0.0";

            checkedListBox1.Visible = false;
            string imagePath = "..\\..\\..\\..\\LICENTA\\ModBusV1\\Resources\\dino_offline.jpg";
            System.Drawing.Image backgroundImg = System.Drawing.Image.FromFile(imagePath);
            this.BackgroundImage = backgroundImg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    serialPort.Dispose();
                    master.Dispose();
                }
                else
                if (client.Connected)
                {
                    client.Close();
                    client.Dispose();
                    master2.Dispose();
                }
                this.Dispose();
            }
        }
        public void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            var result = frmSettings.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.ComPort = frmSettings.cmbComPort.Text;
                Properties.Settings.Default.Baudrate = int.Parse(frmSettings.cmbBaudrate.Text);
                Properties.Settings.Default.DataBits = int.Parse(frmSettings.cmbDataBits.Text);
                Properties.Settings.Default.ParityBits = frmSettings.cmbParityBits.SelectedIndex;
                Properties.Settings.Default.StopBits = frmSettings.cmbStopBits.SelectedIndex;
                Properties.Settings.Default.Read_type = int.Parse(frmSettings.cmbRead_type.Text);
                Properties.Settings.Default.Refresh = int.Parse(frmSettings.NumRefresh.Value.ToString());
                Properties.Settings.Default.Address = byte.Parse(frmSettings.NumAddress.Value.ToString());
                slaveAddress = Properties.Settings.Default.Address;
                tmr.Interval = Properties.Settings.Default.Refresh;
                Properties.Settings.Default.Save();
                if (timer == 0)
                    UpdateStatus();
            }
            frmSettings.Dispose();
            frmSettings.Close();
        }
        public void UpdateStatus()
        {
            toolStripStatusLabel1.Text = "Port: " + Properties.Settings.Default.ComPort;
            toolStripStatusLabel2.Text = "Read Type: " + Properties.Settings.Default.Read_type;
            toolStripStatusLabel3.Text = "Data Bits: " + Properties.Settings.Default.DataBits;
            toolStripStatusLabel4.Text = "Parity: " + (Parity)Properties.Settings.Default.ParityBits;
            toolStripStatusLabel5.Text = "Stop Bits: " + (StopBits)Properties.Settings.Default.StopBits;
            toolStripStatusLabel6.Text = "Disconnected";
            toolStripStatusLabel7.Text = "Port: " + Properties.Settings.Default.Port;
            toolStripStatusLabel8.Text = "IP: " + Properties.Settings.Default.ipAddress;
        }
        public void tmr_Tick(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                try
                {
                    ushort[] results;
                    ushort startAddress = Properties.Settings.Default.startAddressTCP;
                    ushort quantity = Properties.Settings.Default.quantityTCP;
                    if (Properties.Settings.Default.Read_type == 4)
                    {
                        results = master2.ReadInputRegisters(slaveAddress,startAddress, quantity);
                    }
                    else
                        results = master2.ReadHoldingRegisters(slaveAddress,startAddress, quantity);
                    byte[] Request = CreateTCPModbusRequest(slaveAddress, startAddress, quantity);
                    string Requeststring = BitConverter.ToString(Request).Replace("-", " ");
                    //////RESPONSE////////////////////
                    List<byte> response = new List<byte>();
                    //Protocol ID
                    response.Add((byte)(TCPtimer >> 8));
                    response.Add((byte)TCPtimer);
                    // Adauga TCP protocol identifier
                    response.Add((byte)(00));
                    response.Add((byte)(00));
                    //Adaugam indexul de valori care urmeaza
                    int num = quantity*2+3;
                    response.Add((byte)(num >> 8));
                    response.Add((byte)num);
                    response.Add(slaveAddress);
                    response.Add((byte)Properties.Settings.Default.Read_type);
                    int numb = quantity * 2;
                    response.Add((byte)numb);
                    ushort auxquantity = 0;
                    while (auxquantity != quantity)
                    {
                        response.Add((byte)(results[auxquantity] >> 8));
                        response.Add((byte)(results[auxquantity]));
                        auxquantity++;
                    }
                    //////////////////////////////////
                    byte[] Response = response.ToArray();
                    string Responsestring = BitConverter.ToString(Response).Replace("-", " ");
                    if (Properties.Settings.Default.btnStartChecked == 1 && timer2 % 10 == 0)
                    {
                        Properties.Settings.Default.Request= timer.ToString("000000-") + "Tx: " + Requeststring;
                        Properties.Settings.Default.Response = (timer + 1).ToString("000000-") + "Rx: " + Responsestring;
                       Properties.Settings.Default.Save();
                        timer += 1;
                        TCPtimer++;
                    }
                    if (Properties.Settings.Default.btnStartChecked == 1) { timer2++; }
                    if (timer2 % 10 == 0)
                    { timer++; }
                }
                catch (Exception ex)
                {
                    disConnectToolStripMenuItem_Click(this, new EventArgs());

                    if (ex.HResult == -2146233083)
                        MessageBox.Show(this, "Check SlaveAddress then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (serialPort.IsOpen)
            {
                try
                {
                    ushort[] results;
                    ushort startAddress = Properties.Settings.Default.startAddress;
                    ushort quantity = Properties.Settings.Default.quantity;
                    if (Properties.Settings.Default.Read_type == 4)
                    {
                        results = master.ReadInputRegisters(slaveAddress, startAddress, quantity);
                    }
                    else
                        results = master.ReadHoldingRegisters(slaveAddress, startAddress, quantity);
                    byte[] Request = CreateModbusRequest(slaveAddress, startAddress, quantity);
                    string Requeststring = BitConverter.ToString(Request).Replace("-", " ");
                    //////RESPONSE////////////////////
                    ushort auxquantity = 0;
                    byte[] response = new byte[3 + quantity * 2 + 2]; // Allocate space for slaveAddress, Read_type, quantity, data, and CRC

                    response[0] = slaveAddress;
                    response[1] = (byte)Properties.Settings.Default.Read_type;
                    response[2] = (byte)quantity;

                    while (auxquantity != quantity)
                    {
                        response[3 + auxquantity * 2] = (byte)(results[auxquantity] >> 8);
                        response[4 + auxquantity * 2] = (byte)(results[auxquantity]);
                        auxquantity++;
                    }
                    byte[] crc = ModbusUtility.CalculateCrc(response);
                    response[3 + quantity * 2] = (byte)(crc[0]);
                    response[4 + quantity * 2] = (byte)(crc[1]);
                    //////////////////////////////////
                    string Responsestring = BitConverter.ToString(response).Replace("-", " ");
                    if (Properties.Settings.Default.btnStartChecked == 1 && timer2 % 10 == 0)
                    {
                        Properties.Settings.Default.Request = timer.ToString("000000-") + "Tx: " + Requeststring;
                        Properties.Settings.Default.Response = (timer + 1).ToString("000000-") + "Rx: " + Responsestring;
                        Properties.Settings.Default.Save();
                        timer += 1;
                    }
                    if (Properties.Settings.Default.btnStartChecked == 1) { timer2++; }
                    if (timer2 % 10 == 0)
                    { timer++; }
                }
                catch (Exception ex)
                {
                    disConnectToolStripMenuItem_Click(this, new EventArgs());

                    if (ex.HResult == -2146233083)
                        MessageBox.Show(this, "Check SlaveAddress then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void numAddress_ValueChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            if (client.Connected)
            {
                try
                {
                    //////////////SIGNED
                    if (master2 != null && Properties.Settings.Default.Read_type == 4 && index == 0)
                    {

                        short value = (short)master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        label3.Text = value.ToString("0.0");
                    }
                    if (master2 != null && Properties.Settings.Default.Read_type == 3 && index == 0)
                    {

                        short value = (short)master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        label3.Text = value.ToString("0.0");
                    }
                    //////////////UNSIGNED
                    if (master2 != null && Properties.Settings.Default.Read_type == 4 && index == 1)
                    {
                        ushort Value = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        label3.Text = Value.ToString("0.0");
                    }
                    if (master2 != null && Properties.Settings.Default.Read_type == 3 && index == 1)
                    {
                        ushort Value = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        label3.Text = Value.ToString("0.0");
                    }
                    ///////////////HEX
                    if (master2 != null && Properties.Settings.Default.Read_type == 4 && index == 2)
                    {
                        ushort Value = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        byte[] bytes = BitConverter.GetBytes(decimal.ToUInt32(Value));
                        string hexValue = BitConverter.ToString(bytes).Replace("-", "");
                        hexValue = hexValue.Substring(0, 4);
                        label3.Text = "0x" + hexValue;
                    }
                    if (master2 != null && Properties.Settings.Default.Read_type == 3 && index == 2)
                    {
                        ushort Value = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        byte[] bytes = BitConverter.GetBytes(decimal.ToUInt32(Value));
                        string hexValue = BitConverter.ToString(bytes).Replace("-", "");
                        hexValue = hexValue.Substring(0, 4);
                        label3.Text = "0x" + hexValue;
                    }
                    ///////////////BINARY
                    if (master2 != null && Properties.Settings.Default.Read_type == 4 && index == 3)
                    {
                        ushort Value = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        uint nou = Convert.ToUInt16(Value.ToString());
                        string binaryValue = Convert.ToString((int)nou, 2);
                        if (nou == 0)
                            label3.Text = "000000000000000";
                        else
                            label3.Text = binaryValue;

                    }
                    if (master2 != null && Properties.Settings.Default.Read_type == 3 && index == 3)
                    {
                        ushort Value = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        uint nou = Convert.ToUInt16(Value.ToString());
                        string binaryValue = Convert.ToString((int)nou, 2);
                        if (nou == 0)
                            label3.Text = "000000000000000";
                        else
                            label3.Text = binaryValue;
                    }
                    ////////////////LONG
                    if (master2 != null && Properties.Settings.Default.Read_type == 4 && (index == 4 || index == 5))
                    {
                        if (numAddress.Value == 0)
                        {
                            label3.Text = "0";
                        }
                        else if (numAddress.Value % 2 == 1)
                        {
                            label3.Text = "Empty";
                        }
                        else
                        {
                            ushort valueu1 = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            ushort valueu2 = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0]; ;
                            short value1 = (short)valueu1;
                            short value2 = (short)valueu2;
                            if (index == 4)
                            {
                                long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                label3.Text = combinedValue.ToString();
                            }
                            else
                            {
                                long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                long inverse = -combinedValue;
                                label3.Text = inverse.ToString();
                            }
                        }
                    }
                    if (master2 != null && Properties.Settings.Default.Read_type == 3 && (index == 4 || index == 5))
                    {
                        if (numAddress.Value == 0)
                        {
                            label3.Text = "0";
                        }
                        else if (numAddress.Value % 2 == 1)
                        {
                            label3.Text = "Empty";
                        }
                        else
                        {
                            ushort valueu1 = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            ushort valueu2 = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0]; ;
                            short value1 = (short)valueu1;
                            short value2 = (short)valueu2;
                            if (index == 4)
                            {
                                long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                label3.Text = combinedValue.ToString();
                            }
                            else
                            {
                                long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                long inverse = -combinedValue;
                                label3.Text = inverse.ToString();
                            }
                        }
                    }
                    ////////////////FLOAT
                    if (master2 != null && Properties.Settings.Default.Read_type == 4 && (index == 6 || index == 7))
                    {
                        if (numAddress.Value == 0)
                        {
                            label3.Text = "000.000";
                        }
                        else if (numAddress.Value % 2 == 1)
                        {
                            label3.Text = "Empty";
                        }
                        else
                        {
                            uint register3 = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            uint register4 = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                            ulong combinedRegister = ((ulong)register3 << 16) | register4;
                            byte[] bytes = BitConverter.GetBytes(combinedRegister);
                            /*
                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(bytes);
                            }
                            */
                            float floatValue = BitConverter.ToSingle(bytes, 0);
                            if (index == 7)
                            {
                                label3.Text = floatValue.ToString("0.000");
                            }
                            else
                            {
                                float normalValue = 1f / floatValue;
                                label3.Text = normalValue.ToString("0.000");
                            }
                        }
                    }
                    if (master2 != null && Properties.Settings.Default.Read_type == 3 && (index == 6 || index == 7))
                    {
                        if (numAddress.Value == 0)
                        {
                            label3.Text = "000.000";
                        }
                        else if (numAddress.Value % 2 == 1)
                        {
                            label3.Text = "Empty";
                        }
                        else
                        {
                            uint register3 = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            uint register4 = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                            ulong combinedRegister = ((ulong)register3 << 16) | register4;
                            byte[] bytes = BitConverter.GetBytes(combinedRegister);
                            /*
                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(bytes);
                            }
                            */
                            float floatValue = BitConverter.ToSingle(bytes, 0);
                            if (index == 7)
                            {
                                label3.Text = floatValue.ToString("0.000");
                            }
                            else
                            {
                                float normalValue = 1f / floatValue;
                                label3.Text = normalValue.ToString("0.000");
                            }
                        }
                    }
                    ////////////////DOUBLE
                    if (master2 != null && Properties.Settings.Default.Read_type == 4 && (index == 8 || index == 9))
                    {
                        if (numAddress.Value % 4 == 0)
                        {
                            ushort value1 = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            ushort value2 = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                            ushort value3 = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 2), 1)[0];
                            ushort value4 = master2.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 3), 1)[0];
                            byte[] bytes = new byte[8];
                            bytes[0] = (byte)value1;
                            bytes[1] = (byte)(value1 >> 8);
                            bytes[2] = (byte)value2;
                            bytes[3] = (byte)(value2 >> 8);
                            bytes[4] = (byte)value3;
                            bytes[5] = (byte)(value3 >> 8);
                            bytes[6] = (byte)value4;
                            bytes[7] = (byte)(value4 >> 8);
                            double combinedValue = BitConverter.ToDouble(bytes, 0);
                            if (index == 8)
                            {
                                label3.Text = combinedValue.ToString();
                            }
                            else
                            {
                                double inversedouble = 1 / combinedValue;
                                label3.Text = inversedouble.ToString();
                            }
                        }
                        else
                            label3.Text = "Empty";
                    }
                    if (master2 != null && Properties.Settings.Default.Read_type == 3 && (index == 8 || index == 9))
                    {
                        if (numAddress.Value % 4 == 0)
                        {
                            ushort value1 = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            ushort value2 = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                            ushort value3 = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 2), 1)[0];
                            ushort value4 = master2.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 3), 1)[0];
                            byte[] bytes = new byte[8];
                            bytes[0] = (byte)value1;
                            bytes[1] = (byte)(value1 >> 8);
                            bytes[2] = (byte)value2;
                            bytes[3] = (byte)(value2 >> 8);
                            bytes[4] = (byte)value3;
                            bytes[5] = (byte)(value3 >> 8);
                            bytes[6] = (byte)value4;
                            bytes[7] = (byte)(value4 >> 8);
                            double combinedValue = BitConverter.ToDouble(bytes, 0);
                            if (index == 8)
                            {
                                label3.Text = combinedValue.ToString();
                            }
                            else
                            {
                                double inversedouble = 1 / combinedValue;
                                label3.Text = inversedouble.ToString();
                            }
                        }
                        else
                            label3.Text = "Empty";
                    }
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233088)
                        MessageBox.Show(this, "Address is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (serialPort.IsOpen)
            {
               
                try
                {
                    //////////////SIGNED
                    if (master != null && Properties.Settings.Default.Read_type == 4 && index == 0)
                    {

                        short value = (short)master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        label3.Text = value.ToString("0.0");
                    }
                    if (master != null && Properties.Settings.Default.Read_type == 3 && index == 0)
                    {

                        short value = (short)master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        label3.Text = value.ToString("0.0");
                    }
                    //////////////UNSIGNED
                    if (master != null && Properties.Settings.Default.Read_type == 4 && index == 1)
                    {
                        ushort Value = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        label3.Text = Value.ToString("0.0");
                    }
                    if (master != null && Properties.Settings.Default.Read_type == 3 && index == 1)
                    {
                        ushort Value = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        label3.Text = Value.ToString("0.0");
                    }
                    ///////////////HEX
                    if (master != null && Properties.Settings.Default.Read_type == 4 && index == 2)
                    {
                        ushort Value = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        byte[] bytes = BitConverter.GetBytes(decimal.ToUInt32(Value));
                        string hexValue = BitConverter.ToString(bytes).Replace("-", "");
                        hexValue = hexValue.Substring(0, 4);
                        label3.Text = "0x" + hexValue;
                    }
                    if (master != null && Properties.Settings.Default.Read_type == 3 && index == 2)
                    {
                        ushort Value = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        byte[] bytes = BitConverter.GetBytes(decimal.ToUInt32(Value));
                        string hexValue = BitConverter.ToString(bytes).Replace("-", "");
                        hexValue = hexValue.Substring(0, 4);
                        label3.Text = "0x" + hexValue;
                    }
                    ///////////////BINARY
                    if (master != null && Properties.Settings.Default.Read_type == 4 && index == 3)
                    {
                        ushort Value = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        uint nou = Convert.ToUInt16(Value.ToString());
                        string binaryValue = Convert.ToString((int)nou, 2);
                        if (nou == 0)
                            label3.Text = "000000000000000";
                        else
                            label3.Text = binaryValue;
                    }
                    if (master != null && Properties.Settings.Default.Read_type == 3 && index == 3)
                    {
                        ushort Value = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                        uint nou = Convert.ToUInt16(Value.ToString());
                        string binaryValue = Convert.ToString((int)nou, 2);
                        if (nou == 0)
                            label3.Text = "000000000000000";
                        else
                            label3.Text = binaryValue;
                    }
                    ////////////////LONG
                    if (master != null && Properties.Settings.Default.Read_type == 4 && (index == 4 || index == 5))
                    {
                        if (numAddress.Value == 0)
                        {
                            label3.Text = "0";
                        }
                        else if (numAddress.Value % 2 == 0)
                        {
                            label3.Text = "Empty";
                        }
                        else
                        {
                            ushort valueu1 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            ushort valueu2 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0]; ;
                            short value1 = (short)valueu1;
                            short value2 = (short)valueu2;
                            if (index == 4)
                            {
                                long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                label3.Text = combinedValue.ToString();
                            }
                            else
                            {
                                long inversecombinedValue = ((long)((ushort)value2) << 16) | (ushort)value1;
                                label3.Text = inversecombinedValue.ToString();
                            }
                        }
                    }
                    if (master != null && Properties.Settings.Default.Read_type == 3 && (index == 4 || index == 5))
                    {
                        if (numAddress.Value == 0)
                        {
                            label3.Text = "0";
                        }
                        else if (numAddress.Value % 2 == 0)
                        {
                            label3.Text = "Empty";
                        }
                        else
                        {
                            ushort valueu1 = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            ushort valueu2 = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0]; ;
                            short value1 = (short)valueu1;
                            short value2 = (short)valueu2;
                            if (index == 4)
                            {
                                long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                label3.Text = combinedValue.ToString();
                            }
                            else
                            {
                                long inversecombinedValue = ((long)((ushort)value2) << 16) | (ushort)value1;
                                label3.Text = inversecombinedValue.ToString();
                            }
                        }
                    }
                    ////////////////FLOAT
                    if (master != null && Properties.Settings.Default.Read_type == 4 && (index == 6 || index == 7))
                    {
                       if (numAddress.Value % 2 == 0)
                        {
                            label3.Text = "Empty";
                        }
                        else
                        {
                            uint register3 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            uint register4 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                            ulong combinedRegister = ((ulong)register3 << 16) | register4;
                            byte[] bytes = BitConverter.GetBytes(combinedRegister);
                            /*
                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(bytes);
                            }
                            */
                            float floatValue = BitConverter.ToSingle(bytes, 0);
                            if (index == 7)
                            {
                                label3.Text = floatValue.ToString("0.000");
                            }
                            else
                            {
                                uint register5 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                                uint register6 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                                ulong inversecombinedRegister = ((ulong)register6 << 16) | register5;
                                byte[] inversebytes = BitConverter.GetBytes(combinedRegister);
                                /*
                                if (BitConverter.IsLittleEndian)
                                {
                                    Array.Reverse(bytes);
                                }
                                */
                                float inversefloatValue = BitConverter.ToSingle(bytes, 0);
                                label3.Text = inversefloatValue.ToString("0.000");
                            }
                        }
                    }
                    if (master != null && Properties.Settings.Default.Read_type == 3 && (index == 6 || index == 7))
                    {
                        if (numAddress.Value == 0)
                        {
                            label3.Text = "000.000";
                        }
                        else if (numAddress.Value % 2 == 0)
                        {
                            label3.Text = "Empty";
                        }
                        else
                        {
                            uint register3 = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            uint register4 = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                            ulong combinedRegister = ((ulong)register3 << 16) | register4;
                            byte[] bytes = BitConverter.GetBytes(combinedRegister);
                            /*
                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(bytes);
                            }
                            */
                            float floatValue = BitConverter.ToSingle(bytes, 0);
                            if (index == 7)
                            {
                                label3.Text = floatValue.ToString("0.000");
                            }
                            else
                            {
                                uint register5 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                                uint register6 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                                ulong inversecombinedRegister = ((ulong)register6 << 16) | register5;
                                byte[] inversebytes = BitConverter.GetBytes(combinedRegister);
                                /*
                                if (BitConverter.IsLittleEndian)
                                {
                                    Array.Reverse(bytes);
                                }
                                */
                                float inversefloatValue = BitConverter.ToSingle(bytes, 0);
                                label3.Text = inversefloatValue.ToString("0.000");
                            }
                        }
                    }
                    ////////////////DOUBLE
                    if (master != null && Properties.Settings.Default.Read_type == 4 && (index == 8 || index == 9))
                    {
                        if (numAddress.Value % 4 == 0)
                        {
                            ushort value1 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            ushort value2 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                            ushort value3 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 2), 1)[0];
                            ushort value4 = master.ReadInputRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 3), 1)[0];
                            byte[] bytes = new byte[8];
                            bytes[0] = (byte)value1;
                            bytes[1] = (byte)(value1 >> 8);
                            bytes[2] = (byte)value2;
                            bytes[3] = (byte)(value2 >> 8);
                            bytes[4] = (byte)value3;
                            bytes[5] = (byte)(value3 >> 8);
                            bytes[6] = (byte)value4;
                            bytes[7] = (byte)(value4 >> 8);
                            double combinedValue = BitConverter.ToDouble(bytes, 0);
                            if (index == 8)
                            {
                                label3.Text = combinedValue.ToString();
                            }
                            else
                            {
                                bytes[0] = (byte)value4;
                                bytes[1] = (byte)(value4 >> 8);
                                bytes[2] = (byte)value3;
                                bytes[3] = (byte)(value3 >> 8);
                                bytes[4] = (byte)value2;
                                bytes[5] = (byte)(value2 >> 8);
                                bytes[6] = (byte)value1;
                                bytes[7] = (byte)(value1 >> 8);
                                double inversedouble = BitConverter.ToDouble(bytes, 0);
                                label3.Text = inversedouble.ToString();
                            }
                        }
                        else
                            label3.Text = "Empty";
                    }
                    if (master != null && Properties.Settings.Default.Read_type == 3 && (index == 8 || index == 9))
                    {
                        if (numAddress.Value % 4 == 0)
                        {
                            ushort value1 = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value), 1)[0];
                            ushort value2 = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 1), 1)[0];
                            ushort value3 = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 2), 1)[0];
                            ushort value4 = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(numAddress.Value + 3), 1)[0];
                            byte[] bytes = new byte[8];
                            bytes[0] = (byte)value1;
                            bytes[1] = (byte)(value1 >> 8);
                            bytes[2] = (byte)value2;
                            bytes[3] = (byte)(value2 >> 8);
                            bytes[4] = (byte)value3;
                            bytes[5] = (byte)(value3 >> 8);
                            bytes[6] = (byte)value4;
                            bytes[7] = (byte)(value4 >> 8);
                            double combinedValue = BitConverter.ToDouble(bytes, 0);
                            if (index == 8)
                            {
                                label3.Text = combinedValue.ToString();
                            }
                            else
                            {
                                bytes[0] = (byte)value4;
                                bytes[1] = (byte)(value4 >> 8);
                                bytes[2] = (byte)value3;
                                bytes[3] = (byte)(value3 >> 8);
                                bytes[4] = (byte)value2;
                                bytes[5] = (byte)(value2 >> 8);
                                bytes[6] = (byte)value1;
                                bytes[7] = (byte)(value1 >> 8);
                                double inversedouble = BitConverter.ToDouble(bytes, 0);
                                label3.Text = inversedouble.ToString();
                            }
                        }
                        else
                            label3.Text = "Empty";
                    }
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233088)
                        MessageBox.Show(this, "Address is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public byte[] CreateTCPModbusRequest(byte slaveAddress, ushort startAddressTCP, ushort quantityTCP)
        {
            List<byte> request = new List<byte>();
            //Protocol ID
            request.Add((byte)(TCPtimer>>8));
            request.Add((byte)TCPtimer);
            // Adauga TCP protocol identifier
            request.Add((byte)(00));
            request.Add((byte)(00));
            //Adaugam indexul de valori care urmeaza
            int num = 1 + 1 + 2 + 2;
            request.Add((byte)(num >> 8));
            request.Add((byte)num);
            // Adaugă adresa Slave în cerere
            request.Add((byte)slaveAddress);
            // Adaugă codul de funcție (citirea registrelor de intrare)
            request.Add((byte)Properties.Settings.Default.Read_type);
            // Adaugă numărul de registre (împărțit în două octeți)
            request.Add((byte)(startAddressTCP >> 8));
            request.Add((byte)startAddressTCP);
            // Adaugă numărul de registre (împărțit în două octeți)
            request.Add((byte)(quantityTCP >> 8));
            request.Add((byte)quantityTCP);
            return request.ToArray();
        }
        public byte[] CreateModbusRequest(byte slaveAddress, ushort startAddress, ushort quantity)
        {
            byte[] req = { (byte)(slaveAddress >> 8), (byte)slaveAddress, (byte)Properties.Settings.Default.Read_type, (byte)(startAddress >> 8), (byte)startAddress, (byte)(quantity >> 8), (byte)quantity };
            byte[] crc = ModbusUtility.CalculateCrc(req);
            byte[] Request = new byte[req.Length + crc.Length];
            Array.Copy(req, 0, Request, 0, req.Length);
            Array.Copy(crc, 0, Request, req.Length, crc.Length);
            return Request;
        }
        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    checkedListBox1.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }
        public void seeTrafficToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            if (toolStripStatusLabel6.Text == "Connected")
            {
                Communication comms = new Communication();
                var result = comms.ShowDialog(this);
            }
            else
            {
                string imagePath = "..\\..\\..\\..\\LICENTA\\ModBusV1\\Resources\\dino_offline.jpg";
                System.Drawing.Image backgroundImg = System.Drawing.Image.FromFile(imagePath);
                this.BackgroundImage = backgroundImg;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }
        private void sendaddress_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(newaddress.Text, out number))
            {
                int index = checkedListBox1.SelectedIndex;
                if (client.Connected)
                {
                    if (int.Parse(newaddress.Text) > 0)
                    {
                        Properties.Settings.Default.startAddress = ushort.Parse(newaddress.Text);
                        ushort startaddr = ushort.Parse(newaddress.Text);
                        int n;
                        for (n = 30; n < Properties.Settings.Default.quantityTCP+30; n++)
                        {
                            string labelName = "label" + n;
                            Control[] controls = this.Controls.Find(labelName, true);
                            if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                            {
                                try
                                {
                                        //////////////SIGNED
                                        if (master2 != null && Properties.Settings.Default.Read_type == 4 && index == 0)
                                        {
                                            ushort[] registerInputValues = master2.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 1);
                                            Properties.Settings.Default.startAddress++;
                                            short value = (short)registerInputValues[0];
                                            targetLabel.Text = value.ToString("0.0");
                                        }
                                        if (master2 != null && Properties.Settings.Default.Read_type == 3 && index == 0)
                                        {
                                          ushort[] registerHoldingValues = master2.ReadHoldingRegisters(slaveAddress, startaddr, 1);
                                          startaddr++;
                                        short value = (short)registerHoldingValues[0];
                                            targetLabel.Text = value.ToString("0.0");
                                        }
                                        //////////////UNSIGNED
                                        if (master2 != null && Properties.Settings.Default.Read_type == 4 && index == 1)
                                        {
                                            ushort[] registerInputValues = master2.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 1);
                                            Properties.Settings.Default.startAddress++;
                                            targetLabel.Text = registerInputValues[0].ToString("0.0");
                                        }
                                        if (master2 != null && Properties.Settings.Default.Read_type == 3 && index == 1)
                                        {
                                        ushort[] registerHoldingValues = master2.ReadHoldingRegisters(slaveAddress, startaddr, 1);
                                        startaddr++;
                                        targetLabel.Text = registerHoldingValues[0].ToString("0.0");
                                        }
                                        ///////////////HEX
                                        if (master2 != null && Properties.Settings.Default.Read_type == 4 && index == 2)
                                        {
                                            ushort[] registerInputValues = master2.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 4);
                                            Properties.Settings.Default.startAddress++;
                                            ushort value = registerInputValues[0];
                                            byte[] bytes = BitConverter.GetBytes(decimal.ToUInt32(value));
                                            string hexValue = BitConverter.ToString(bytes).Replace("-", "");
                                            hexValue = hexValue.Substring(0, 4);
                                            targetLabel.Text = "0x" + hexValue;
                                        }
                                        if (master2 != null && Properties.Settings.Default.Read_type == 3 && index == 2)
                                        {
                                        ushort[] registerHoldingValues = master2.ReadHoldingRegisters(slaveAddress, startaddr, 1);
                                        startaddr++;
                                        ushort value = registerHoldingValues[0];
                                            byte[] bytes = BitConverter.GetBytes(decimal.ToUInt32(value));
                                            string hexValue = BitConverter.ToString(bytes).Replace("-", "");
                                            hexValue = hexValue.Substring(0, 4);
                                            targetLabel.Text = "0x" + hexValue;
                                        }
                                        ///////////////BINARY
                                        if (master2 != null && Properties.Settings.Default.Read_type == 4 && index == 3)
                                        {
                                            ushort[] registerInputValues = master2.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 1);
                                            Properties.Settings.Default.startAddress++;
                                            ushort value = registerInputValues[0];
                                            uint nou = Convert.ToUInt16(value.ToString());
                                            string binaryValue = Convert.ToString((int)nou, 2);
                                            if (nou == 0)
                                                targetLabel.Text = "000000000000000";
                                            else
                                                targetLabel.Text = binaryValue;
                                        }
                                        if (master2 != null && Properties.Settings.Default.Read_type == 3 && index == 3)
                                        {
                                        ushort[] registerHoldingValues = master2.ReadHoldingRegisters(slaveAddress, startaddr, 1);
                                        startaddr++;
                                        ushort value = registerHoldingValues[0];
                                            uint nou = Convert.ToUInt16(value.ToString());
                                            string binaryValue = Convert.ToString((int)nou, 2);
                                            if (nou == 0)
                                                targetLabel.Text = "000000000000000";
                                            else
                                                targetLabel.Text = binaryValue;
                                        }
                                        ////////////////LONG
                                        if (master2 != null && Properties.Settings.Default.Read_type == 4 && (index == 4 || index == 5))
                                        {
                                            ushort[] registerInputValues = master2.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 2);
                                            Properties.Settings.Default.startAddress++;
                                            if (((Properties.Settings.Default.startAddress - 1) % 1000) % 2 == 0)
                                            {
                                                targetLabel.Text = "Empty";
                                            }
                                            else
                                            {
                                                ushort valueu1 = registerInputValues[0];
                                                ushort valueu2 = registerInputValues[1];
                                                short value1 = (short)valueu1;
                                                short value2 = (short)valueu2;
                                                if (index == 4)
                                                {
                                                    long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                                    targetLabel.Text = combinedValue.ToString();
                                                }
                                                else
                                                {
                                                    long inversecombinedValue = ((long)((ushort)value2) << 16) | (ushort)value1;
                                                    targetLabel.Text = inversecombinedValue.ToString();
                                                }
                                            }
                                        }
                                        if (master2 != null && Properties.Settings.Default.Read_type == 3 && (index == 4 || index == 5))
                                        {
                                        ushort[] registerHoldingValues = master2.ReadHoldingRegisters(slaveAddress, startaddr, 2);
                                        startaddr++;
                                        if (((Properties.Settings.Default.startAddress - 1) % 1000) % 2 == 0)
                                            {
                                                targetLabel.Text = "Empty";
                                            }
                                            else
                                            {
                                                ushort valueu1 = registerHoldingValues[0];
                                                ushort valueu2 = registerHoldingValues[1];
                                                short value1 = (short)valueu1;
                                                short value2 = (short)valueu2;
                                                if (index == 4)
                                                {
                                                    long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                                    targetLabel.Text = combinedValue.ToString();
                                                }
                                                else
                                                {
                                                    long inversecombinedValue = ((long)((ushort)value2) << 16) | (ushort)value1;
                                                    targetLabel.Text = inversecombinedValue.ToString();
                                                }
                                            }
                                        }
                                        ////////////////FLOAT
                                        if (master2 != null && Properties.Settings.Default.Read_type == 4 && (index == 6 || index == 7))
                                        {
                                            ushort[] registerInputValues = master2.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 2);
                                            Properties.Settings.Default.startAddress++;
                                            if (((Properties.Settings.Default.startAddress - 1) % 1000) % 2 == 0)
                                            {
                                                targetLabel.Text = "Empty";
                                            }
                                            else
                                            {
                                                uint register3 = registerInputValues[0];
                                                uint register4 = registerInputValues[1];
                                                ulong combinedRegister = ((ulong)register3 << 16) | register4;
                                                byte[] bytes = BitConverter.GetBytes(combinedRegister);
                                                /*
                                                if (BitConverter.IsLittleEndian)
                                                {
                                                    Array.Reverse(bytes);
                                                }
                                                */
                                                float floatValue = BitConverter.ToSingle(bytes, 0);
                                                if (index == 7)
                                                {
                                                    targetLabel.Text = floatValue.ToString("0.000");
                                                }
                                                else
                                                {
                                                    uint register5 = registerInputValues[0];
                                                    uint register6 = registerInputValues[1];
                                                    ulong inversecombinedRegister = ((ulong)register6 << 16) | register5;
                                                    byte[] inversebytes = BitConverter.GetBytes(combinedRegister);
                                                    /*
                                                    if (BitConverter.IsLittleEndian)
                                                    {
                                                        Array.Reverse(bytes);
                                                    }
                                                    */
                                                    float inversefloatValue = BitConverter.ToSingle(bytes, 0);
                                                    targetLabel.Text = inversefloatValue.ToString("0.000");
                                                }
                                            }
                                        }
                                        if (master2 != null && Properties.Settings.Default.Read_type == 3 && (index == 6 || index == 7))
                                        {
                                        ushort[] registerHoldingValues = master2.ReadHoldingRegisters(slaveAddress, startaddr, 2);
                                        startaddr++;
                                        if (((startaddr - 1) % 1000) % 2 == 0)
                                            {
                                                targetLabel.Text = "Empty";
                                            }
                                            else
                                            {
                                                uint register3 = registerHoldingValues[0];
                                                uint register4 = registerHoldingValues[1];
                                                ulong combinedRegister = ((ulong)register3 << 16) | register4;
                                                byte[] bytes = BitConverter.GetBytes(combinedRegister);
                                                /*
                                                if (BitConverter.IsLittleEndian)
                                                {
                                                    Array.Reverse(bytes);
                                                }
                                                */
                                                float floatValue = BitConverter.ToSingle(bytes, 0);
                                                if (index == 7)
                                                {
                                                    targetLabel.Text = floatValue.ToString("0.000");
                                                }
                                                else
                                                {
                                                    uint register5 = registerHoldingValues[0];
                                                    uint register6 = registerHoldingValues[1];
                                                    ulong inversecombinedRegister = ((ulong)register6 << 16) | register5;
                                                    byte[] inversebytes = BitConverter.GetBytes(combinedRegister);
                                                    /*
                                                    if (BitConverter.IsLittleEndian)
                                                    {
                                                        Array.Reverse(bytes);
                                                    }
                                                    */
                                                    float inversefloatValue = BitConverter.ToSingle(bytes, 0);
                                                    targetLabel.Text = inversefloatValue.ToString("0.000");
                                                }
                                            }
                                        }
                                        ////////////////DOUBLE
                                        if (master2 != null && Properties.Settings.Default.Read_type == 4 && (index == 8 || index == 9))
                                        {
                                            ushort[] registerInputValues = master2.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 4);
                                            Properties.Settings.Default.startAddress++;
                                            if (((Properties.Settings.Default.startAddress - 1) % 1000) % 4 == 1)
                                            {
                                                ushort value1 = registerInputValues[0];
                                                ushort value2 = registerInputValues[1];
                                                ushort value3 = registerInputValues[2];
                                                ushort value4 = registerInputValues[3];
                                                byte[] bytes = new byte[8];
                                                bytes[0] = (byte)value1;
                                                bytes[1] = (byte)(value1 >> 8);
                                                bytes[2] = (byte)value2;
                                                bytes[3] = (byte)(value2 >> 8);
                                                bytes[4] = (byte)value3;
                                                bytes[5] = (byte)(value3 >> 8);
                                                bytes[6] = (byte)value4;
                                                bytes[7] = (byte)(value4 >> 8);
                                                double combinedValue = BitConverter.ToDouble(bytes, 0);
                                                if (index == 8)
                                                {
                                                    targetLabel.Text = combinedValue.ToString();
                                                }
                                                else
                                                {
                                                    bytes[0] = (byte)value4;
                                                    bytes[1] = (byte)(value4 >> 8);
                                                    bytes[2] = (byte)value3;
                                                    bytes[3] = (byte)(value3 >> 8);
                                                    bytes[4] = (byte)value2;
                                                    bytes[5] = (byte)(value2 >> 8);
                                                    bytes[6] = (byte)value1;
                                                    bytes[7] = (byte)(value1 >> 8);
                                                    double inversedouble = BitConverter.ToDouble(bytes, 0);
                                                    targetLabel.Text = inversedouble.ToString();
                                                }
                                            }
                                            else
                                                targetLabel.Text = "Empty";
                                        }
                                        if (master2 != null && Properties.Settings.Default.Read_type == 3 && (index == 8 || index == 9))
                                        {
                                        ushort[] registerHoldingValues = master2.ReadHoldingRegisters(slaveAddress, startaddr, 4);
                                        startaddr++;
                                        if (((startaddr - 1) % 1000) % 4 == 1)
                                            {
                                                ushort value1 = registerHoldingValues[0];
                                                ushort value2 = registerHoldingValues[1];
                                                ushort value3 = registerHoldingValues[2];
                                                ushort value4 = registerHoldingValues[3];
                                                byte[] bytes = new byte[8];
                                                bytes[0] = (byte)value1;
                                                bytes[1] = (byte)(value1 >> 8);
                                                bytes[2] = (byte)value2;
                                                bytes[3] = (byte)(value2 >> 8);
                                                bytes[4] = (byte)value3;
                                                bytes[5] = (byte)(value3 >> 8);
                                                bytes[6] = (byte)value4;
                                                bytes[7] = (byte)(value4 >> 8);
                                                double combinedValue = BitConverter.ToDouble(bytes, 0);
                                                if (index == 8)
                                                {
                                                    targetLabel.Text = combinedValue.ToString();
                                                }
                                                else
                                                {
                                                    bytes[0] = (byte)value4;
                                                    bytes[1] = (byte)(value4 >> 8);
                                                    bytes[2] = (byte)value3;
                                                    bytes[3] = (byte)(value3 >> 8);
                                                    bytes[4] = (byte)value2;
                                                    bytes[5] = (byte)(value2 >> 8);
                                                    bytes[6] = (byte)value1;
                                                    bytes[7] = (byte)(value1 >> 8);
                                                    double inversedouble = BitConverter.ToDouble(bytes, 0);
                                                    targetLabel.Text = inversedouble.ToString();
                                                }
                                            }
                                            else
                                                targetLabel.Text = "Empty";
                                        }
                                }
                                catch (Exception ex)
                                {
                                    targetLabel.Text = "Error: " + ex.Message;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Re-Enter the Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (serialPort.IsOpen)
                {
                    Properties.Settings.Default.startAddress = ushort.Parse(newaddress.Text);
                    ushort startaddr = ushort.Parse(newaddress.Text);
                    int n;
                    for (n = 30; n < Properties.Settings.Default.quantityTCP + 30; n++)
                    {
                        string labelName = "label" + n;
                        Control[] controls = this.Controls.Find(labelName, true);
                        if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                        {
                            try
                            {
                                    //////////////SIGNED
                                    if (master != null && Properties.Settings.Default.Read_type == 4 && index == 0)
                                    {
                                        ushort[] registerInputValues = master.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 1);
                                        Properties.Settings.Default.startAddress++;
                                        short value = (short)registerInputValues[0];
                                        targetLabel.Text = value.ToString("0.0");
                                    }
                                    if (master != null && Properties.Settings.Default.Read_type == 3 && index == 0)
                                    {
                                    ushort[] registerHoldingValues = master.ReadHoldingRegisters(slaveAddress, startaddr, 1);
                                    startaddr++;
                                    short value = (short)registerHoldingValues[0];
                                        targetLabel.Text = value.ToString("0.0");
                                    }
                                    //////////////UNSIGNED
                                    if (master != null && Properties.Settings.Default.Read_type == 4 && index == 1)
                                    {
                                    ushort[] registerInputValues = master.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 1);
                                    Properties.Settings.Default.startAddress++;
                                    targetLabel.Text = registerInputValues[0].ToString("0.0");
                                    }
                                    if (master != null && Properties.Settings.Default.Read_type == 3 && index == 1)
                                    {
                                    ushort[] registerHoldingValues = master.ReadHoldingRegisters(slaveAddress, startaddr, 1);
                                    startaddr++;
                                    targetLabel.Text = registerHoldingValues[0].ToString("0.0");
                                    }
                                    ///////////////HEX
                                    if (master != null && Properties.Settings.Default.Read_type == 4 && index == 2)
                                    {
                                    ushort[] registerInputValues = master.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 1);
                                    Properties.Settings.Default.startAddress++;
                                    ushort value = registerInputValues[0];
                                        byte[] bytes = BitConverter.GetBytes(decimal.ToUInt32(value));
                                        string hexValue = BitConverter.ToString(bytes).Replace("-", "");
                                        hexValue = hexValue.Substring(0, 4);
                                        targetLabel.Text = "0x" + hexValue;
                                    }
                                    if (master != null && Properties.Settings.Default.Read_type == 3 && index == 2)
                                    {
                                    ushort[] registerHoldingValues = master.ReadHoldingRegisters(slaveAddress, startaddr, 1);
                                    startaddr++;
                                    ushort value = registerHoldingValues[0];
                                        byte[] bytes = BitConverter.GetBytes(decimal.ToUInt32(value));
                                        string hexValue = BitConverter.ToString(bytes).Replace("-", "");
                                        hexValue = hexValue.Substring(0, 4);
                                        targetLabel.Text = "0x" + hexValue;
                                    }
                                    ///////////////BINARY
                                    if (master != null && Properties.Settings.Default.Read_type == 4 && index == 3)
                                    {
                                    ushort[] registerInputValues = master.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 1);
                                    Properties.Settings.Default.startAddress++;
                                    ushort value = registerInputValues[0];
                                        uint nou = Convert.ToUInt16(value.ToString());
                                        string binaryValue = Convert.ToString((int)nou, 2);
                                        if (nou == 0)
                                            targetLabel.Text = "000000000000000";
                                        else
                                            targetLabel.Text = binaryValue;
                                    }
                                    if (master != null && Properties.Settings.Default.Read_type == 3 && index == 3)
                                    {
                                    ushort[] registerHoldingValues = master.ReadHoldingRegisters(slaveAddress, startaddr, 1);
                                    startaddr++;
                                    ushort value = registerHoldingValues[0];
                                        uint nou = Convert.ToUInt16(value.ToString());
                                        string binaryValue = Convert.ToString((int)nou, 2);
                                        if (nou == 0)
                                            targetLabel.Text = "000000000000000";
                                        else
                                            targetLabel.Text = binaryValue;
                                    }
                                    ////////////////LONG
                                    if (master != null && Properties.Settings.Default.Read_type == 4 && (index == 4 || index == 5))
                                    {
                                    ushort[] registerInputValues = master.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 2);
                                    Properties.Settings.Default.startAddress++;
                                    if (((Properties.Settings.Default.startAddress - 1) % 1000) % 2 == 0)
                                        {
                                            targetLabel.Text = "Empty";
                                        }
                                        else
                                        {
                                            ushort valueu1 = registerInputValues[0];
                                            ushort valueu2 = registerInputValues[1];
                                            short value1 = (short)valueu1;
                                            short value2 = (short)valueu2;
                                            if (index == 4)
                                            {
                                                long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                                targetLabel.Text = combinedValue.ToString();
                                            }
                                            else
                                            {
                                                long inversecombinedValue = ((long)((ushort)value2) << 16) | (ushort)value1;
                                                targetLabel.Text = inversecombinedValue.ToString();
                                            }
                                        }
                                    }
                                    if (master != null && Properties.Settings.Default.Read_type == 3 && (index == 4 || index == 5))
                                    {
                                    ushort[] registerHoldingValues = master.ReadHoldingRegisters(slaveAddress, startaddr, 2);
                                    startaddr++;
                                    if (((Properties.Settings.Default.startAddress - 1) % 1000) % 2 == 0)
                                        {
                                            targetLabel.Text = "Empty";
                                        }
                                        else
                                        {
                                            ushort valueu1 = registerHoldingValues[0];
                                            ushort valueu2 = registerHoldingValues[1];
                                            short value1 = (short)valueu1;
                                            short value2 = (short)valueu2;
                                            if (index == 4)
                                            {
                                                long combinedValue = ((long)((ushort)value1) << 16) | (ushort)value2;
                                                targetLabel.Text = combinedValue.ToString();
                                            }
                                            else
                                            {
                                                long inversecombinedValue = ((long)((ushort)value2) << 16) | (ushort)value1;
                                                targetLabel.Text = inversecombinedValue.ToString();
                                            }
                                        }
                                    }
                                    ////////////////FLOAT
                                    if (master != null && Properties.Settings.Default.Read_type == 4 && (index == 6 || index == 7))
                                    {
                                    ushort[] registerInputValues = master.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 2);
                                    Properties.Settings.Default.startAddress++;
                                    if (((Properties.Settings.Default.startAddress - 1) % 1000) % 2 == 0)
                                        {
                                            targetLabel.Text = "Empty";
                                        }
                                        else
                                        {
                                            uint register3 = registerInputValues[0];
                                            uint register4 = registerInputValues[1];
                                            ulong combinedRegister = ((ulong)register3 << 16) | register4;
                                            byte[] bytes = BitConverter.GetBytes(combinedRegister);
                                            /*
                                            if (BitConverter.IsLittleEndian)
                                            {
                                                Array.Reverse(bytes);
                                            }
                                            */
                                            float floatValue = BitConverter.ToSingle(bytes, 0);
                                            if (index == 7)
                                            {
                                                targetLabel.Text = floatValue.ToString("0.000");
                                            }
                                            else
                                            {
                                                uint register5 = registerInputValues[0];
                                                uint register6 = registerInputValues[1];
                                                ulong inversecombinedRegister = ((ulong)register6 << 16) | register5;
                                                byte[] inversebytes = BitConverter.GetBytes(combinedRegister);
                                                /*
                                                if (BitConverter.IsLittleEndian)
                                                {
                                                    Array.Reverse(bytes);
                                                }
                                                */
                                                float inversefloatValue = BitConverter.ToSingle(bytes, 0);
                                                targetLabel.Text = inversefloatValue.ToString("0.000");
                                            }
                                        }
                                    }
                                    if (master != null && Properties.Settings.Default.Read_type == 3 && (index == 6 || index == 7))
                                    {
                                    ushort[] registerHoldingValues = master.ReadHoldingRegisters(slaveAddress, startaddr, 2);
                                    startaddr++;
                                    if (((startaddr - 1) % 1000) % 2 == 0)
                                        {
                                            targetLabel.Text = "Empty";
                                        }
                                        else
                                        {
                                            uint register3 = registerHoldingValues[0];
                                            uint register4 = registerHoldingValues[1];
                                            ulong combinedRegister = ((ulong)register3 << 16) | register4;
                                            byte[] bytes = BitConverter.GetBytes(combinedRegister);
                                            /*
                                            if (BitConverter.IsLittleEndian)
                                            {
                                                Array.Reverse(bytes);
                                            }
                                            */
                                            float floatValue = BitConverter.ToSingle(bytes, 0);
                                            if (index == 7)
                                            {
                                                targetLabel.Text = floatValue.ToString("0.000");
                                            }
                                            else
                                            {
                                                uint register5 = registerHoldingValues[0];
                                                uint register6 = registerHoldingValues[1];
                                                ulong inversecombinedRegister = ((ulong)register6 << 16) | register5;
                                                byte[] inversebytes = BitConverter.GetBytes(combinedRegister);
                                                /*
                                                if (BitConverter.IsLittleEndian)
                                                {
                                                    Array.Reverse(bytes);
                                                }
                                                */
                                                float inversefloatValue = BitConverter.ToSingle(bytes, 0);
                                                targetLabel.Text = inversefloatValue.ToString("0.000");
                                            }
                                        }
                                    }
                                    ////////////////DOUBLE
                                    if (master != null && Properties.Settings.Default.Read_type == 4 && (index == 8 || index == 9))
                                    {
                                    ushort[] registerInputValues = master.ReadInputRegisters(slaveAddress, Properties.Settings.Default.startAddress, 4);
                                    Properties.Settings.Default.startAddress++;
                                    if (((Properties.Settings.Default.startAddress - 1) % 1000) % 4 == 1)
                                        {
                                            ushort value1 = registerInputValues[0];
                                            ushort value2 = registerInputValues[1];
                                            ushort value3 = registerInputValues[2];
                                            ushort value4 = registerInputValues[3];
                                            byte[] bytes = new byte[8];
                                            bytes[0] = (byte)value1;
                                            bytes[1] = (byte)(value1 >> 8);
                                            bytes[2] = (byte)value2;
                                            bytes[3] = (byte)(value2 >> 8);
                                            bytes[4] = (byte)value3;
                                            bytes[5] = (byte)(value3 >> 8);
                                            bytes[6] = (byte)value4;
                                            bytes[7] = (byte)(value4 >> 8);
                                            double combinedValue = BitConverter.ToDouble(bytes, 0);
                                            if (index == 8)
                                            {
                                                targetLabel.Text = combinedValue.ToString();
                                            }
                                            else
                                            {
                                                bytes[0] = (byte)value4;
                                                bytes[1] = (byte)(value4 >> 8);
                                                bytes[2] = (byte)value3;
                                                bytes[3] = (byte)(value3 >> 8);
                                                bytes[4] = (byte)value2;
                                                bytes[5] = (byte)(value2 >> 8);
                                                bytes[6] = (byte)value1;
                                                bytes[7] = (byte)(value1 >> 8);
                                                double inversedouble = BitConverter.ToDouble(bytes, 0);
                                                targetLabel.Text = inversedouble.ToString();
                                            }
                                        }
                                        else
                                            targetLabel.Text = "Empty";
                                    }
                                    if (master != null && Properties.Settings.Default.Read_type == 3 && (index == 8 || index == 9))
                                    {
                                    ushort[] registerHoldingValues = master.ReadHoldingRegisters(slaveAddress, startaddr, 4);
                                    startaddr++;
                                    if (((startaddr - 1) % 1000) % 4 == 1)
                                        {
                                            ushort value1 = registerHoldingValues[0];
                                            ushort value2 = registerHoldingValues[1];
                                            ushort value3 = registerHoldingValues[2];
                                            ushort value4 = registerHoldingValues[3];
                                            byte[] bytes = new byte[8];
                                            bytes[0] = (byte)value1;
                                            bytes[1] = (byte)(value1 >> 8);
                                            bytes[2] = (byte)value2;
                                            bytes[3] = (byte)(value2 >> 8);
                                            bytes[4] = (byte)value3;
                                            bytes[5] = (byte)(value3 >> 8);
                                            bytes[6] = (byte)value4;
                                            bytes[7] = (byte)(value4 >> 8);
                                            double combinedValue = BitConverter.ToDouble(bytes, 0);
                                            if (index == 8)
                                            {
                                                targetLabel.Text = combinedValue.ToString();
                                            }
                                            else
                                            {
                                                bytes[0] = (byte)value4;
                                                bytes[1] = (byte)(value4 >> 8);
                                                bytes[2] = (byte)value3;
                                                bytes[3] = (byte)(value3 >> 8);
                                                bytes[4] = (byte)value2;
                                                bytes[5] = (byte)(value2 >> 8);
                                                bytes[6] = (byte)value1;
                                                bytes[7] = (byte)(value1 >> 8);
                                                double inversedouble = BitConverter.ToDouble(bytes, 0);
                                                targetLabel.Text = inversedouble.ToString();
                                            }
                                        }
                                        else
                                            targetLabel.Text = "Empty";
                                    }
                            }
                            catch (Exception ex)
                            {
                                targetLabel.Text = "Error: " + ex.Message;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Incorrect Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void writeRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel6.Text == "Connected")
            {
                Functions function = new Functions();
                var result = function.ShowDialog(this);
                if (Properties.Settings.Default.writeEnable == 1 && serialPort.IsOpen)
                {
                    master.WriteSingleRegister(slaveAddress, Properties.Settings.Default.writeaddress, Properties.Settings.Default.writevalue);
                }
                if (Properties.Settings.Default.writeEnable == 1 && client.Connected) 
                {
                    master2.WriteSingleRegister(slaveAddress, Properties.Settings.Default.writeaddress, Properties.Settings.Default.writevalue);
                }
                if (Properties.Settings.Default.writeRegistersEnable == 1 && serialPort.IsOpen)
                {
                    ushort Quantity=Properties.Settings.Default.quantity;
                    while (Quantity != 0)
                    {
                        master.WriteSingleRegister(slaveAddress, Properties.Settings.Default.writeaddress, Properties.Settings.Default.writevalue);
                        Properties.Settings.Default.writeaddress++;
                        Properties.Settings.Default.writevalue++;
                        Quantity--;
                    }
                    Properties.Settings.Default.writeaddress--;
                    Properties.Settings.Default.writevalue--;
                }
                if (Properties.Settings.Default.writeRegistersEnable == 1 && client.Connected)
                {
                    int nr = Properties.Settings.Default.writequantity;
                    ushort Address = Properties.Settings.Default.writeaddress;
                    for (int i = 1; i <= nr; i++)
                    {
                        string labelName = "value" + i;
                        Control[] controls = this.Controls.Find(labelName, true);
                            string val= Properties.Settings.Default[labelName].ToString();
                            ushort value=ushort.Parse(val);
                            master2.WriteSingleRegister(slaveAddress, Address, value);
                            Address++;
                    }
                    Address--;
                }
            }
        }
        bool sidebarExpand;
        bool FileExpand;
        bool SettingsExpand;
        bool FunctionsExpand;
        bool blockedmenu;
        private void sidemenutimer_Tick(object sender, EventArgs e)
        {
                if (sidebarExpand)
            {
                blockedmenu = true;
                filebutton.Visible = false;
                settingsbutton.Visible = false;
                functionsbutton.Visible = false;
                button5.Visible = false;
                button10.Visible = false;
                sidemenu.Width -=10;
                if (sidemenu.Width == sidemenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidemenutimer.Stop();
                }
            }
            else
            {
                sidemenu.Width +=10;
                if (sidemenu.Width == sidemenu.MaximumSize.Width)
                {
                    blockedmenu = false;
                    sidebarExpand = true;
                    filebutton.Visible = true;
                    settingsbutton.Visible = true;
                    functionsbutton.Visible = true;
                    button5.Visible = true;
                    button10.Visible = true;
                    sidemenutimer.Stop();
                }
            }
        }
        private void menubutton_Click(object sender, EventArgs e)
        {
            sidemenutimer.Start();
        }
        private void filebutton_Click(object sender, EventArgs e)
        {
            filetimer.Start();
        }
        private void filetimer_Tick(object sender, EventArgs e)
        {
           if(FileExpand && !blockedmenu)
            {
                File.Height-=10;
                if(File.Height==File.MinimumSize.Height)
                {
                    FileExpand= false;
                    filetimer.Stop();
                }
            }
           else
              if(!FileExpand && !blockedmenu )
            { 
                File.Height+=10;
                if(File.Height == File.MaximumSize.Height)
                {
                    FileExpand= true;   
                    filetimer.Stop();
                }
            }
        }
        private void settingsbutton_Click(object sender, EventArgs e)
        {
            settingstimer.Start();
        }
        private void settingstimer_Tick(object sender, EventArgs e)
        {
            if (SettingsExpand && !blockedmenu)
            {
                Settings.Height -= 10;
                if (Settings.Height == Settings.MinimumSize.Height)
                {
                    SettingsExpand = false;
                    settingstimer.Stop();
                }
            }
            else
            if(!SettingsExpand && !blockedmenu )
            {
                Settings.Height += 10;
                if (Settings.Height == Settings.MaximumSize.Height)
                {
                    SettingsExpand = true;
                    settingstimer.Stop();
                }
            }
        }
        private void functionsbutton_Click(object sender, EventArgs e)
        {
            functionstimer.Start();
        }
        private void functionstimer_Tick(object sender, EventArgs e)
        {
            if (FunctionsExpand && !blockedmenu)
            {
                Functions.Height -= 10;
                if (Functions.Height == Functions.MinimumSize.Height)
                {
                    FunctionsExpand = false;
                    functionstimer.Stop();
                }
            }
            else
            if(!FunctionsExpand && !blockedmenu )
            {
                Functions.Height += 10;
                if (Functions.Height == Functions.MaximumSize.Height)
                {
                    FunctionsExpand = true;
                    functionstimer.Stop();
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {///RTUbutton
            FrmSettings frmSettings = new FrmSettings();
            var result = frmSettings.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.ComPort = frmSettings.cmbComPort.Text;
                Properties.Settings.Default.Baudrate = int.Parse(frmSettings.cmbBaudrate.Text);
                Properties.Settings.Default.DataBits = int.Parse(frmSettings.cmbDataBits.Text);
                Properties.Settings.Default.ParityBits = frmSettings.cmbParityBits.SelectedIndex;
                Properties.Settings.Default.StopBits = frmSettings.cmbStopBits.SelectedIndex;
                Properties.Settings.Default.Read_type = int.Parse(frmSettings.cmbRead_type.Text);
                Properties.Settings.Default.Refresh = int.Parse(frmSettings.NumRefresh.Value.ToString());
                Properties.Settings.Default.Address = byte.Parse(frmSettings.NumAddress.Value.ToString());
                slaveAddress = Properties.Settings.Default.Address;
                tmr.Interval = Properties.Settings.Default.Refresh;
                Properties.Settings.Default.Save();
                if (timer == 0)
                    UpdateStatus();
            }
            frmSettings.Dispose();
            frmSettings.Close();
        }
        private void button11_Click(object sender, EventArgs e)
        {///TCPbutton
            TCPSettingsMenu tcpmenu = new TCPSettingsMenu();
            var result = tcpmenu.ShowDialog(this);
        }
        private void gateway_Click(object sender, EventArgs e)
        {
             RTUoverTCP form = new RTUoverTCP();
            var result = form.ShowDialog(this);
        }
    }
}
