
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
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
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.pFooter.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientsView)).BeginInit();
            this.SuspendLayout();
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.Olive;
            this.pFooter.Controls.Add(this.aFooter);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 867);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1818, 126);
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
            this.aFooter.Location = new System.Drawing.Point(806, 99);
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
            this.pHeader.Controls.Add(this.lblSearch);
            this.pHeader.Controls.Add(this.imgClose);
            this.pHeader.Controls.Add(this.txtSearch);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1818, 114);
            this.pHeader.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Trajan Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(12, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(283, 28);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search guest by name:";
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(1768, 3);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(47, 46);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 0;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(632, 28);
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
            this.lblLogo.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLogo.Location = new System.Drawing.Point(884, 436);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(320, 25);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.dataClientsView.Location = new System.Drawing.Point(0, 643);
            this.dataClientsView.Name = "dataClientsView";
            this.dataClientsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataClientsView.RowHeadersWidth = 51;
            this.dataClientsView.RowTemplate.Height = 24;
            this.dataClientsView.Size = new System.Drawing.Size(1818, 288);
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
            this.clientPAS.HeaderText = "Passport number";
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
            this.btnCabin.BackColor = System.Drawing.Color.Olive;
            this.btnCabin.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabin.ForeColor = System.Drawing.Color.White;
            this.btnCabin.Location = new System.Drawing.Point(12, 155);
            this.btnCabin.Name = "btnCabin";
            this.btnCabin.Size = new System.Drawing.Size(115, 84);
            this.btnCabin.TabIndex = 5;
            this.btnCabin.Text = "Cabins";
            this.btnCabin.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Olive;
            this.btnCheckIn.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(288, 155);
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
            this.btnBookings.Location = new System.Drawing.Point(147, 155);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(115, 84);
            this.btnBookings.TabIndex = 7;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Trajan Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(1703, 127);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(109, 30);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Trajan Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1615, 127);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 30);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1818, 993);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblClock);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCHECKIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCHECKOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSERVICES;
        private System.Windows.Forms.Button btnCabin;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}

