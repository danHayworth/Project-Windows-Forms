
namespace Project
{
    partial class frmAddBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBooking));
            this.txtNotesBooking = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.dateOutBooking = new System.Windows.Forms.DateTimePicker();
            this.dateInBooking = new System.Windows.Forms.DateTimePicker();
            this.txtSurnameBooking = new System.Windows.Forms.TextBox();
            this.txtNameBooking = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneBooking = new System.Windows.Forms.TextBox();
            this.lblPhoneBooking = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotesBooking
            // 
            this.txtNotesBooking.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotesBooking.Location = new System.Drawing.Point(327, 375);
            this.txtNotesBooking.Multiline = true;
            this.txtNotesBooking.Name = "txtNotesBooking";
            this.txtNotesBooking.Size = new System.Drawing.Size(278, 100);
            this.txtNotesBooking.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "Notes";
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Olive;
            this.btnBooking.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(353, 521);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(88, 41);
            this.btnBooking.TabIndex = 31;
            this.btnBooking.Text = "Book";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // dateOutBooking
            // 
            this.dateOutBooking.CalendarFont = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutBooking.Font = new System.Drawing.Font("Trajan Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutBooking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOutBooking.Location = new System.Drawing.Point(327, 313);
            this.dateOutBooking.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateOutBooking.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dateOutBooking.Name = "dateOutBooking";
            this.dateOutBooking.Size = new System.Drawing.Size(278, 25);
            this.dateOutBooking.TabIndex = 30;
            this.dateOutBooking.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            // 
            // dateInBooking
            // 
            this.dateInBooking.CalendarFont = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInBooking.Font = new System.Drawing.Font("Trajan Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInBooking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInBooking.Location = new System.Drawing.Point(327, 255);
            this.dateInBooking.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateInBooking.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dateInBooking.Name = "dateInBooking";
            this.dateInBooking.Size = new System.Drawing.Size(278, 25);
            this.dateInBooking.TabIndex = 29;
            this.dateInBooking.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            // 
            // txtSurnameBooking
            // 
            this.txtSurnameBooking.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnameBooking.Location = new System.Drawing.Point(327, 151);
            this.txtSurnameBooking.Name = "txtSurnameBooking";
            this.txtSurnameBooking.Size = new System.Drawing.Size(278, 28);
            this.txtSurnameBooking.TabIndex = 26;
            // 
            // txtNameBooking
            // 
            this.txtNameBooking.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameBooking.Location = new System.Drawing.Point(327, 93);
            this.txtNameBooking.Name = "txtNameBooking";
            this.txtNameBooking.Size = new System.Drawing.Size(278, 28);
            this.txtNameBooking.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Check Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Check In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // txtPhoneBooking
            // 
            this.txtPhoneBooking.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneBooking.Location = new System.Drawing.Point(327, 200);
            this.txtPhoneBooking.Name = "txtPhoneBooking";
            this.txtPhoneBooking.Size = new System.Drawing.Size(278, 28);
            this.txtPhoneBooking.TabIndex = 35;
            // 
            // lblPhoneBooking
            // 
            this.lblPhoneBooking.AutoSize = true;
            this.lblPhoneBooking.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneBooking.Location = new System.Drawing.Point(141, 204);
            this.lblPhoneBooking.Name = "lblPhoneBooking";
            this.lblPhoneBooking.Size = new System.Drawing.Size(91, 28);
            this.lblPhoneBooking.TabIndex = 34;
            this.lblPhoneBooking.Text = "Phone";
            // 
            // imgClose
            // 
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(773, 12);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(35, 33);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 36;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // frmAddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 714);
            this.Controls.Add(this.imgClose);
            this.Controls.Add(this.txtPhoneBooking);
            this.Controls.Add(this.lblPhoneBooking);
            this.Controls.Add(this.txtNotesBooking);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.dateOutBooking);
            this.Controls.Add(this.dateInBooking);
            this.Controls.Add(this.txtSurnameBooking);
            this.Controls.Add(this.txtNameBooking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBooking";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNotesBooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.DateTimePicker dateOutBooking;
        private System.Windows.Forms.DateTimePicker dateInBooking;
        private System.Windows.Forms.TextBox txtSurnameBooking;
        private System.Windows.Forms.TextBox txtNameBooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneBooking;
        private System.Windows.Forms.Label lblPhoneBooking;
        private System.Windows.Forms.PictureBox imgClose;
    }
}