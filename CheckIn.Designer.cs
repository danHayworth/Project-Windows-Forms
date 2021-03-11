
namespace Project
{
    partial class frmCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.txtSurnameBook = new System.Windows.Forms.TextBox();
            this.txtIDBook = new System.Windows.Forms.TextBox();
            this.dateInBook = new System.Windows.Forms.DateTimePicker();
            this.dateOutBook = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotesBook = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.txtPhoneBook = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtIdType = new System.Windows.Forms.GroupBox();
            this.lblCabinNumber = new System.Windows.Forms.Label();
            this.txtCabinNumber = new System.Windows.Forms.ComboBox();
            this.txtCabinBook = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.txtIdType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Check Out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cabin type";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameBook.Location = new System.Drawing.Point(300, 58);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(278, 28);
            this.txtNameBook.TabIndex = 6;
            this.txtNameBook.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameBook_Validating);
            // 
            // txtSurnameBook
            // 
            this.txtSurnameBook.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnameBook.Location = new System.Drawing.Point(300, 105);
            this.txtSurnameBook.Name = "txtSurnameBook";
            this.txtSurnameBook.Size = new System.Drawing.Size(278, 28);
            this.txtSurnameBook.TabIndex = 7;
            this.txtSurnameBook.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurnameBook_Validating);
            // 
            // txtIDBook
            // 
            this.txtIDBook.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBook.Location = new System.Drawing.Point(300, 230);
            this.txtIDBook.Name = "txtIDBook";
            this.txtIDBook.Size = new System.Drawing.Size(278, 28);
            this.txtIDBook.TabIndex = 8;
            this.txtIDBook.Validating += new System.ComponentModel.CancelEventHandler(this.txtIDBook_Validating);
            // 
            // dateInBook
            // 
            this.dateInBook.CalendarFont = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInBook.Font = new System.Drawing.Font("Trajan Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInBook.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInBook.Location = new System.Drawing.Point(300, 371);
            this.dateInBook.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateInBook.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dateInBook.Name = "dateInBook";
            this.dateInBook.Size = new System.Drawing.Size(278, 25);
            this.dateInBook.TabIndex = 10;
            this.dateInBook.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dateInBook.Validating += new System.ComponentModel.CancelEventHandler(this.dateInBook_Validating);
            // 
            // dateOutBook
            // 
            this.dateOutBook.CalendarFont = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutBook.Font = new System.Drawing.Font("Trajan Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutBook.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOutBook.Location = new System.Drawing.Point(300, 417);
            this.dateOutBook.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateOutBook.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dateOutBook.Name = "dateOutBook";
            this.dateOutBook.Size = new System.Drawing.Size(278, 25);
            this.dateOutBook.TabIndex = 11;
            this.dateOutBook.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dateOutBook.Validating += new System.ComponentModel.CancelEventHandler(this.dateOutBook_Validating);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Olive;
            this.btnBook.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(321, 584);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(88, 41);
            this.btnBook.TabIndex = 12;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Notes";
            // 
            // txtNotesBook
            // 
            this.txtNotesBook.CausesValidation = false;
            this.txtNotesBook.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotesBook.Location = new System.Drawing.Point(300, 467);
            this.txtNotesBook.Multiline = true;
            this.txtNotesBook.Name = "txtNotesBook";
            this.txtNotesBook.Size = new System.Drawing.Size(278, 100);
            this.txtNotesBook.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Trajan Pro", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 23);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Driving Licence";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Trajan Pro", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(190, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 23);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Passport";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // imgClose
            // 
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(717, 12);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(35, 33);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 19;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // txtPhoneBook
            // 
            this.txtPhoneBook.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneBook.Location = new System.Drawing.Point(300, 149);
            this.txtPhoneBook.Name = "txtPhoneBook";
            this.txtPhoneBook.Size = new System.Drawing.Size(278, 28);
            this.txtPhoneBook.TabIndex = 21;
            this.txtPhoneBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneBook_KeyPress);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(151, 152);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 22);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Phone";
            // 
            // txtIdType
            // 
            this.txtIdType.Controls.Add(this.radioButton1);
            this.txtIdType.Controls.Add(this.radioButton2);
            this.txtIdType.Location = new System.Drawing.Point(291, 183);
            this.txtIdType.Name = "txtIdType";
            this.txtIdType.Size = new System.Drawing.Size(299, 41);
            this.txtIdType.TabIndex = 22;
            this.txtIdType.TabStop = false;
            // 
            // lblCabinNumber
            // 
            this.lblCabinNumber.AutoSize = true;
            this.lblCabinNumber.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinNumber.Location = new System.Drawing.Point(151, 330);
            this.lblCabinNumber.Name = "lblCabinNumber";
            this.lblCabinNumber.Size = new System.Drawing.Size(147, 22);
            this.lblCabinNumber.TabIndex = 23;
            this.lblCabinNumber.Text = "Cabin number";
            // 
            // txtCabinNumber
            // 
            this.txtCabinNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCabinNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtCabinNumber.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabinNumber.FormattingEnabled = true;
            this.txtCabinNumber.Location = new System.Drawing.Point(300, 326);
            this.txtCabinNumber.Name = "txtCabinNumber";
            this.txtCabinNumber.Size = new System.Drawing.Size(278, 30);
            this.txtCabinNumber.TabIndex = 24;
            // 
            // txtCabinBook
            // 
            this.txtCabinBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtCabinBook.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabinBook.FormattingEnabled = true;
            this.txtCabinBook.Items.AddRange(new object[] {
            "Suite",
            "Double",
            "Single"});
            this.txtCabinBook.Location = new System.Drawing.Point(300, 281);
            this.txtCabinBook.Name = "txtCabinBook";
            this.txtCabinBook.Size = new System.Drawing.Size(278, 30);
            this.txtCabinBook.TabIndex = 25;
            this.txtCabinBook.Validating += new System.ComponentModel.CancelEventHandler(this.txtCabinBook_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 741);
            this.Controls.Add(this.txtCabinBook);
            this.Controls.Add(this.txtCabinNumber);
            this.Controls.Add(this.lblCabinNumber);
            this.Controls.Add(this.txtIdType);
            this.Controls.Add(this.txtPhoneBook);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.imgClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNotesBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dateOutBook);
            this.Controls.Add(this.dateInBook);
            this.Controls.Add(this.txtIDBook);
            this.Controls.Add(this.txtSurnameBook);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.txtIdType.ResumeLayout(false);
            this.txtIdType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.TextBox txtSurnameBook;
        private System.Windows.Forms.TextBox txtIDBook;
        private System.Windows.Forms.DateTimePicker dateInBook;
        private System.Windows.Forms.DateTimePicker dateOutBook;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotesBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.TextBox txtPhoneBook;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox txtIdType;
        private System.Windows.Forms.Label lblCabinNumber;
        private System.Windows.Forms.ComboBox txtCabinNumber;
        private System.Windows.Forms.ComboBox txtCabinBook;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}