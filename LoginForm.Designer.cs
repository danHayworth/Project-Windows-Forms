
namespace Project
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.imgClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Adobe Caslon Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(213, 90);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(123, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(83, 252);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 34);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(83, 336);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 34);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(206, 249);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(225, 31);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 333);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 31);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(220, 445);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 37);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imgClose
            // 
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(488, 12);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(35, 33);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 6;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(535, 614);
            this.Controls.Add(this.imgClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox imgClose;
    }
}