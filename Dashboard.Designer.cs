
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pFooter = new System.Windows.Forms.Panel();
            this.aFooter = new System.Windows.Forms.LinkLabel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblLoggedUSer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.dataClientsView = new System.Windows.Forms.DataGridView();
            this.clientNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCHECKIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCHECKOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSERVICES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCabin = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCurent = new System.Windows.Forms.Label();
            this.pAvailability = new System.Windows.Forms.Panel();
            this.txtSingleNo = new System.Windows.Forms.TextBox();
            this.txtDoubleNo = new System.Windows.Forms.TextBox();
            this.txtSuiteNo = new System.Windows.Forms.TextBox();
            this.lblSingle = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblSuite = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.pNavigation = new System.Windows.Forms.Panel();
            this.pFooter.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientsView)).BeginInit();
            this.pAvailability.SuspendLayout();
            this.pNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.Olive;
            this.pFooter.Controls.Add(this.aFooter);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 865);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1810, 138);
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
            this.aFooter.Location = new System.Drawing.Point(814, 111);
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
            this.pHeader.Size = new System.Drawing.Size(1810, 108);
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
            this.lblTime.Location = new System.Drawing.Point(1610, 72);
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
            this.lblClock.Location = new System.Drawing.Point(1698, 72);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(109, 30);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "00:00:00";
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(1760, 3);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(47, 46);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 0;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Trajan Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(813, 569);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(226, 22);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search guest by name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(744, 603);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 28);
            this.txtSearch.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(943, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblLogo.Location = new System.Drawing.Point(856, 436);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClientsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataClientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNAME,
            this.clientSURNAME,
            this.clientPAS,
            this.clientCHECKIN,
            this.clientCHECKOUT,
            this.clientSERVICES});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataClientsView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataClientsView.Location = new System.Drawing.Point(0, 661);
            this.dataClientsView.Name = "dataClientsView";
            this.dataClientsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataClientsView.RowHeadersWidth = 51;
            this.dataClientsView.RowTemplate.Height = 24;
            this.dataClientsView.Size = new System.Drawing.Size(1810, 288);
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
            // btnCabin
            // 
            this.btnCabin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCabin.BackColor = System.Drawing.Color.Olive;
            this.btnCabin.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabin.ForeColor = System.Drawing.Color.White;
            this.btnCabin.Location = new System.Drawing.Point(1653, 459);
            this.btnCabin.Name = "btnCabin";
            this.btnCabin.Size = new System.Drawing.Size(115, 84);
            this.btnCabin.TabIndex = 5;
            this.btnCabin.Text = "Cabins";
            this.btnCabin.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCheckIn.BackColor = System.Drawing.Color.Olive;
            this.btnCheckIn.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(1653, 239);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(115, 84);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBookings.BackColor = System.Drawing.Color.Olive;
            this.btnBookings.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.White;
            this.btnBookings.Location = new System.Drawing.Point(1653, 349);
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
            this.lblCurent.Location = new System.Drawing.Point(9, 617);
            this.lblCurent.Name = "lblCurent";
            this.lblCurent.Size = new System.Drawing.Size(259, 30);
            this.lblCurent.TabIndex = 10;
            this.lblCurent.Text = "Curent guest list";
            // 
            // pAvailability
            // 
            this.pAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pAvailability.BackColor = System.Drawing.Color.White;
            this.pAvailability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAvailability.Controls.Add(this.txtSingleNo);
            this.pAvailability.Controls.Add(this.txtDoubleNo);
            this.pAvailability.Controls.Add(this.txtSuiteNo);
            this.pAvailability.Controls.Add(this.lblSingle);
            this.pAvailability.Controls.Add(this.lblDouble);
            this.pAvailability.Controls.Add(this.lblSuite);
            this.pAvailability.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAvailability.Location = new System.Drawing.Point(11, 249);
            this.pAvailability.Name = "pAvailability";
            this.pAvailability.Size = new System.Drawing.Size(244, 202);
            this.pAvailability.TabIndex = 11;
            // 
            // txtSingleNo
            // 
            this.txtSingleNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSingleNo.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSingleNo.Location = new System.Drawing.Point(165, 150);
            this.txtSingleNo.Name = "txtSingleNo";
            this.txtSingleNo.Size = new System.Drawing.Size(61, 28);
            this.txtSingleNo.TabIndex = 17;
            // 
            // txtDoubleNo
            // 
            this.txtDoubleNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoubleNo.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoubleNo.Location = new System.Drawing.Point(165, 80);
            this.txtDoubleNo.Name = "txtDoubleNo";
            this.txtDoubleNo.Size = new System.Drawing.Size(61, 28);
            this.txtDoubleNo.TabIndex = 18;
            // 
            // txtSuiteNo
            // 
            this.txtSuiteNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuiteNo.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuiteNo.Location = new System.Drawing.Point(165, 16);
            this.txtSuiteNo.Name = "txtSuiteNo";
            this.txtSuiteNo.Size = new System.Drawing.Size(61, 28);
            this.txtSuiteNo.TabIndex = 16;
            // 
            // lblSingle
            // 
            this.lblSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSingle.AutoSize = true;
            this.lblSingle.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingle.Location = new System.Drawing.Point(54, 155);
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
            this.lblDouble.Location = new System.Drawing.Point(43, 85);
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
            this.lblSuite.Location = new System.Drawing.Point(69, 20);
            this.lblSuite.Name = "lblSuite";
            this.lblSuite.Size = new System.Drawing.Size(65, 22);
            this.lblSuite.TabIndex = 13;
            this.lblSuite.Text = "Suite:";
            // 
            // lblAvailability
            // 
            this.lblAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(7, 200);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(172, 30);
            this.lblAvailability.TabIndex = 12;
            this.lblAvailability.Text = "Availability";
            // 
            // pNavigation
            // 
            this.pNavigation.Controls.Add(this.lblAvailability);
            this.pNavigation.Controls.Add(this.pAvailability);
            this.pNavigation.Location = new System.Drawing.Point(10, 114);
            this.pNavigation.Name = "pNavigation";
            this.pNavigation.Size = new System.Drawing.Size(695, 503);
            this.pNavigation.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1810, 1003);
            this.Controls.Add(this.pNavigation);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCurent);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCabin);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientsView)).EndInit();
            this.pAvailability.ResumeLayout(false);
            this.pAvailability.PerformLayout();
            this.pNavigation.ResumeLayout(false);
            this.pNavigation.PerformLayout();
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
        private System.Windows.Forms.Button btnCabin;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurent;
        private System.Windows.Forms.Panel pAvailability;
        private System.Windows.Forms.TextBox txtSingleNo;
        private System.Windows.Forms.TextBox txtDoubleNo;
        private System.Windows.Forms.TextBox txtSuiteNo;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblSuite;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblLoggedUSer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCHECKIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCHECKOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSERVICES;
        private System.Windows.Forms.Panel pNavigation;
    }
}

