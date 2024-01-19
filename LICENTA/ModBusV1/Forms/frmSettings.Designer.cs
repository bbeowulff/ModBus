
namespace ModBusV1.Forms
{
    partial class FrmSettings
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            this.grp = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.StartAddress = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbParityBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbRead_type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.General = new System.Windows.Forms.GroupBox();
            this.NumRefresh = new System.Windows.Forms.NumericUpDown();
            this.NumAddress = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.grp.SuspendLayout();
            this.General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(19, 164);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 16);
            label5.TabIndex = 10;
            label5.Text = "Stop Bits:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(13, 129);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 16);
            label4.TabIndex = 8;
            label4.Text = "Parity Bits:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 200);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 16);
            label3.TabIndex = 6;
            label3.Text = "Data Bits:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 62);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 16);
            label2.TabIndex = 4;
            label2.Text = "Baudrate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 16);
            label1.TabIndex = 2;
            label1.Text = "Serial Port:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(204, 64);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(61, 16);
            label7.TabIndex = 7;
            label7.Text = "Seconds";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(8, 64);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(94, 16);
            label8.TabIndex = 5;
            label8.Text = "Refresh every:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(8, 30);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(102, 16);
            label10.TabIndex = 2;
            label10.Text = "Slave  Address:";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.label9);
            this.grp.Controls.Add(this.label6);
            this.grp.Controls.Add(this.Quantity);
            this.grp.Controls.Add(this.StartAddress);
            this.grp.Controls.Add(this.btnRefresh);
            this.grp.Controls.Add(this.cmbStopBits);
            this.grp.Controls.Add(label5);
            this.grp.Controls.Add(this.cmbParityBits);
            this.grp.Controls.Add(label4);
            this.grp.Controls.Add(this.cmbDataBits);
            this.grp.Controls.Add(label3);
            this.grp.Controls.Add(this.cmbBaudrate);
            this.grp.Controls.Add(label2);
            this.grp.Controls.Add(this.cmbRead_type);
            this.grp.Controls.Add(this.label13);
            this.grp.Controls.Add(this.cmbComPort);
            this.grp.Controls.Add(label1);
            this.grp.Location = new System.Drawing.Point(16, 33);
            this.grp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp.Name = "grp";
            this.grp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp.Size = new System.Drawing.Size(384, 234);
            this.grp.TabIndex = 0;
            this.grp.TabStop = false;
            this.grp.Text = "Connections";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Start Address: ";
            // 
            // Quantity
            // 
            this.Quantity.AutoCompleteCustomSource.AddRange(new string[] {
            "5"});
            this.Quantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Quantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Quantity.Location = new System.Drawing.Point(281, 191);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 22);
            this.Quantity.TabIndex = 13;
            this.Quantity.Text = "5";
            // 
            // StartAddress
            // 
            this.StartAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "1001"});
            this.StartAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.StartAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.StartAddress.Location = new System.Drawing.Point(281, 161);
            this.StartAddress.Name = "StartAddress";
            this.StartAddress.Size = new System.Drawing.Size(100, 22);
            this.StartAddress.TabIndex = 12;
            this.StartAddress.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(304, 22);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 27);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBits.Location = new System.Drawing.Point(90, 163);
            this.cmbStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(68, 24);
            this.cmbStopBits.TabIndex = 11;
            // 
            // cmbParityBits
            // 
            this.cmbParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParityBits.FormattingEnabled = true;
            this.cmbParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cmbParityBits.Location = new System.Drawing.Point(90, 129);
            this.cmbParityBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbParityBits.Name = "cmbParityBits";
            this.cmbParityBits.Size = new System.Drawing.Size(96, 24);
            this.cmbParityBits.TabIndex = 9;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(90, 200);
            this.cmbDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(68, 24);
            this.cmbDataBits.TabIndex = 7;
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cmbBaudrate.Location = new System.Drawing.Point(92, 59);
            this.cmbBaudrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(172, 24);
            this.cmbBaudrate.TabIndex = 5;
            // 
            // cmbRead_type
            // 
            this.cmbRead_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRead_type.FormattingEnabled = true;
            this.cmbRead_type.Items.AddRange(new object[] {
            "3",
            "4"});
            this.cmbRead_type.Location = new System.Drawing.Point(92, 93);
            this.cmbRead_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRead_type.Name = "cmbRead_type";
            this.cmbRead_type.Size = new System.Drawing.Size(172, 24);
            this.cmbRead_type.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 93);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Read_type:";
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(92, 25);
            this.cmbComPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(204, 24);
            this.cmbComPort.TabIndex = 3;
            // 
            // General
            // 
            this.General.Controls.Add(label7);
            this.General.Controls.Add(this.NumRefresh);
            this.General.Controls.Add(label8);
            this.General.Controls.Add(this.NumAddress);
            this.General.Controls.Add(label10);
            this.General.Location = new System.Drawing.Point(16, 267);
            this.General.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.General.Size = new System.Drawing.Size(384, 98);
            this.General.TabIndex = 12;
            this.General.TabStop = false;
            this.General.Text = "General";
            // 
            // NumRefresh
            // 
            this.NumRefresh.Location = new System.Drawing.Point(132, 59);
            this.NumRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumRefresh.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumRefresh.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumRefresh.Name = "NumRefresh";
            this.NumRefresh.Size = new System.Drawing.Size(64, 22);
            this.NumRefresh.TabIndex = 6;
            this.NumRefresh.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // NumAddress
            // 
            this.NumAddress.Location = new System.Drawing.Point(132, 27);
            this.NumAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumAddress.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.NumAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumAddress.Name = "NumAddress";
            this.NumAddress.Size = new System.Drawing.Size(64, 22);
            this.NumAddress.TabIndex = 3;
            this.NumAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Location = new System.Drawing.Point(37, 369);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(283, 369);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.ControlBox = false;
            this.Controls.Add(this.General);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ComboBox cmbComPort;
        public System.Windows.Forms.ComboBox cmbStopBits;
        public System.Windows.Forms.ComboBox cmbParityBits;
        public System.Windows.Forms.ComboBox cmbDataBits;
        public System.Windows.Forms.ComboBox cmbBaudrate;
        public System.Windows.Forms.ComboBox cmbRead_type;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.NumericUpDown NumAddress;
        public System.Windows.Forms.NumericUpDown NumRefresh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.GroupBox General;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox StartAddress;
    }
}