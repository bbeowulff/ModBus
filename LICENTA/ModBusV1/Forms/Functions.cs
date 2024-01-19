using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusV1.Forms
{
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }
        private void writeregister_Click(object sender, EventArgs e)
        {
            ushort address, value;
            if (ushort.TryParse(writeaddress.Text, out address) && ushort.TryParse(writevalue.Text, out value))
            {
                Properties.Settings.Default.writeaddress = ushort.Parse(writeaddress.Text);
                Properties.Settings.Default.writevalue = ushort.Parse(writevalue.Text);
                Properties.Settings.Default.writeEnable = 1;
                Properties.Settings.Default.writeRegistersEnable = 0;
                Properties.Settings.Default.Save();
            }else
            {
                MessageBox.Show(this, "Incorrect Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void regnum_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(regnumber.Text, out number))
            {
                if (int.Parse(regnumber.Text) > 0 && int.Parse(regnumber.Text) < 11)
                {
                    int nr = int.Parse(regnumber.Text);
                    for (int i = 1; i <= nr; i++)
                    {
                        string labelName = "value" + i;
                        Control[] controls = this.Controls.Find(labelName, true);
                        if (controls.Length > 0 && controls[0] is System.Windows.Forms.TextBox targetLabel)
                        {
                            targetLabel.Visible = true;
                        }
                    }
                    int nr2 = int.Parse(regnumber.Text);
                    for (int i = 3; i <= nr2 + 2; i++)
                    {
                        string labelName = "label" + i;
                        Control[] controls = this.Controls.Find(labelName, true);
                        if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                        {
                            targetLabel.Visible = true;
                        }
                    }
                    for (int i = nr + 1; i <= 10; i++)
                    {
                        string labelName = "value" + i;
                        Control[] controls = this.Controls.Find(labelName, true);
                        if (controls.Length > 0 && controls[0] is System.Windows.Forms.TextBox targetLabel)
                        {
                            targetLabel.Visible = false;
                        }
                    }
                    for (int i = nr + 3; i <= 12; i++)
                    {
                        string labelName = "label" + i;
                        Control[] controls = this.Controls.Find(labelName, true);
                        if (controls.Length > 0 && controls[0] is System.Windows.Forms.Label targetLabel)
                        {
                            targetLabel.Visible = false;
                        }
                    }
                    Properties.Settings.Default.writequantity = ushort.Parse(regnumber.Text);
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show(this, "Re-Enter the Registers Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Incorrect Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void writeregisters_Click(object sender, EventArgs e)
        {
            if (writestartAddress.Text != " " && regnumber.Text != " ")
            {
                int startaddress, value;
                int OK = 1;
                int nr = int.Parse(regnumber.Text);
                for (int i = 1; i <= nr; i++)
                {
                    string labelName = "value" + i;
                    Control[] controls = this.Controls.Find(labelName, true);
                    if (controls.Length > 0 && controls[0] is System.Windows.Forms.TextBox targetLabel)
                    {
                        if (!int.TryParse(targetLabel.Text, out value)) { OK = 0; }
                    }
                }
                if (int.TryParse(writestartAddress.Text, out startaddress) && OK == 1)
                {
                    Properties.Settings.Default.writeEnable = 0;
                    Properties.Settings.Default.writeRegistersEnable = 1;
                    Properties.Settings.Default.writeaddress = ushort.Parse(writestartAddress.Text);
                    for (int i = 1; i <= nr; i++)
                    {
                        string labelName = "value" + i;
                        Control[] controls = this.Controls.Find(labelName, true);
                        if (controls.Length > 0 && controls[0] is System.Windows.Forms.TextBox targetLabel)
                        {
                            Properties.Settings.Default[labelName] = ushort.Parse(targetLabel.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Incorrect Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(this, "Please enter the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
