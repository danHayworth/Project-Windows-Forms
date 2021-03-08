
namespace Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pFooter = new System.Windows.Forms.Panel();
            this.aFooter = new System.Windows.Forms.LinkLabel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblLoggedUSer = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.dataClientsView = new System.Windows.Forms.DataGridView();
            this.clientNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCHECKIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCHECKOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSERVICES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCurent = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabLeftMenu = new System.Windows.Forms.TabControl();
            this.tabAvailability = new System.Windows.Forms.TabPage();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.pNavigation = new System.Windows.Forms.Panel();
            this.pAvailability = new System.Windows.Forms.Panel();
            this.txtSingleNo = new System.Windows.Forms.TextBox();
            this.txtDoubleNo = new System.Windows.Forms.TextBox();
            this.txtSuiteNo = new System.Windows.Forms.TextBox();
            this.lblSingle = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblSuite = new System.Windows.Forms.Label();
            this.tabCabins = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pSingle = new System.Windows.Forms.Panel();
            this.btnCab10 = new System.Windows.Forms.Button();
            this.btnCab5 = new System.Windows.Forms.Button();
            this.pDouble = new System.Windows.Forms.Panel();
            this.btnCab8 = new System.Windows.Forms.Button();
            this.btnCab9 = new System.Windows.Forms.Button();
            this.btnCab3 = new System.Windows.Forms.Button();
            this.btnCab4 = new System.Windows.Forms.Button();
            this.pSuite = new System.Windows.Forms.Panel();
            this.btnCab6 = new System.Windows.Forms.Button();
            this.btnCab7 = new System.Windows.Forms.Button();
            this.btnCab1 = new System.Windows.Forms.Button();
            this.btnCab2 = new System.Windows.Forms.Button();
            this.pFooter.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabLeftMenu.SuspendLayout();
            this.tabAvailability.SuspendLayout();
            this.pAvailability.SuspendLayout();
            this.tabCabins.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pSingle.SuspendLayout();
            this.pDouble.SuspendLayout();
            this.pSuite.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.Olive;
            this.pFooter.Controls.Add(this.aFooter);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 764);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1842, 338);
            this.pFooter.TabIndex = 0;
            // 
            // aFooter
            // 
            this.aFooter.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.aFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aFooter.AutoSize = true;
            this.aFooter.Font = new System.Drawing.Font("Trajan Pro", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aFooter.LinkColor = System.Drawing.Color.Snow;
            this.aFooter.Location = new System.Drawing.Point(814, 311);
            this.aFooter.Name = "aFooter";
            this.aFooter.Size = new System.Drawing.Size(458, 18);
            this.aFooter.TabIndex = 1;
            this.aFooter.TabStop = true;
            this.aFooter.Text = "Cabin Management System developed by Dan Hayworth";
            this.aFooter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aFooter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aFooter_LinkClicked);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Olive;
            this.pHeader.Controls.Add(this.lblLoggedUSer);
            this.pHeader.Controls.Add(this.lblSearch);
            this.pHeader.Controls.Add(this.lblTime);
            this.pHeader.Controls.Add(this.txtSearch);
            this.pHeader.Controls.Add(this.lblUser);
            this.pHeader.Controls.Add(this.lblClock);
            this.pHeader.Controls.Add(this.imgClose);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1842, 108);
            this.pHeader.TabIndex = 1;
            // 
            // lblLoggedUSer
            // 
            this.lblLoggedUSer.AutoSize = true;
            this.lblLoggedUSer.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUSer.ForeColor = System.Drawing.Color.White;
            this.lblLoggedUSer.Location = new System.Drawing.Point(161, 44);
            this.lblLoggedUSer.Name = "lblLoggedUSer";
            this.lblLoggedUSer.Size = new System.Drawing.Size(35, 22);
            this.lblLoggedUSer.TabIndex = 14;
            this.lblLoggedUSer.Text = "     ";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Trajan Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(751, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(226, 22);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search guest by name:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Trajan Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1642, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 30);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(755, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 28);
            this.txtSearch.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(13, 44);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(142, 22);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Logged user: ";
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(1730, 72);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(109, 30);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "00:00:00";
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(1792, 3);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(47, 46);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 0;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1408, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblLogo.Location = new System.Drawing.Point(1321, 634);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(379, 30);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "THE CABIN IN THE WOODS";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataClientsView
            // 
            this.dataClientsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataClientsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClientsView.BackgroundColor = System.Drawing.Color.White;
            this.dataClientsView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClientsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataClientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNAME,
            this.clientSURNAME,
            this.clientPAS,
            this.clientCHECKIN,
            this.clientCHECKOUT,
            this.clientSERVICES});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataClientsView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataClientsView.Location = new System.Drawing.Point(0, 760);
            this.dataClientsView.Name = "dataClientsView";
            this.dataClientsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataClientsView.RowHeadersWidth = 51;
            this.dataClientsView.RowTemplate.Height = 24;
            this.dataClientsView.Size = new System.Drawing.Size(1842, 288);
            this.dataClientsView.TabIndex = 4;
            // 
            // clientNAME
            // 
            this.clientNAME.HeaderText = "Name";
            this.clientNAME.MinimumWidth = 6;
            this.clientNAME.Name = "clientNAME";
            this.clientNAME.ReadOnly = true;
            // 
            // clientSURNAME
            // 
            this.clientSURNAME.HeaderText = "Surname";
            this.clientSURNAME.MinimumWidth = 6;
            this.clientSURNAME.Name = "clientSURNAME";
            this.clientSURNAME.ReadOnly = true;
            // 
            // clientPAS
            // 
            this.clientPAS.HeaderText = "Cabin Number";
            this.clientPAS.MinimumWidth = 6;
            this.clientPAS.Name = "clientPAS";
            this.clientPAS.ReadOnly = true;
            // 
            // clientCHECKIN
            // 
            this.clientCHECKIN.HeaderText = "Check in";
            this.clientCHECKIN.MinimumWidth = 6;
            this.clientCHECKIN.Name = "clientCHECKIN";
            this.clientCHECKIN.ReadOnly = true;
            // 
            // clientCHECKOUT
            // 
            this.clientCHECKOUT.HeaderText = "Check out";
            this.clientCHECKOUT.MinimumWidth = 6;
            this.clientCHECKOUT.Name = "clientCHECKOUT";
            this.clientCHECKOUT.ReadOnly = true;
            // 
            // clientSERVICES
            // 
            this.clientSERVICES.HeaderText = "Services";
            this.clientSERVICES.MinimumWidth = 6;
            this.clientSERVICES.Name = "clientSERVICES";
            this.clientSERVICES.ReadOnly = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Olive;
            this.btnCheckIn.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(1268, 139);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(115, 84);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.Olive;
            this.btnBookings.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.White;
            this.btnBookings.Location = new System.Drawing.Point(1431, 139);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(115, 84);
            this.btnBookings.TabIndex = 7;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // lblCurent
            // 
            this.lblCurent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurent.AutoSize = true;
            this.lblCurent.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurent.Location = new System.Drawing.Point(9, 716);
            this.lblCurent.Name = "lblCurent";
            this.lblCurent.Size = new System.Drawing.Size(259, 30);
            this.lblCurent.TabIndex = 10;
            this.lblCurent.Text = "Curent guest list";
            // 
            // tabLeftMenu
            // 
            this.tabLeftMenu.Controls.Add(this.tabAvailability);
            this.tabLeftMenu.Controls.Add(this.tabCabins);
            this.tabLeftMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLeftMenu.Location = new System.Drawing.Point(10, 114);
            this.tabLeftMenu.Name = "tabLeftMenu";
            this.tabLeftMenu.SelectedIndex = 0;
            this.tabLeftMenu.Size = new System.Drawing.Size(1252, 580);
            this.tabLeftMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabLeftMenu.TabIndex = 13;
            // 
            // tabAvailability
            // 
            this.tabAvailability.AutoScroll = true;
            this.tabAvailability.BackColor = System.Drawing.Color.AliceBlue;
            this.tabAvailability.Controls.Add(this.lblAvailability);
            this.tabAvailability.Controls.Add(this.pNavigation);
            this.tabAvailability.Controls.Add(this.pAvailability);
            this.tabAvailability.Location = new System.Drawing.Point(4, 29);
            this.tabAvailability.Name = "tabAvailability";
            this.tabAvailability.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailability.Size = new System.Drawing.Size(1244, 547);
            this.tabAvailability.TabIndex = 0;
            this.tabAvailability.Text = "Availability";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(32, 86);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(172, 30);
            this.lblAvailability.TabIndex = 12;
            this.lblAvailability.Text = "Availability";
            // 
            // pNavigation
            // 
            this.pNavigation.Location = new System.Drawing.Point(398, 3);
            this.pNavigation.Name = "pNavigation";
            this.pNavigation.Size = new System.Drawing.Size(840, 503);
            this.pNavigation.TabIndex = 13;
            // 
            // pAvailability
            // 
            this.pAvailability.BackColor = System.Drawing.Color.White;
            this.pAvailability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAvailability.Controls.Add(this.txtSingleNo);
            this.pAvailability.Controls.Add(this.txtDoubleNo);
            this.pAvailability.Controls.Add(this.txtSuiteNo);
            this.pAvailability.Controls.Add(this.lblSingle);
            this.pAvailability.Controls.Add(this.lblDouble);
            this.pAvailability.Controls.Add(this.lblSuite);
            this.pAvailability.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAvailability.Location = new System.Drawing.Point(37, 154);
            this.pAvailability.Name = "pAvailability";
            this.pAvailability.Size = new System.Drawing.Size(226, 234);
            this.pAvailability.TabIndex = 11;
            // 
            // txtSingleNo
            // 
            this.txtSingleNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSingleNo.Enabled = false;
            this.txtSingleNo.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSingleNo.Location = new System.Drawing.Point(147, 150);
            this.txtSingleNo.Name = "txtSingleNo";
            this.txtSingleNo.Size = new System.Drawing.Size(61, 28);
            this.txtSingleNo.TabIndex = 17;
            // 
            // txtDoubleNo
            // 
            this.txtDoubleNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoubleNo.Enabled = false;
            this.txtDoubleNo.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoubleNo.Location = new System.Drawing.Point(147, 80);
            this.txtDoubleNo.Name = "txtDoubleNo";
            this.txtDoubleNo.Size = new System.Drawing.Size(61, 28);
            this.txtDoubleNo.TabIndex = 18;
            // 
            // txtSuiteNo
            // 
            this.txtSuiteNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuiteNo.Enabled = false;
            this.txtSuiteNo.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuiteNo.Location = new System.Drawing.Point(147, 16);
            this.txtSuiteNo.Name = "txtSuiteNo";
            this.txtSuiteNo.Size = new System.Drawing.Size(61, 28);
            this.txtSuiteNo.TabIndex = 16;
            // 
            // lblSingle
            // 
            this.lblSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSingle.AutoSize = true;
            this.lblSingle.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingle.Location = new System.Drawing.Point(36, 155);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(77, 22);
            this.lblSingle.TabIndex = 15;
            this.lblSingle.Text = "Single:";
            // 
            // lblDouble
            // 
            this.lblDouble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDouble.AutoSize = true;
            this.lblDouble.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDouble.Location = new System.Drawing.Point(25, 85);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(86, 22);
            this.lblDouble.TabIndex = 14;
            this.lblDouble.Text = "Double:";
            // 
            // lblSuite
            // 
            this.lblSuite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuite.AutoSize = true;
            this.lblSuite.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuite.Location = new System.Drawing.Point(51, 20);
            this.lblSuite.Name = "lblSuite";
            this.lblSuite.Size = new System.Drawing.Size(65, 22);
            this.lblSuite.TabIndex = 13;
            this.lblSuite.Text = "Suite:";
            // 
            // tabCabins
            // 
            this.tabCabins.BackColor = System.Drawing.Color.AliceBlue;
            this.tabCabins.Controls.Add(this.panel3);
            this.tabCabins.Controls.Add(this.panel2);
            this.tabCabins.Controls.Add(this.panel1);
            this.tabCabins.Controls.Add(this.pSingle);
            this.tabCabins.Controls.Add(this.pDouble);
            this.tabCabins.Controls.Add(this.pSuite);
            this.tabCabins.Location = new System.Drawing.Point(4, 29);
            this.tabCabins.Name = "tabCabins";
            this.tabCabins.Padding = new System.Windows.Forms.Padding(3);
            this.tabCabins.Size = new System.Drawing.Size(1244, 547);
            this.tabCabins.TabIndex = 1;
            this.tabCabins.Text = "Cabins";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Olive;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(928, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 66);
            this.panel3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Single";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(458, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 66);
            this.panel2.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(125, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Double";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(29, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 66);
            this.panel1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(121, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Suite";
            // 
            // pSingle
            // 
            this.pSingle.BackColor = System.Drawing.Color.White;
            this.pSingle.Controls.Add(this.btnCab10);
            this.pSingle.Controls.Add(this.btnCab5);
            this.pSingle.Location = new System.Drawing.Point(929, 83);
            this.pSingle.Name = "pSingle";
            this.pSingle.Size = new System.Drawing.Size(191, 385);
            this.pSingle.TabIndex = 31;
            // 
            // btnCab10
            // 
            this.btnCab10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab10.BackColor = System.Drawing.Color.Olive;
            this.btnCab10.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab10.ForeColor = System.Drawing.Color.White;
            this.btnCab10.Location = new System.Drawing.Point(36, 232);
            this.btnCab10.Name = "btnCab10";
            this.btnCab10.Size = new System.Drawing.Size(115, 84);
            this.btnCab10.TabIndex = 16;
            this.btnCab10.Text = "Cabin 10";
            this.btnCab10.UseVisualStyleBackColor = false;
            // 
            // btnCab5
            // 
            this.btnCab5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab5.BackColor = System.Drawing.Color.Olive;
            this.btnCab5.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab5.ForeColor = System.Drawing.Color.White;
            this.btnCab5.Location = new System.Drawing.Point(36, 75);
            this.btnCab5.Name = "btnCab5";
            this.btnCab5.Size = new System.Drawing.Size(115, 84);
            this.btnCab5.TabIndex = 15;
            this.btnCab5.Text = "Cabin 5";
            this.btnCab5.UseVisualStyleBackColor = false;
            // 
            // pDouble
            // 
            this.pDouble.BackColor = System.Drawing.Color.White;
            this.pDouble.Controls.Add(this.btnCab8);
            this.pDouble.Controls.Add(this.btnCab9);
            this.pDouble.Controls.Add(this.btnCab3);
            this.pDouble.Controls.Add(this.btnCab4);
            this.pDouble.Location = new System.Drawing.Point(457, 83);
            this.pDouble.Name = "pDouble";
            this.pDouble.Size = new System.Drawing.Size(362, 385);
            this.pDouble.TabIndex = 30;
            // 
            // btnCab8
            // 
            this.btnCab8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab8.BackColor = System.Drawing.Color.Olive;
            this.btnCab8.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab8.ForeColor = System.Drawing.Color.White;
            this.btnCab8.Location = new System.Drawing.Point(29, 232);
            this.btnCab8.Name = "btnCab8";
            this.btnCab8.Size = new System.Drawing.Size(115, 84);
            this.btnCab8.TabIndex = 12;
            this.btnCab8.Text = "Cabin 8";
            this.btnCab8.UseVisualStyleBackColor = false;
            // 
            // btnCab9
            // 
            this.btnCab9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab9.BackColor = System.Drawing.Color.Olive;
            this.btnCab9.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab9.ForeColor = System.Drawing.Color.White;
            this.btnCab9.Location = new System.Drawing.Point(206, 232);
            this.btnCab9.Name = "btnCab9";
            this.btnCab9.Size = new System.Drawing.Size(115, 84);
            this.btnCab9.TabIndex = 11;
            this.btnCab9.Text = "Cabin 9";
            this.btnCab9.UseVisualStyleBackColor = false;
            // 
            // btnCab3
            // 
            this.btnCab3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab3.BackColor = System.Drawing.Color.Olive;
            this.btnCab3.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab3.ForeColor = System.Drawing.Color.White;
            this.btnCab3.Location = new System.Drawing.Point(29, 75);
            this.btnCab3.Name = "btnCab3";
            this.btnCab3.Size = new System.Drawing.Size(115, 84);
            this.btnCab3.TabIndex = 8;
            this.btnCab3.Text = "Cabin 3";
            this.btnCab3.UseVisualStyleBackColor = false;
            // 
            // btnCab4
            // 
            this.btnCab4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab4.BackColor = System.Drawing.Color.Olive;
            this.btnCab4.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab4.ForeColor = System.Drawing.Color.White;
            this.btnCab4.Location = new System.Drawing.Point(206, 75);
            this.btnCab4.Name = "btnCab4";
            this.btnCab4.Size = new System.Drawing.Size(115, 84);
            this.btnCab4.TabIndex = 7;
            this.btnCab4.Text = "Cabin 4";
            this.btnCab4.UseVisualStyleBackColor = false;
            // 
            // pSuite
            // 
            this.pSuite.BackColor = System.Drawing.Color.White;
            this.pSuite.Controls.Add(this.btnCab6);
            this.pSuite.Controls.Add(this.btnCab7);
            this.pSuite.Controls.Add(this.btnCab1);
            this.pSuite.Controls.Add(this.btnCab2);
            this.pSuite.Location = new System.Drawing.Point(29, 83);
            this.pSuite.Name = "pSuite";
            this.pSuite.Size = new System.Drawing.Size(336, 386);
            this.pSuite.TabIndex = 29;
            // 
            // btnCab6
            // 
            this.btnCab6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab6.BackColor = System.Drawing.Color.Olive;
            this.btnCab6.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab6.ForeColor = System.Drawing.Color.White;
            this.btnCab6.Location = new System.Drawing.Point(18, 232);
            this.btnCab6.Name = "btnCab6";
            this.btnCab6.Size = new System.Drawing.Size(115, 84);
            this.btnCab6.TabIndex = 14;
            this.btnCab6.Text = "Cabin 6";
            this.btnCab6.UseVisualStyleBackColor = false;
            // 
            // btnCab7
            // 
            this.btnCab7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab7.BackColor = System.Drawing.Color.Olive;
            this.btnCab7.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab7.ForeColor = System.Drawing.Color.White;
            this.btnCab7.Location = new System.Drawing.Point(185, 232);
            this.btnCab7.Name = "btnCab7";
            this.btnCab7.Size = new System.Drawing.Size(115, 84);
            this.btnCab7.TabIndex = 13;
            this.btnCab7.Text = "Cabin 7";
            this.btnCab7.UseVisualStyleBackColor = false;
            // 
            // btnCab1
            // 
            this.btnCab1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab1.BackColor = System.Drawing.Color.Olive;
            this.btnCab1.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab1.ForeColor = System.Drawing.Color.White;
            this.btnCab1.Location = new System.Drawing.Point(18, 75);
            this.btnCab1.Name = "btnCab1";
            this.btnCab1.Size = new System.Drawing.Size(115, 84);
            this.btnCab1.TabIndex = 10;
            this.btnCab1.Text = "Cabin 1";
            this.btnCab1.UseVisualStyleBackColor = false;
            // 
            // btnCab2
            // 
            this.btnCab2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCab2.BackColor = System.Drawing.Color.Olive;
            this.btnCab2.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCab2.ForeColor = System.Drawing.Color.White;
            this.btnCab2.Location = new System.Drawing.Point(185, 75);
            this.btnCab2.Name = "btnCab2";
            this.btnCab2.Size = new System.Drawing.Size(115, 84);
            this.btnCab2.TabIndex = 9;
            this.btnCab2.Text = "Cabin 2";
            this.btnCab2.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1842, 1102);
            this.Controls.Add(this.tabLeftMenu);
            this.Controls.Add(this.lblCurent);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dataClientsView);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabLeftMenu.ResumeLayout(false);
            this.tabAvailability.ResumeLayout(false);
            this.tabAvailability.PerformLayout();
            this.pAvailability.ResumeLayout(false);
            this.pAvailability.PerformLayout();
            this.tabCabins.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pSingle.ResumeLayout(false);
            this.pDouble.ResumeLayout(false);
            this.pSuite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.LinkLabel aFooter;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DataGridView dataClientsView;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurent;
        private System.Windows.Forms.Label lblLoggedUSer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCHECKIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCHECKOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSERVICES;
        private System.Windows.Forms.TabControl tabLeftMenu;
        private System.Windows.Forms.TabPage tabAvailability;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Panel pAvailability;
        private System.Windows.Forms.TextBox txtSingleNo;
        private System.Windows.Forms.TextBox txtDoubleNo;
        private System.Windows.Forms.TextBox txtSuiteNo;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblSuite;
        private System.Windows.Forms.TabPage tabCabins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pSingle;
        private System.Windows.Forms.Button btnCab10;
        private System.Windows.Forms.Button btnCab5;
        private System.Windows.Forms.Panel pDouble;
        private System.Windows.Forms.Button btnCab8;
        private System.Windows.Forms.Button btnCab9;
        private System.Windows.Forms.Button btnCab3;
        private System.Windows.Forms.Button btnCab4;
        private System.Windows.Forms.Panel pSuite;
        private System.Windows.Forms.Button btnCab6;
        private System.Windows.Forms.Button btnCab7;
        private System.Windows.Forms.Button btnCab1;
        private System.Windows.Forms.Button btnCab2;
        private System.Windows.Forms.Panel pNavigation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

