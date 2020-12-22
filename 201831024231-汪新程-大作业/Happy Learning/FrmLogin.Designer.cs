namespace Happy_Learning
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHappyLearning = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picLogoSmall = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUseName = new System.Windows.Forms.Label();
            this.lblForgotInfor = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblCLAccount = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.picLogoBig = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBig)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlTop.Controls.Add(this.lblHappyLearning);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.picLogoSmall);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 56);
            this.pnlTop.TabIndex = 15;
            // 
            // lblHappyLearning
            // 
            this.lblHappyLearning.AutoSize = true;
            this.lblHappyLearning.ForeColor = System.Drawing.Color.White;
            this.lblHappyLearning.Location = new System.Drawing.Point(85, 17);
            this.lblHappyLearning.Name = "lblHappyLearning";
            this.lblHappyLearning.Size = new System.Drawing.Size(113, 23);
            this.lblHappyLearning.TabIndex = 9;
            this.lblHappyLearning.Text = "APP STORE";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Happy_Learning.Properties.Resources.电源;
            this.btnClose.Location = new System.Drawing.Point(1109, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(91, 56);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLogoSmall
            // 
            this.picLogoSmall.Image = global::Happy_Learning.Properties.Resources.学习64;
            this.picLogoSmall.Location = new System.Drawing.Point(0, 0);
            this.picLogoSmall.Name = "picLogoSmall";
            this.picLogoSmall.Size = new System.Drawing.Size(50, 50);
            this.picLogoSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoSmall.TabIndex = 0;
            this.picLogoSmall.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(406, 587);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(389, 32);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(405, 529);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(389, 32);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(406, 438);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(389, 36);
            this.txtUserName.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblPassword.Location = new System.Drawing.Point(402, 503);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 23);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // lblUseName
            // 
            this.lblUseName.AutoSize = true;
            this.lblUseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblUseName.Location = new System.Drawing.Point(402, 412);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(122, 23);
            this.lblUseName.TabIndex = 10;
            this.lblUseName.Text = "User Name:";
            // 
            // lblForgotInfor
            // 
            this.lblForgotInfor.AutoSize = true;
            this.lblForgotInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblForgotInfor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblForgotInfor.Location = new System.Drawing.Point(657, 564);
            this.lblForgotInfor.Name = "lblForgotInfor";
            this.lblForgotInfor.Size = new System.Drawing.Size(181, 20);
            this.lblForgotInfor.TabIndex = 17;
            this.lblForgotInfor.Text = "Forgot Your Password？";
            this.lblForgotInfor.Click += new System.EventHandler(this.lblForgotInfor_Click);
            this.lblForgotInfor.MouseLeave += new System.EventHandler(this.lblForgotInfor_MouseLeave);
            this.lblForgotInfor.MouseHover += new System.EventHandler(this.lblForgotInfor_MouseHover);
            this.lblForgotInfor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblForgotInfor_MouseMove);
            this.lblForgotInfor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblForgotInfor_MouseUp);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblSignUp.Location = new System.Drawing.Point(12, 668);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(81, 23);
            this.lblSignUp.TabIndex = 18;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdministrator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblAdministrator.Location = new System.Drawing.Point(402, 622);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(104, 20);
            this.lblAdministrator.TabIndex = 19;
            this.lblAdministrator.Text = "Administrator";
            this.lblAdministrator.Click += new System.EventHandler(this.lblAdministrator_Click);
            // 
            // lblCLAccount
            // 
            this.lblCLAccount.AutoSize = true;
            this.lblCLAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCLAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCLAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblCLAccount.Location = new System.Drawing.Point(667, 622);
            this.lblCLAccount.Name = "lblCLAccount";
            this.lblCLAccount.Size = new System.Drawing.Size(166, 20);
            this.lblCLAccount.TabIndex = 20;
            this.lblCLAccount.Text = "Cancel Your Account";
            this.lblCLAccount.Click += new System.EventHandler(this.lblCLAccount_Click);
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChangePassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblChangePassword.Location = new System.Drawing.Point(402, 564);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(143, 20);
            this.lblChangePassword.TabIndex = 21;
            this.lblChangePassword.Text = "Change Password";
            this.lblChangePassword.Click += new System.EventHandler(this.lblChangePassword_Click);
            // 
            // picLogoBig
            // 
            this.picLogoBig.Image = global::Happy_Learning.Properties.Resources.学习128;
            this.picLogoBig.Location = new System.Drawing.Point(543, 270);
            this.picLogoBig.Name = "picLogoBig";
            this.picLogoBig.Size = new System.Drawing.Size(128, 128);
            this.picLogoBig.TabIndex = 16;
            this.picLogoBig.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.lblCLAccount);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblForgotInfor);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUseName);
            this.Controls.Add(this.picLogoBig);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHappyLearning;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picLogoSmall;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUseName;
        private System.Windows.Forms.PictureBox picLogoBig;
        private System.Windows.Forms.Label lblForgotInfor;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblCLAccount;
        private System.Windows.Forms.Label lblChangePassword;

    }
}

