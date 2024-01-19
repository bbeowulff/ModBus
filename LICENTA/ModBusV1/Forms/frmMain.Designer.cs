
namespace ModBusV1
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem mnuFile;
            System.Windows.Forms.ToolStripSeparator mnuFile_1;
            System.Windows.Forms.ToolStripSeparator mnuFile_2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.LblAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.newaddress = new System.Windows.Forms.TextBox();
            this.sendaddress = new System.Windows.Forms.Button();
            this.nregisters = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.settingsbutton = new System.Windows.Forms.Button();
            this.Comms = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.Functions = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.functionsbutton = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.filebutton = new System.Windows.Forms.Button();
            this.disconnectTCP = new System.Windows.Forms.Button();
            this.connectRTU = new System.Windows.Forms.Button();
            this.disconnectRTU = new System.Windows.Forms.Button();
            this.connectTCP = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.menubutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidemenutimer = new System.Windows.Forms.Timer(this.components);
            this.filetimer = new System.Windows.Forms.Timer(this.components);
            this.sidemenu = new System.Windows.Forms.FlowLayoutPanel();
            this.settingstimer = new System.Windows.Forms.Timer(this.components);
            this.functionstimer = new System.Windows.Forms.Timer(this.components);
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuFile_1 = new System.Windows.Forms.ToolStripSeparator();
            mnuFile_2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.stsMain.SuspendLayout();
            this.Settings.SuspendLayout();
            this.Comms.SuspendLayout();
            this.Functions.SuspendLayout();
            this.File.SuspendLayout();
            this.Exit.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
            this.sidemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuFile_1
            // 
            mnuFile_1.Name = "mnuFile_1";
            mnuFile_1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFile_2
            // 
            mnuFile_2.Name = "mnuFile_2";
            mnuFile_2.Size = new System.Drawing.Size(221, 6);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // numAddress
            // 
            this.numAddress.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddress.Location = new System.Drawing.Point(482, 333);
            this.numAddress.Margin = new System.Windows.Forms.Padding(4);
            this.numAddress.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAddress.Name = "numAddress";
            this.numAddress.Size = new System.Drawing.Size(147, 63);
            this.numAddress.TabIndex = 5;
            this.numAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAddress.Visible = false;
            this.numAddress.ValueChanged += new System.EventHandler(this.numAddress_ValueChanged);
            // 
            // LblAddress
            // 
            this.LblAddress.Font = new System.Drawing.Font("Tahoma", 17.25F);
            this.LblAddress.Location = new System.Drawing.Point(489, 290);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(160, 42);
            this.LblAddress.TabIndex = 11;
            this.LblAddress.Text = "Address";
            this.LblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAddress.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(350, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "0.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(363, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "ReadInputRegister One-by-One";
            this.label4.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 1;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Signed",
            "Unsigned",
            "Hex",
            "Binary",
            "Long",
            "Long Inverse",
            "Float",
            "Float Inverse",
            "Double",
            "Double Inverse"});
            this.checkedListBox1.Location = new System.Drawing.Point(482, 399);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(167, 106);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // stsMain
            // 
            this.stsMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.stsMain.Location = new System.Drawing.Point(0, 508);
            this.stsMain.Name = "stsMain";
            this.stsMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stsMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stsMain.Size = new System.Drawing.Size(1398, 26);
            this.stsMain.TabIndex = 24;
            this.stsMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(4, 20);
            this.toolStripStatusLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel7.Visible = false;
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel8.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(4, 20);
            this.toolStripStatusLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel8.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(4, 20);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 20);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel2.Visible = false;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(4, 20);
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel3.Visible = false;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(4, 20);
            this.toolStripStatusLabel4.Visible = false;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(4, 20);
            this.toolStripStatusLabel5.Visible = false;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(99, 20);
            this.toolStripStatusLabel6.Text = "Disconnected";
            this.toolStripStatusLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.White;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(669, 66);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(233, 33);
            this.label30.TabIndex = 25;
            this.label30.Text = "0.0";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label30.Visible = false;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.White;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(669, 198);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(232, 35);
            this.label33.TabIndex = 26;
            this.label33.Text = "0.0";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label33.Visible = false;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.White;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(669, 153);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(232, 34);
            this.label32.TabIndex = 27;
            this.label32.Text = "0.0";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label32.Visible = false;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.White;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(669, 108);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(232, 34);
            this.label31.TabIndex = 28;
            this.label31.Text = "0.0";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label31.Visible = false;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.White;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(668, 244);
            this.label34.Margin = new System.Windows.Forms.Padding(0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(233, 35);
            this.label34.TabIndex = 29;
            this.label34.Text = "0.0";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label34.Visible = false;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.White;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(668, 289);
            this.label35.Margin = new System.Windows.Forms.Padding(0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(232, 35);
            this.label35.TabIndex = 30;
            this.label35.Text = "0.0";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label35.Visible = false;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.White;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(667, 333);
            this.label36.Margin = new System.Windows.Forms.Padding(0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(233, 35);
            this.label36.TabIndex = 31;
            this.label36.Text = "0.0";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label36.Visible = false;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.White;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(668, 377);
            this.label37.Margin = new System.Windows.Forms.Padding(0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(233, 35);
            this.label37.TabIndex = 32;
            this.label37.Text = "0.0";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label37.Visible = false;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.White;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(911, 66);
            this.label40.Margin = new System.Windows.Forms.Padding(0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(233, 35);
            this.label40.TabIndex = 33;
            this.label40.Text = "0.0";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label40.Visible = false;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.White;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(667, 463);
            this.label39.Margin = new System.Windows.Forms.Padding(0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(233, 35);
            this.label39.TabIndex = 34;
            this.label39.Text = "0.0";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label39.Visible = false;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.White;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(668, 419);
            this.label38.Margin = new System.Windows.Forms.Padding(0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(233, 35);
            this.label38.TabIndex = 35;
            this.label38.Text = "0.0";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label38.Visible = false;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.White;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(911, 152);
            this.label42.Margin = new System.Windows.Forms.Padding(0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(233, 35);
            this.label42.TabIndex = 36;
            this.label42.Text = "0.0";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label42.Visible = false;
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.White;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(1156, 108);
            this.label51.Margin = new System.Windows.Forms.Padding(0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(233, 35);
            this.label51.TabIndex = 37;
            this.label51.Text = "0.0";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label51.Visible = false;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.White;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(911, 108);
            this.label41.Margin = new System.Windows.Forms.Padding(0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(233, 35);
            this.label41.TabIndex = 38;
            this.label41.Text = "0.0";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label41.Visible = false;
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.White;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Location = new System.Drawing.Point(1156, 66);
            this.label50.Margin = new System.Windows.Forms.Padding(0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(233, 35);
            this.label50.TabIndex = 39;
            this.label50.Text = "0.0";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label50.Visible = false;
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.White;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label54.ForeColor = System.Drawing.Color.Black;
            this.label54.Location = new System.Drawing.Point(1156, 244);
            this.label54.Margin = new System.Windows.Forms.Padding(0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(233, 35);
            this.label54.TabIndex = 40;
            this.label54.Text = "0.0";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label54.Visible = false;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.White;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(911, 244);
            this.label44.Margin = new System.Windows.Forms.Padding(0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(233, 35);
            this.label44.TabIndex = 41;
            this.label44.Text = "0.0";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label44.Visible = false;
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.White;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Location = new System.Drawing.Point(1156, 198);
            this.label53.Margin = new System.Windows.Forms.Padding(0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(233, 35);
            this.label53.TabIndex = 42;
            this.label53.Text = "0.0";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label53.Visible = false;
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.White;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(911, 198);
            this.label43.Margin = new System.Windows.Forms.Padding(0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(233, 35);
            this.label43.TabIndex = 43;
            this.label43.Text = "0.0";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label43.Visible = false;
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.White;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(1156, 152);
            this.label52.Margin = new System.Windows.Forms.Padding(0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(233, 35);
            this.label52.TabIndex = 44;
            this.label52.Text = "0.0";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label52.Visible = false;
            // 
            // label59
            // 
            this.label59.BackColor = System.Drawing.Color.White;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label59.ForeColor = System.Drawing.Color.Black;
            this.label59.Location = new System.Drawing.Point(1156, 463);
            this.label59.Margin = new System.Windows.Forms.Padding(0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(233, 35);
            this.label59.TabIndex = 45;
            this.label59.Text = "0.0";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label59.Visible = false;
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.White;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(911, 463);
            this.label49.Margin = new System.Windows.Forms.Padding(0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(233, 35);
            this.label49.TabIndex = 46;
            this.label49.Text = "0.0";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label49.Visible = false;
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.Color.White;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label58.ForeColor = System.Drawing.Color.Black;
            this.label58.Location = new System.Drawing.Point(1156, 419);
            this.label58.Margin = new System.Windows.Forms.Padding(0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(233, 35);
            this.label58.TabIndex = 47;
            this.label58.Text = "0.0";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label58.Visible = false;
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.White;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(911, 419);
            this.label48.Margin = new System.Windows.Forms.Padding(0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(233, 35);
            this.label48.TabIndex = 48;
            this.label48.Text = "0.0";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label48.Visible = false;
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.Color.White;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label57.ForeColor = System.Drawing.Color.Black;
            this.label57.Location = new System.Drawing.Point(1156, 377);
            this.label57.Margin = new System.Windows.Forms.Padding(0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(233, 35);
            this.label57.TabIndex = 49;
            this.label57.Text = "0.0";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label57.Visible = false;
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.White;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Location = new System.Drawing.Point(911, 377);
            this.label47.Margin = new System.Windows.Forms.Padding(0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(233, 35);
            this.label47.TabIndex = 50;
            this.label47.Text = "0.0";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label47.Visible = false;
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.White;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Location = new System.Drawing.Point(1156, 333);
            this.label56.Margin = new System.Windows.Forms.Padding(0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(233, 35);
            this.label56.TabIndex = 51;
            this.label56.Text = "0.0";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label56.Visible = false;
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.White;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(911, 333);
            this.label46.Margin = new System.Windows.Forms.Padding(0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(233, 35);
            this.label46.TabIndex = 52;
            this.label46.Text = "0.0";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label46.Visible = false;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.Color.White;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(1156, 289);
            this.label55.Margin = new System.Windows.Forms.Padding(0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(233, 35);
            this.label55.TabIndex = 53;
            this.label55.Text = "0.0";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label55.Visible = false;
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.White;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(911, 289);
            this.label45.Margin = new System.Windows.Forms.Padding(0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(233, 35);
            this.label45.TabIndex = 54;
            this.label45.Text = "0.0";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label45.Visible = false;
            // 
            // newaddress
            // 
            this.newaddress.AutoCompleteCustomSource.AddRange(new string[] {
            "1001",
            "1002",
            "1003",
            "1004"});
            this.newaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.newaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.newaddress.Location = new System.Drawing.Point(792, 34);
            this.newaddress.Name = "newaddress";
            this.newaddress.Size = new System.Drawing.Size(100, 22);
            this.newaddress.TabIndex = 56;
            this.newaddress.Visible = false;
            // 
            // sendaddress
            // 
            this.sendaddress.Location = new System.Drawing.Point(672, 31);
            this.sendaddress.Name = "sendaddress";
            this.sendaddress.Size = new System.Drawing.Size(114, 28);
            this.sendaddress.TabIndex = 57;
            this.sendaddress.Text = "Send Address";
            this.sendaddress.UseVisualStyleBackColor = true;
            this.sendaddress.Visible = false;
            this.sendaddress.Click += new System.EventHandler(this.sendaddress_Click);
            // 
            // nregisters
            // 
            this.nregisters.AutoSize = true;
            this.nregisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nregisters.Location = new System.Drawing.Point(898, 34);
            this.nregisters.Name = "nregisters";
            this.nregisters.Size = new System.Drawing.Size(214, 20);
            this.nregisters.TabIndex = 58;
            this.nregisters.Text = "ReadMultipleInputRegisters";
            this.nregisters.Visible = false;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.button11);
            this.Settings.Controls.Add(this.button2);
            this.Settings.Controls.Add(this.settingsbutton);
            this.Settings.Location = new System.Drawing.Point(3, 47);
            this.Settings.MaximumSize = new System.Drawing.Size(330, 100);
            this.Settings.MinimumSize = new System.Drawing.Size(330, 40);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(330, 40);
            this.Settings.TabIndex = 60;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 68);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(330, 32);
            this.button11.TabIndex = 61;
            this.button11.Text = "TCP";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 31);
            this.button2.TabIndex = 61;
            this.button2.Text = "RTU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsbutton
            // 
            this.settingsbutton.FlatAppearance.BorderSize = 0;
            this.settingsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbutton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsbutton.Image = global::ModBusV1.Properties.Resources.icons8_gear_32;
            this.settingsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsbutton.Location = new System.Drawing.Point(0, 0);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.Size = new System.Drawing.Size(327, 40);
            this.settingsbutton.TabIndex = 61;
            this.settingsbutton.Text = "Settings";
            this.settingsbutton.UseVisualStyleBackColor = true;
            this.settingsbutton.Click += new System.EventHandler(this.settingsbutton_Click);
            // 
            // Comms
            // 
            this.Comms.Controls.Add(this.button5);
            this.Comms.Location = new System.Drawing.Point(3, 139);
            this.Comms.Name = "Comms";
            this.Comms.Size = new System.Drawing.Size(332, 52);
            this.Comms.TabIndex = 60;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::ModBusV1.Properties.Resources.icons8_internet_of_things_32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(330, 52);
            this.button5.TabIndex = 61;
            this.button5.Text = "         Communication Traffic";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.seeTrafficToolStripMenuItem1_Click);
            // 
            // Functions
            // 
            this.Functions.Controls.Add(this.button9);
            this.Functions.Controls.Add(this.functionsbutton);
            this.Functions.Location = new System.Drawing.Point(3, 93);
            this.Functions.MaximumSize = new System.Drawing.Size(330, 70);
            this.Functions.MinimumSize = new System.Drawing.Size(330, 40);
            this.Functions.Name = "Functions";
            this.Functions.Size = new System.Drawing.Size(330, 40);
            this.Functions.TabIndex = 60;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 43);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(330, 29);
            this.button9.TabIndex = 61;
            this.button9.Text = "WriteReg";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.writeRegisterToolStripMenuItem_Click);
            // 
            // functionsbutton
            // 
            this.functionsbutton.FlatAppearance.BorderSize = 0;
            this.functionsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.functionsbutton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionsbutton.Image = global::ModBusV1.Properties.Resources.icons8_adjust_32;
            this.functionsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.functionsbutton.Location = new System.Drawing.Point(0, 0);
            this.functionsbutton.Name = "functionsbutton";
            this.functionsbutton.Size = new System.Drawing.Size(327, 40);
            this.functionsbutton.TabIndex = 61;
            this.functionsbutton.Text = "Functions";
            this.functionsbutton.UseVisualStyleBackColor = true;
            this.functionsbutton.Click += new System.EventHandler(this.functionsbutton_Click);
            // 
            // File
            // 
            this.File.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.File.Controls.Add(this.button1);
            this.File.Controls.Add(this.filebutton);
            this.File.Controls.Add(this.disconnectTCP);
            this.File.Controls.Add(this.connectRTU);
            this.File.Controls.Add(this.disconnectRTU);
            this.File.Controls.Add(this.connectTCP);
            this.File.Location = new System.Drawing.Point(3, 255);
            this.File.MaximumSize = new System.Drawing.Size(330, 155);
            this.File.MinimumSize = new System.Drawing.Size(330, 45);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(330, 45);
            this.File.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 24);
            this.button1.TabIndex = 62;
            this.button1.Text = "Gateway";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.gateway_Click);
            // 
            // filebutton
            // 
            this.filebutton.FlatAppearance.BorderSize = 0;
            this.filebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filebutton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filebutton.Image = global::ModBusV1.Properties.Resources.icons8_extra_features_32;
            this.filebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filebutton.Location = new System.Drawing.Point(0, 0);
            this.filebutton.Name = "filebutton";
            this.filebutton.Size = new System.Drawing.Size(330, 54);
            this.filebutton.TabIndex = 61;
            this.filebutton.Text = "File";
            this.filebutton.UseVisualStyleBackColor = true;
            this.filebutton.Click += new System.EventHandler(this.filebutton_Click);
            // 
            // disconnectTCP
            // 
            this.disconnectTCP.Enabled = false;
            this.disconnectTCP.FlatAppearance.BorderSize = 0;
            this.disconnectTCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectTCP.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectTCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disconnectTCP.Location = new System.Drawing.Point(0, 111);
            this.disconnectTCP.Name = "disconnectTCP";
            this.disconnectTCP.Size = new System.Drawing.Size(343, 24);
            this.disconnectTCP.TabIndex = 61;
            this.disconnectTCP.Text = "DisConnectTCP";
            this.disconnectTCP.UseVisualStyleBackColor = true;
            this.disconnectTCP.Click += new System.EventHandler(this.disConnectTCPToolStripMenuItem1_Click_1);
            // 
            // connectRTU
            // 
            this.connectRTU.FlatAppearance.BorderSize = 0;
            this.connectRTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectRTU.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectRTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectRTU.Location = new System.Drawing.Point(0, 50);
            this.connectRTU.Name = "connectRTU";
            this.connectRTU.Size = new System.Drawing.Size(343, 23);
            this.connectRTU.TabIndex = 61;
            this.connectRTU.Text = "ConnectRTU";
            this.connectRTU.UseVisualStyleBackColor = true;
            this.connectRTU.Click += new System.EventHandler(this.connectToolStripMenuItem_Click_1);
            // 
            // disconnectRTU
            // 
            this.disconnectRTU.Enabled = false;
            this.disconnectRTU.FlatAppearance.BorderSize = 0;
            this.disconnectRTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectRTU.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectRTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disconnectRTU.Location = new System.Drawing.Point(0, 91);
            this.disconnectRTU.Name = "disconnectRTU";
            this.disconnectRTU.Size = new System.Drawing.Size(343, 25);
            this.disconnectRTU.TabIndex = 61;
            this.disconnectRTU.Text = "DisConnectRTU";
            this.disconnectRTU.UseVisualStyleBackColor = true;
            this.disconnectRTU.Click += new System.EventHandler(this.disConnectToolStripMenuItem_Click);
            // 
            // connectTCP
            // 
            this.connectTCP.FlatAppearance.BorderSize = 0;
            this.connectTCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectTCP.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectTCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectTCP.Location = new System.Drawing.Point(0, 70);
            this.connectTCP.Name = "connectTCP";
            this.connectTCP.Size = new System.Drawing.Size(343, 25);
            this.connectTCP.TabIndex = 61;
            this.connectTCP.Text = "ConnectTCP";
            this.connectTCP.UseVisualStyleBackColor = true;
            this.connectTCP.Click += new System.EventHandler(this.connectTCPToolStripMenuItem1_Click);
            // 
            // Exit
            // 
            this.Exit.Controls.Add(this.button10);
            this.Exit.Location = new System.Drawing.Point(3, 197);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(327, 52);
            this.Exit.TabIndex = 62;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(331, 52);
            this.button10.TabIndex = 61;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.menu.Controls.Add(this.menubutton);
            this.menu.Controls.Add(this.label1);
            this.menu.Location = new System.Drawing.Point(3, 3);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(327, 38);
            this.menu.TabIndex = 60;
            // 
            // menubutton
            // 
            this.menubutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubutton.Image = global::ModBusV1.Properties.Resources.icons8_menu_120;
            this.menubutton.Location = new System.Drawing.Point(3, 3);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(45, 35);
            this.menubutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menubutton.TabIndex = 60;
            this.menubutton.TabStop = false;
            this.menubutton.Click += new System.EventHandler(this.menubutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 60;
            this.label1.Text = "Menu";
            // 
            // sidemenutimer
            // 
            this.sidemenutimer.Interval = 10;
            this.sidemenutimer.Tick += new System.EventHandler(this.sidemenutimer_Tick);
            // 
            // filetimer
            // 
            this.filetimer.Interval = 10;
            this.filetimer.Tick += new System.EventHandler(this.filetimer_Tick);
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidemenu.Controls.Add(this.menu);
            this.sidemenu.Controls.Add(this.Settings);
            this.sidemenu.Controls.Add(this.Functions);
            this.sidemenu.Controls.Add(this.Comms);
            this.sidemenu.Controls.Add(this.Exit);
            this.sidemenu.Controls.Add(this.File);
            this.sidemenu.Location = new System.Drawing.Point(1, -1);
            this.sidemenu.MaximumSize = new System.Drawing.Size(330, 510);
            this.sidemenu.MinimumSize = new System.Drawing.Size(60, 480);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(330, 510);
            this.sidemenu.TabIndex = 60;
            // 
            // settingstimer
            // 
            this.settingstimer.Interval = 10;
            this.settingstimer.Tick += new System.EventHandler(this.settingstimer_Tick);
            // 
            // functionstimer
            // 
            this.functionstimer.Interval = 10;
            this.functionstimer.Tick += new System.EventHandler(this.functionstimer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1398, 534);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.nregisters);
            this.Controls.Add(this.sendaddress);
            this.Controls.Add(this.newaddress);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.numAddress);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Comms.ResumeLayout(false);
            this.Functions.ResumeLayout(false);
            this.File.ResumeLayout(false);
            this.Exit.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
            this.sidemenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.NumericUpDown numAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox newaddress;
        private System.Windows.Forms.Button sendaddress;
        private System.Windows.Forms.Label nregisters;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel File;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Panel Functions;
        private System.Windows.Forms.Panel Comms;
        private System.Windows.Forms.Button filebutton;
        private System.Windows.Forms.Button settingsbutton;
        private System.Windows.Forms.Button functionsbutton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox menubutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidemenutimer;
        private System.Windows.Forms.Button connectRTU;
        private System.Windows.Forms.Button connectTCP;
        private System.Windows.Forms.Button disconnectRTU;
        private System.Windows.Forms.Button disconnectTCP;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.Timer filetimer;
        private System.Windows.Forms.FlowLayoutPanel sidemenu;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer settingstimer;
        private System.Windows.Forms.Timer functionstimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.Button button1;
    }
}

