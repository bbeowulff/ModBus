namespace ModBusV1.Forms
{
    partial class RTUoverTCP
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.StartAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReadType = new System.Windows.Forms.TextBox();
            this.SlaveID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            label12 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(265, 87);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(34, 16);
            label12.TabIndex = 14;
            label12.Text = "Port:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(244, 61);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(76, 16);
            label15.TabIndex = 13;
            label15.Text = "IP Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send a custom RTU Request through TCP communication";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Function);
            // 
            // Port
            // 
            this.Port.AutoCompleteCustomSource.AddRange(new string[] {
            "502"});
            this.Port.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Port.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Port.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Port.Location = new System.Drawing.Point(345, 87);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 22);
            this.Port.TabIndex = 15;
            this.Port.Text = "502";
            // 
            // IP
            // 
            this.IP.AutoCompleteCustomSource.AddRange(new string[] {
            "192.168.0.6"});
            this.IP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.IP.Location = new System.Drawing.Point(345, 58);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(100, 22);
            this.IP.TabIndex = 16;
            this.IP.Text = "192.168.0.7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Start Address: ";
            // 
            // Quantity
            // 
            this.Quantity.AutoCompleteCustomSource.AddRange(new string[] {
            "5"});
            this.Quantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Quantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Quantity.Location = new System.Drawing.Point(345, 224);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 22);
            this.Quantity.TabIndex = 18;
            this.Quantity.Text = "5";
            // 
            // StartAddress
            // 
            this.StartAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "1001"});
            this.StartAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.StartAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.StartAddress.Location = new System.Drawing.Point(345, 187);
            this.StartAddress.Name = "StartAddress";
            this.StartAddress.Size = new System.Drawing.Size(100, 22);
            this.StartAddress.TabIndex = 17;
            this.StartAddress.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Read Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Slave ID:";
            // 
            // ReadType
            // 
            this.ReadType.AutoCompleteCustomSource.AddRange(new string[] {
            "5"});
            this.ReadType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ReadType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ReadType.Location = new System.Drawing.Point(345, 149);
            this.ReadType.Name = "ReadType";
            this.ReadType.Size = new System.Drawing.Size(100, 22);
            this.ReadType.TabIndex = 22;
            this.ReadType.Text = "3";
            // 
            // SlaveID
            // 
            this.SlaveID.AutoCompleteCustomSource.AddRange(new string[] {
            "1001"});
            this.SlaveID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SlaveID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SlaveID.Location = new System.Drawing.Point(345, 116);
            this.SlaveID.Name = "SlaveID";
            this.SlaveID.Size = new System.Drawing.Size(100, 22);
            this.SlaveID.TabIndex = 21;
            this.SlaveID.Text = "1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 81);
            this.button2.TabIndex = 25;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(466, 51);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(197, 196);
            this.listBox.TabIndex = 26;
            // 
            // RTUoverTCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 271);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReadType);
            this.Controls.Add(this.SlaveID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.StartAddress);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Controls.Add(label12);
            this.Controls.Add(label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "RTUoverTCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTUoverTCP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox StartAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReadType;
        private System.Windows.Forms.TextBox SlaveID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox;
    }
}