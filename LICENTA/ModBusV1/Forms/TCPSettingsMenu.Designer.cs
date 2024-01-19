namespace ModBusV1.Forms
{
    partial class TCPSettingsMenu
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
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label15;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityTCP = new System.Windows.Forms.TextBox();
            this.StartAddressTCP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.TCPRead_type = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(168, 57);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(34, 16);
            label12.TabIndex = 4;
            label12.Text = "Port:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(126, 27);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(76, 16);
            label15.TabIndex = 2;
            label15.Text = "IP Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TCPRead_type);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.QuantityTCP);
            this.groupBox1.Controls.Add(this.StartAddressTCP);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(label12);
            this.groupBox1.Controls.Add(label15);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(612, 185);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Start Address: ";
            // 
            // QuantityTCP
            // 
            this.QuantityTCP.AutoCompleteCustomSource.AddRange(new string[] {
            "1001"});
            this.QuantityTCP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.QuantityTCP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.QuantityTCP.Location = new System.Drawing.Point(209, 113);
            this.QuantityTCP.Name = "QuantityTCP";
            this.QuantityTCP.Size = new System.Drawing.Size(100, 22);
            this.QuantityTCP.TabIndex = 17;
            this.QuantityTCP.Text = "5";
            // 
            // StartAddressTCP
            // 
            this.StartAddressTCP.AutoCompleteCustomSource.AddRange(new string[] {
            "1001"});
            this.StartAddressTCP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.StartAddressTCP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.StartAddressTCP.Location = new System.Drawing.Point(209, 82);
            this.StartAddressTCP.Name = "StartAddressTCP";
            this.StartAddressTCP.Size = new System.Drawing.Size(100, 22);
            this.StartAddressTCP.TabIndex = 16;
            this.StartAddressTCP.Text = "1001";
            // 
            // textBoxPort
            // 
            this.textBoxPort.AutoCompleteCustomSource.AddRange(new string[] {
            "502"});
            this.textBoxPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxPort.Location = new System.Drawing.Point(209, 54);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 22);
            this.textBoxPort.TabIndex = 12;
            this.textBoxPort.Text = "502";
            // 
            // textBoxIP
            // 
            this.textBoxIP.AutoCompleteCustomSource.AddRange(new string[] {
            "192.168.0.6"});
            this.textBoxIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxIP.Location = new System.Drawing.Point(209, 24);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(247, 22);
            this.textBoxIP.TabIndex = 12;
            this.textBoxIP.Text = "192.168.0.6";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Location = new System.Drawing.Point(66, 207);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 27);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(454, 207);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TCPRead_type
            // 
            this.TCPRead_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TCPRead_type.FormattingEnabled = true;
            this.TCPRead_type.Items.AddRange(new object[] {
            "3",
            "4"});
            this.TCPRead_type.Location = new System.Drawing.Point(209, 143);
            this.TCPRead_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TCPRead_type.Name = "TCPRead_type";
            this.TCPRead_type.Size = new System.Drawing.Size(172, 24);
            this.TCPRead_type.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 143);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Read_type:";
            // 
            // TCPSettingsMenu
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(638, 248);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TCPSettingsMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCPSettingsMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox QuantityTCP;
        private System.Windows.Forms.TextBox StartAddressTCP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox TCPRead_type;
        private System.Windows.Forms.Label label14;
    }
}