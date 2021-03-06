﻿
namespace Project
{
    partial class frmCabinsCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCabinsCheck));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtCheckOut = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.pFooter = new System.Windows.Forms.Panel();
            this.aFooter = new System.Windows.Forms.LinkLabel();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pInvoice = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnShowInv = new System.Windows.Forms.Button();
            this.btnEmailInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.txtCabinNumber = new System.Windows.Forms.Label();
            this.lblCabinN = new System.Windows.Forms.Label();
            this.txtCabinType = new System.Windows.Forms.Label();
            this.lblCabinType = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.btnSavePdf = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.pHeader.SuspendLayout();
            this.pInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(73, 220);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(242, 220);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.AutoSize = true;
            this.txtCheckOut.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOut.Location = new System.Drawing.Point(242, 382);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(0, 25);
            this.txtCheckOut.TabIndex = 5;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(73, 382);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(149, 25);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check Out: ";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.AutoSize = true;
            this.txtCheckIn.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckIn.Location = new System.Drawing.Point(242, 344);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(0, 25);
            this.txtCheckIn.TabIndex = 7;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(73, 344);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(128, 25);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check In: ";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(242, 304);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(0, 25);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(73, 304);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 25);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone: ";
            // 
            // txtSurname
            // 
            this.txtSurname.AutoSize = true;
            this.txtSurname.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(242, 263);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(0, 25);
            this.txtSurname.TabIndex = 11;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(73, 263);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(124, 25);
            this.lblSurname.TabIndex = 10;
            this.lblSurname.Text = "Surname: ";
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.Olive;
            this.pFooter.Controls.Add(this.aFooter);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 965);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1913, 57);
            this.pFooter.TabIndex = 12;
            // 
            // aFooter
            // 
            this.aFooter.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.aFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aFooter.AutoSize = true;
            this.aFooter.Font = new System.Drawing.Font("Trajan Pro", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aFooter.LinkColor = System.Drawing.Color.Snow;
            this.aFooter.Location = new System.Drawing.Point(769, 20);
            this.aFooter.Name = "aFooter";
            this.aFooter.Size = new System.Drawing.Size(458, 18);
            this.aFooter.TabIndex = 1;
            this.aFooter.TabStop = true;
            this.aFooter.Text = "Cabin Management System developed by Dan Hayworth";
            this.aFooter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aFooter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aFooter_LinkClicked);
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(1863, 3);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(47, 46);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 0;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Olive;
            this.pHeader.Controls.Add(this.imgClose);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1913, 62);
            this.pHeader.TabIndex = 13;
            // 
            // pInvoice
            // 
            this.pInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pInvoice.BackColor = System.Drawing.Color.SaddleBrown;
            this.pInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pInvoice.Controls.Add(this.richTextBox);
            this.pInvoice.Location = new System.Drawing.Point(680, 68);
            this.pInvoice.Name = "pInvoice";
            this.pInvoice.Size = new System.Drawing.Size(1229, 897);
            this.pInvoice.TabIndex = 14;
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(3, 3);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1216, 886);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // btnShowInv
            // 
            this.btnShowInv.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnShowInv.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInv.ForeColor = System.Drawing.Color.White;
            this.btnShowInv.Location = new System.Drawing.Point(78, 622);
            this.btnShowInv.Name = "btnShowInv";
            this.btnShowInv.Size = new System.Drawing.Size(243, 42);
            this.btnShowInv.TabIndex = 15;
            this.btnShowInv.Text = "Generate Invoice";
            this.btnShowInv.UseVisualStyleBackColor = false;
            this.btnShowInv.Click += new System.EventHandler(this.btnShowInv_Click);
            // 
            // btnEmailInvoice
            // 
            this.btnEmailInvoice.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEmailInvoice.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailInvoice.ForeColor = System.Drawing.Color.White;
            this.btnEmailInvoice.Location = new System.Drawing.Point(78, 761);
            this.btnEmailInvoice.Name = "btnEmailInvoice";
            this.btnEmailInvoice.Size = new System.Drawing.Size(243, 42);
            this.btnEmailInvoice.TabIndex = 16;
            this.btnEmailInvoice.Text = "Email Invoice";
            this.btnEmailInvoice.UseVisualStyleBackColor = false;
            this.btnEmailInvoice.Click += new System.EventHandler(this.btnEmailInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Location = new System.Drawing.Point(78, 839);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(243, 42);
            this.btnPrintInvoice.TabIndex = 17;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // txtCabinNumber
            // 
            this.txtCabinNumber.AutoSize = true;
            this.txtCabinNumber.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabinNumber.Location = new System.Drawing.Point(263, 122);
            this.txtCabinNumber.Name = "txtCabinNumber";
            this.txtCabinNumber.Size = new System.Drawing.Size(0, 38);
            this.txtCabinNumber.TabIndex = 19;
            // 
            // lblCabinN
            // 
            this.lblCabinN.AutoSize = true;
            this.lblCabinN.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinN.Location = new System.Drawing.Point(71, 122);
            this.lblCabinN.Name = "lblCabinN";
            this.lblCabinN.Size = new System.Drawing.Size(116, 38);
            this.lblCabinN.TabIndex = 18;
            this.lblCabinN.Text = "Cabin";
            // 
            // txtCabinType
            // 
            this.txtCabinType.AutoSize = true;
            this.txtCabinType.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabinType.Location = new System.Drawing.Point(242, 473);
            this.txtCabinType.Name = "txtCabinType";
            this.txtCabinType.Size = new System.Drawing.Size(0, 25);
            this.txtCabinType.TabIndex = 21;
            // 
            // lblCabinType
            // 
            this.lblCabinType.AutoSize = true;
            this.lblCabinType.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinType.Location = new System.Drawing.Point(73, 473);
            this.lblCabinType.Name = "lblCabinType";
            this.lblCabinType.Size = new System.Drawing.Size(145, 25);
            this.lblCabinType.TabIndex = 20;
            this.lblCabinType.Text = "Cabin type: ";
            // 
            // txtNights
            // 
            this.txtNights.AutoSize = true;
            this.txtNights.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(242, 427);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(0, 25);
            this.txtNights.TabIndex = 23;
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(73, 427);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(107, 25);
            this.lblNights.TabIndex = 22;
            this.lblNights.Text = "Nights: ";
            // 
            // btnSavePdf
            // 
            this.btnSavePdf.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSavePdf.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePdf.ForeColor = System.Drawing.Color.White;
            this.btnSavePdf.Location = new System.Drawing.Point(78, 917);
            this.btnSavePdf.Name = "btnSavePdf";
            this.btnSavePdf.Size = new System.Drawing.Size(243, 42);
            this.btnSavePdf.TabIndex = 24;
            this.btnSavePdf.Text = "Save as ";
            this.btnSavePdf.UseVisualStyleBackColor = false;
            this.btnSavePdf.Click += new System.EventHandler(this.btnSavePdf_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCheckOut.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(78, 688);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(243, 42);
            this.btnCheckOut.TabIndex = 25;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // frmCabinsCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1022);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnSavePdf);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.txtCabinType);
            this.Controls.Add(this.lblCabinType);
            this.Controls.Add(this.txtCabinNumber);
            this.Controls.Add(this.lblCabinN);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnEmailInvoice);
            this.Controls.Add(this.btnShowInv);
            this.Controls.Add(this.pInvoice);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCabinsCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CabinsCheck";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCabinsCheck_Load);
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pInvoice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtCheckOut;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label txtCheckIn;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.LinkLabel aFooter;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pInvoice;
        private System.Windows.Forms.Button btnShowInv;
        private System.Windows.Forms.Button btnEmailInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label txtCabinNumber;
        private System.Windows.Forms.Label lblCabinN;
        private System.Windows.Forms.Label txtCabinType;
        private System.Windows.Forms.Label lblCabinType;
        private System.Windows.Forms.Label txtNights;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Button btnSavePdf;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnCheckOut;
    }
}