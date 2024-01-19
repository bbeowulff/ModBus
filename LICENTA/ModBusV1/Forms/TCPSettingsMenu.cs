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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModBusV1.Forms
{
    public partial class TCPSettingsMenu : Form
    {
        public TCPSettingsMenu()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnOk_Click_1(object sender, EventArgs e)
        {
            ushort Port, StartAddress, Quantity,type;

            if ( ushort.TryParse(textBoxPort.Text, out Port) && ushort.TryParse(StartAddressTCP.Text, out StartAddress) && ushort.TryParse(QuantityTCP.Text, out Quantity)&& ushort.TryParse(TCPRead_type.Text, out type))
            {
                Properties.Settings.Default.Read_type =int.Parse(TCPRead_type.Text);
                Properties.Settings.Default.ipAddress = textBoxIP.Text;
                Properties.Settings.Default.Port = ushort.Parse(textBoxPort.Text);
                Properties.Settings.Default.startAddressTCP = ushort.Parse(StartAddressTCP.Text);
                Properties.Settings.Default.quantityTCP = ushort.Parse(QuantityTCP.Text);
                Properties.Settings.Default.Save();
                int n;
                for (n = 30; n <= Properties.Settings.Default.quantityTCP + 30; n++)
                {
                    string labelName = "label" + n;
                    Control[] controls = this.Controls.Find(labelName, true);
                    if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                    {
                        targetLabel.Visible = true;
                    }
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }else
            {
                MessageBox.Show(this, "Incorrect Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
