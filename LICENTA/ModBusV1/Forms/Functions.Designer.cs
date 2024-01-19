namespace ModBusV1.Forms
{
    partial class Functions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.writeregister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.writeaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.writevalue = new System.Windows.Forms.TextBox();
            this.writeregisters = new System.Windows.Forms.Button();
            this.writestartAddress = new System.Windows.Forms.TextBox();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.value3 = new System.Windows.Forms.TextBox();
            this.value4 = new System.Windows.Forms.TextBox();
            this.value5 = new System.Windows.Forms.TextBox();
            this.value6 = new System.Windows.Forms.TextBox();
            this.value7 = new System.Windows.Forms.TextBox();
            this.value8 = new System.Windows.Forms.TextBox();
            this.value9 = new System.Windows.Forms.TextBox();
            this.value10 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.regnumber = new System.Windows.Forms.MaskedTextBox();
            this.regnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeregister
            // 
            this.writeregister.Location = new System.Drawing.Point(57, 17);
            this.writeregister.Name = "writeregister";
            this.writeregister.Size = new System.Drawing.Size(131, 26);
            this.writeregister.TabIndex = 63;
            this.writeregister.Text = "WriteRegister";
            this.writeregister.UseVisualStyleBackColor = true;
            this.writeregister.Click += new System.EventHandler(this.writeregister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Address:";
            // 
            // writeaddress
            // 
            this.writeaddress.Location = new System.Drawing.Point(293, 14);
            this.writeaddress.Name = "writeaddress";
            this.writeaddress.Size = new System.Drawing.Size(100, 22);
            this.writeaddress.TabIndex = 65;
            this.writeaddress.Text = "1003";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Value:";
            // 
            // writevalue
            // 
            this.writevalue.Location = new System.Drawing.Point(293, 42);
            this.writevalue.Name = "writevalue";
            this.writevalue.Size = new System.Drawing.Size(100, 22);
            this.writevalue.TabIndex = 67;
            this.writevalue.Text = "23";
            // 
            // writeregisters
            // 
            this.writeregisters.Location = new System.Drawing.Point(12, 80);
            this.writeregisters.Name = "writeregisters";
            this.writeregisters.Size = new System.Drawing.Size(131, 28);
            this.writeregisters.TabIndex = 68;
            this.writeregisters.Text = "WriteRegisters";
            this.writeregisters.UseVisualStyleBackColor = true;
            this.writeregisters.Click += new System.EventHandler(this.writeregisters_Click);
            // 
            // writestartAddress
            // 
            this.writestartAddress.Location = new System.Drawing.Point(311, 67);
            this.writestartAddress.Name = "writestartAddress";
            this.writestartAddress.Size = new System.Drawing.Size(153, 22);
            this.writestartAddress.TabIndex = 69;
            this.writestartAddress.Text = " ";
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(135, 120);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(100, 22);
            this.value1.TabIndex = 70;
            this.value1.Text = "0";
            this.value1.Visible = false;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(135, 148);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(100, 22);
            this.value2.TabIndex = 71;
            this.value2.Text = "0";
            this.value2.Visible = false;
            // 
            // value3
            // 
            this.value3.Location = new System.Drawing.Point(135, 176);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(100, 22);
            this.value3.TabIndex = 72;
            this.value3.Text = "0";
            this.value3.Visible = false;
            // 
            // value4
            // 
            this.value4.Location = new System.Drawing.Point(135, 204);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(100, 22);
            this.value4.TabIndex = 73;
            this.value4.Text = "0";
            this.value4.Visible = false;
            // 
            // value5
            // 
            this.value5.Location = new System.Drawing.Point(135, 232);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(100, 22);
            this.value5.TabIndex = 74;
            this.value5.Text = "0";
            this.value5.Visible = false;
            // 
            // value6
            // 
            this.value6.Location = new System.Drawing.Point(364, 117);
            this.value6.Name = "value6";
            this.value6.Size = new System.Drawing.Size(100, 22);
            this.value6.TabIndex = 75;
            this.value6.Text = "0";
            this.value6.Visible = false;
            // 
            // value7
            // 
            this.value7.Location = new System.Drawing.Point(364, 145);
            this.value7.Name = "value7";
            this.value7.Size = new System.Drawing.Size(100, 22);
            this.value7.TabIndex = 76;
            this.value7.Text = "0";
            this.value7.Visible = false;
            // 
            // value8
            // 
            this.value8.Location = new System.Drawing.Point(364, 173);
            this.value8.Name = "value8";
            this.value8.Size = new System.Drawing.Size(100, 22);
            this.value8.TabIndex = 77;
            this.value8.Text = "0";
            this.value8.Visible = false;
            // 
            // value9
            // 
            this.value9.Location = new System.Drawing.Point(364, 201);
            this.value9.Name = "value9";
            this.value9.Size = new System.Drawing.Size(100, 22);
            this.value9.TabIndex = 78;
            this.value9.Text = "0";
            this.value9.Visible = false;
            // 
            // value10
            // 
            this.value10.Location = new System.Drawing.Point(364, 229);
            this.value10.Name = "value10";
            this.value10.Size = new System.Drawing.Size(100, 22);
            this.value10.TabIndex = 79;
            this.value10.Text = "0";
            this.value10.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "value 1:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "value 2:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "value 3:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "value 4:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 84;
            this.label7.Text = "value 5:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 85;
            this.label8.Text = "value 6:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 86;
            this.label9.Text = "value 7:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 87;
            this.label10.Text = "value 8:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 88;
            this.label11.Text = "value 9:";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 89;
            this.label12.Text = "value 10:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 16);
            this.label13.TabIndex = 90;
            this.label13.Text = "Start Address:";
            // 
            // regnumber
            // 
            this.regnumber.Location = new System.Drawing.Point(364, 92);
            this.regnumber.Name = "regnumber";
            this.regnumber.Size = new System.Drawing.Size(100, 22);
            this.regnumber.TabIndex = 91;
            this.regnumber.Text = " ";
            // 
            // regnum
            // 
            this.regnum.Location = new System.Drawing.Point(259, 92);
            this.regnum.Name = "regnum";
            this.regnum.Size = new System.Drawing.Size(99, 23);
            this.regnum.TabIndex = 92;
            this.regnum.Text = "RegNum";
            this.regnum.UseVisualStyleBackColor = true;
            this.regnum.Click += new System.EventHandler(this.regnum_Click);
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 289);
            this.Controls.Add(this.regnum);
            this.Controls.Add(this.regnumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.value10);
            this.Controls.Add(this.value9);
            this.Controls.Add(this.value8);
            this.Controls.Add(this.value7);
            this.Controls.Add(this.value6);
            this.Controls.Add(this.value5);
            this.Controls.Add(this.value4);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.writestartAddress);
            this.Controls.Add(this.writeregisters);
            this.Controls.Add(this.writevalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.writeaddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeregister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Functions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeregister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox writeaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox writevalue;
        private System.Windows.Forms.Button writeregisters;
        private System.Windows.Forms.TextBox writestartAddress;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.TextBox value3;
        private System.Windows.Forms.TextBox value4;
        private System.Windows.Forms.TextBox value5;
        private System.Windows.Forms.TextBox value6;
        private System.Windows.Forms.TextBox value7;
        private System.Windows.Forms.TextBox value8;
        private System.Windows.Forms.TextBox value9;
        private System.Windows.Forms.TextBox value10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox regnumber;
        private System.Windows.Forms.Button regnum;
    }
}