
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pFooter = new System.Windows.Forms.Panel();
            this.aFooter = new System.Windows.Forms.LinkLabel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblLoggedUSer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.dataClientsView = new System.Windows.Forms.DataGridView();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleintCabinType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCabinNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCurent = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridBookings = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBookPh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCurentList = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
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
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkingInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pFooter.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pSingle.SuspendLayout();
            this.pDouble.SuspendLayout();
            this.pSuite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkingInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.Olive;
            this.pFooter.Controls.Add(this.aFooter);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 915);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1906, 60);
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
            this.aFooter.Location = new System.Drawing.Point(814, 33);
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
            this.pHeader.Controls.Add(this.lblTime);
            this.pHeader.Controls.Add(this.lblUser);
            this.pHeader.Controls.Add(this.lblClock);
            this.pHeader.Controls.Add(this.imgClose);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1906, 135);
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
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Trajan Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1706, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 30);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time:";
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
            this.lblClock.Location = new System.Drawing.Point(1794, 72);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(109, 30);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "00:00:00";
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(1856, 3);
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
            this.pictureBox1.Location = new System.Drawing.Point(1532, 413);
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
            this.lblLogo.Location = new System.Drawing.Point(1423, 608);
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClientsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataClientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientName,
            this.clientSurname,
            this.clientPhone,
            this.clientCheckIn,
            this.clientCheckOut,
            this.cleintCabinType,
            this.clientCabinNumber,
            this.clientNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataClientsView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataClientsView.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataClientsView.Location = new System.Drawing.Point(0, 721);
            this.dataClientsView.Name = "dataClientsView";
            this.dataClientsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClientsView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataClientsView.RowHeadersWidth = 51;
            this.dataClientsView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Olive;
            this.dataClientsView.RowTemplate.Height = 24;
            this.dataClientsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientsView.Size = new System.Drawing.Size(1907, 224);
            this.dataClientsView.TabIndex = 4;
            // 
            // clientName
            // 
            this.clientName.HeaderText = "Name";
            this.clientName.MinimumWidth = 6;
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            // 
            // clientSurname
            // 
            this.clientSurname.HeaderText = "Surname";
            this.clientSurname.MinimumWidth = 6;
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.ReadOnly = true;
            // 
            // clientPhone
            // 
            this.clientPhone.HeaderText = "Phone";
            this.clientPhone.MinimumWidth = 6;
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.ReadOnly = true;
            // 
            // clientCheckIn
            // 
            this.clientCheckIn.HeaderText = "Check in";
            this.clientCheckIn.MinimumWidth = 6;
            this.clientCheckIn.Name = "clientCheckIn";
            this.clientCheckIn.ReadOnly = true;
            // 
            // clientCheckOut
            // 
            this.clientCheckOut.HeaderText = "Check out";
            this.clientCheckOut.MinimumWidth = 6;
            this.clientCheckOut.Name = "clientCheckOut";
            this.clientCheckOut.ReadOnly = true;
            // 
            // cleintCabinType
            // 
            this.cleintCabinType.HeaderText = "Cabin type";
            this.cleintCabinType.MinimumWidth = 6;
            this.cleintCabinType.Name = "cleintCabinType";
            this.cleintCabinType.ReadOnly = true;
            // 
            // clientCabinNumber
            // 
            this.clientCabinNumber.HeaderText = "Cabin Number";
            this.clientCabinNumber.MinimumWidth = 6;
            this.clientCabinNumber.Name = "clientCabinNumber";
            this.clientCabinNumber.ReadOnly = true;
            // 
            // clientNotes
            // 
            this.clientNotes.HeaderText = "Notes";
            this.clientNotes.MinimumWidth = 6;
            this.clientNotes.Name = "clientNotes";
            this.clientNotes.ReadOnly = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCheckIn.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(1251, 170);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(115, 84);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBookings.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.White;
            this.btnBookings.Location = new System.Drawing.Point(1590, 170);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(115, 84);
            this.btnBookings.TabIndex = 7;
            this.btnBookings.Text = "Current Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
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
            this.lblCurent.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCurent.Location = new System.Drawing.Point(12, 690);
            this.lblCurent.Name = "lblCurent";
            this.lblCurent.Size = new System.Drawing.Size(344, 38);
            this.lblCurent.TabIndex = 10;
            this.lblCurent.Text = "Current guest list";
            // 
            // dataGridBookings
            // 
            this.dataGridBookings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBookings.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.clientBookPh,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridBookings.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataGridBookings.Location = new System.Drawing.Point(0, 723);
            this.dataGridBookings.Name = "dataGridBookings";
            this.dataGridBookings.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridBookings.RowHeadersWidth = 51;
            this.dataGridBookings.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Olive;
            this.dataGridBookings.RowTemplate.Height = 24;
            this.dataGridBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBookings.Size = new System.Drawing.Size(1907, 222);
            this.dataGridBookings.TabIndex = 12;
            this.dataGridBookings.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Surname";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // clientBookPh
            // 
            this.clientBookPh.HeaderText = "Phone";
            this.clientBookPh.MinimumWidth = 6;
            this.clientBookPh.Name = "clientBookPh";
            this.clientBookPh.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Check In";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Check Out";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Notes";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnCurentList
            // 
            this.btnCurentList.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCurentList.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurentList.ForeColor = System.Drawing.Color.White;
            this.btnCurentList.Location = new System.Drawing.Point(1754, 170);
            this.btnCurentList.Name = "btnCurentList";
            this.btnCurentList.Size = new System.Drawing.Size(115, 84);
            this.btnCurentList.TabIndex = 14;
            this.btnCurentList.Text = "Current Guests ";
            this.btnCurentList.UseVisualStyleBackColor = false;
            this.btnCurentList.Click += new System.EventHandler(this.btnCurentList_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAddBooking.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.Location = new System.Drawing.Point(1420, 170);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(115, 84);
            this.btnAddBooking.TabIndex = 15;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(805, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 66);
            this.panel3.TabIndex = 43;
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
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(406, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 66);
            this.panel2.TabIndex = 42;
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
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(27, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 66);
            this.panel1.TabIndex = 41;
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
            this.pSingle.Location = new System.Drawing.Point(806, 253);
            this.pSingle.Name = "pSingle";
            this.pSingle.Size = new System.Drawing.Size(191, 385);
            this.pSingle.TabIndex = 40;
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
            this.btnCab10.Click += new System.EventHandler(this.btnCab10_Click);
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
            this.btnCab5.Click += new System.EventHandler(this.btnCab5_Click);
            // 
            // pDouble
            // 
            this.pDouble.BackColor = System.Drawing.Color.White;
            this.pDouble.Controls.Add(this.btnCab8);
            this.pDouble.Controls.Add(this.btnCab9);
            this.pDouble.Controls.Add(this.btnCab3);
            this.pDouble.Controls.Add(this.btnCab4);
            this.pDouble.Location = new System.Drawing.Point(404, 253);
            this.pDouble.Name = "pDouble";
            this.pDouble.Size = new System.Drawing.Size(362, 385);
            this.pDouble.TabIndex = 39;
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
            this.btnCab8.Click += new System.EventHandler(this.btnCab8_Click);
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
            this.btnCab9.Click += new System.EventHandler(this.btnCab9_Click);
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
            this.btnCab3.Click += new System.EventHandler(this.btnCab3_Click);
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
            this.btnCab4.Click += new System.EventHandler(this.btnCab4_Click);
            // 
            // pSuite
            // 
            this.pSuite.BackColor = System.Drawing.Color.White;
            this.pSuite.Controls.Add(this.btnCab6);
            this.pSuite.Controls.Add(this.btnCab7);
            this.pSuite.Controls.Add(this.btnCab1);
            this.pSuite.Controls.Add(this.btnCab2);
            this.pSuite.Location = new System.Drawing.Point(27, 253);
            this.pSuite.Name = "pSuite";
            this.pSuite.Size = new System.Drawing.Size(336, 386);
            this.pSuite.TabIndex = 38;
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
            this.btnCab6.Click += new System.EventHandler(this.btnCab6_Click);
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
            this.btnCab7.Click += new System.EventHandler(this.btnCab7_Click);
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
            this.btnCab1.Click += new System.EventHandler(this.btnCab1_Click);
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
            this.btnCab2.Click += new System.EventHandler(this.btnCab2_Click);
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataSource = typeof(Project.Bookings);
            // 
            // checkingInBindingSource
            // 
            this.checkingInBindingSource.DataSource = typeof(Project.CheckingIn);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1906, 975);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataClientsView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pSingle);
            this.Controls.Add(this.pDouble);
            this.Controls.Add(this.pSuite);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.btnCurentList);
            this.Controls.Add(this.dataGridBookings);
            this.Controls.Add(this.lblCurent);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnCheckIn);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pSingle.ResumeLayout(false);
            this.pDouble.ResumeLayout(false);
            this.pSuite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkingInBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurent;
        private System.Windows.Forms.Label lblLoggedUSer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.BindingSource checkingInBindingSource;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private System.Windows.Forms.DataGridView dataGridBookings;
        private System.Windows.Forms.Button btnCurentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBookPh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleintCabinType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCabinNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNotes;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
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
    }
}

