using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ModBusV1.Forms
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cmbComPort.DataSource = SerialPort.GetPortNames();
            

            for (int i = 0; i < cmbComPort.Items.Count -1; i++)
            {
                if (cmbComPort.Items[i].ToString() == Properties.Settings.Default.ComPort)
                    cmbComPort.SelectedIndex = i;
            }

            cmbBaudrate.DataSource = FrmMain.BaudRate;
            cmbBaudrate.Text = Properties.Settings.Default.Baudrate.ToString();
            cmbRead_type.DataSource = FrmMain.Read_type;
            cmbRead_type.Text = Properties.Settings.Default.Read_type.ToString();

            cmbDataBits.DataSource = FrmMain.DataBits;
            cmbDataBits.Text = Properties.Settings.Default.DataBits.ToString();

            cmbParityBits.DataSource = Enum.GetNames(typeof(Parity));
            cmbParityBits.SelectedIndex = Properties.Settings.Default.ParityBits;

            cmbStopBits.DataSource = Enum.GetNames(typeof(StopBits));
            cmbStopBits.SelectedIndex = Properties.Settings.Default.StopBits;

            NumAddress.Value = Properties.Settings.Default.Address;
            NumRefresh.Value = Properties.Settings.Default.Refresh;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            int startaddress;
            int quantity;
            if (int.TryParse(StartAddress.Text, out startaddress) && int.TryParse(Quantity.Text, out quantity))
            {
                Properties.Settings.Default.startAddress = ushort.Parse(StartAddress.Text);
                Properties.Settings.Default.quantity = ushort.Parse(Quantity.Text);
                Properties.Settings.Default.Read_type = int.Parse(cmbRead_type.Text);   
                Properties.Settings.Default.Save();
                int n = Properties.Settings.Default.Read_type;
                Console.WriteLine(cmbRead_type.Text);
                Console.WriteLine(n);
                Console.WriteLine(Properties.Settings.Default.Read_type);
                this.DialogResult = DialogResult.OK;
                Close();
            }else
            {
                MessageBox.Show(this, "Incorrect Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbComPort.DataSource = SerialPort.GetPortNames();
        }
    }
}
