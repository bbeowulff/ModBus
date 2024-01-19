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
using System.Web;
using System.Web.UI.WebControls;

namespace ModBusV1.Forms
{
    public partial class RTUoverTCP : Form
    {
        static ushort[] registers;
        static void Function()
        {
            // IP address and port of the Modbus TCP device
            try
            {
                // Create a TCP client
                using (TcpClient tcpClient = new TcpClient(Properties.Settings.Default.ipAddress, Properties.Settings.Default.Port))
                {
                    if (!tcpClient.Connected)
                    {
                        try
                        {
                            tcpClient.BeginConnect(Properties.Settings.Default.ipAddress, Properties.Settings.Default.Port, null, null);
                            using (NetworkStream stream = tcpClient.GetStream())
                            {
                                // Create the Modbus RTU request
                                byte[] rtuRequest = CreateModbusRtuRequest(Properties.Settings.Default.slaveID, Properties.Settings.Default.startAddress, Properties.Settings.Default.quantity);
                                // Build the Modbus TCP request with the RTU request inside
                                //byte[] tcpRequest = BuildModbusTcpRequest(rtuRequest);
                                // Send the Modbus TCP request
                                stream.Write(rtuRequest, 0, rtuRequest.Length);
                                Console.WriteLine("RTU through TCP Request:");
                                foreach (byte b in rtuRequest)
                                {
                                    Console.Write($"{b:X2} ");
                                }
                                Console.WriteLine();
                                // Receive and handle the Modbus TCP response
                                byte[] tcpResponse = new byte[1024];
                                int bytesRead = stream.Read(tcpResponse, 0, tcpResponse.Length);
                                int auxbytesRead = bytesRead;
                                Console.WriteLine("RTU through TCP Response:");
                                /*
                                foreach (byte b in tcpResponse)
                                {
                                    if (bytesRead != 0)
                                        Console.Write($"{b:X2} ");
                                    if (bytesRead == 0) break;
                                    bytesRead--;
                                }
                                Console.WriteLine();
                                */
                                //// Showing the registers
                                int labelindex = 0;
                                for (int index = 0; index < tcpResponse.Length - 1; index += 2)
                                {
                                    byte byte1 = tcpResponse[index];
                                    byte byte2 = tcpResponse[index + 1];
                                    uint combined = ((uint)byte1 << 8) | byte2;
                                    Console.WriteLine("Registrul " + (++labelindex) + ": " + combined);
                                    Console.WriteLine();
                                    registers[index] = (ushort)combined;
                                    auxbytesRead -= 2;
                                    if (auxbytesRead <= 0)
                                        break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            string req1 = Properties.Settings.Default.Read_type.ToString();
            byte[] request = new byte[8];
            request[0] = slaveId;
            request[1] = byte.Parse(req1);
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
        public RTUoverTCP()
        {
            InitializeComponent();
            for(int i = 0;i<registers.Length; i++)
            {
                listBox.Items.Add("Register " + i + " :" + registers[i]);
            }
        }
        private void Function(object sender, EventArgs e)
        {
            Function();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ipAddress = IP.Text;
            Properties.Settings.Default.Port = ushort.Parse(Port.Text);
            Properties.Settings.Default.slaveID = byte.Parse(SlaveID.Text);
            Properties.Settings.Default.startAddress = ushort.Parse(StartAddress.Text);
            Properties.Settings.Default.quantity = ushort.Parse(Quantity.Text);
            Properties.Settings.Default.Read_type = int.Parse(ReadType.Text);
            Properties.Settings.Default.Save();
        }
    }
}
