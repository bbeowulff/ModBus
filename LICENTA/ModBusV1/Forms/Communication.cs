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
    public partial class Communication : Form
    {
        public Communication()
        {
            InitializeComponent();
            timer1.Interval = Properties.Settings.Default.Refresh;
        }
        public void btnStart_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnStartChecked = 1;
            Properties.Settings.Default.Save();
            timer1.Start();

        }
        public void btnStop_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnStartChecked = 0;
            Properties.Settings.Default.Save();
            timer1.Stop();
        }   
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = Properties.Settings.Default.Request;
            label5.Text = Properties.Settings.Default.Response;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Properties.Settings.Default.btnStartChecked = 0;
        }
    }
}
