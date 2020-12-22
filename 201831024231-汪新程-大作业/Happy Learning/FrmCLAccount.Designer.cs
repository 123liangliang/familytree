namespace Happy_Learning
{
    partial class FrmCLAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCLAccount));
            this.btnCLAccount = new System.Windows.Forms.Button();
            this.lblCLAccount = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCLAccount
            // 
            this.btnCLAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCLAccount.FlatAppearance.BorderSize = 0;
            this.btnCLAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCLAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLAccount.ForeColor = System.Drawing.Color.White;
            this.btnCLAccount.Location = new System.Drawing.Point(113, 228);
            this.btnCLAccount.Name = "btnCLAccount";
            this.btnCLAccount.Size = new System.Drawing.Size(203, 41);
            this.btnCLAccount.TabIndex = 31;
            this.btnCLAccount.Text = "确认注销";
            this.btnCLAccount.UseVisualStyleBackColor = false;
            this.btnCLAccount.Click += new System.EventHandler(this.btnCLAccount_Click);
            // 
            // lblCLAccount
            // 
            this.lblCLAccount.AutoSize = true;
            this.lblCLAccount.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCLAccount.Location = new System.Drawing.Point(150, 9);
            this.lblCLAccount.Name = "lblCLAccount";
            this.lblCLAccount.Size = new System.Drawing.Size(137, 40);
            this.lblCLAccount.TabIndex = 30;
            this.lblCLAccount.Text = "注销账号";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 25);
            this.txtPassword.TabIndex = 29;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(168, 72);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(265, 25);
            this.txtUserName.TabIndex = 28;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(72, 127);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 27);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "密码：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(52, 72);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 27);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "用户名：";
            // 
            // FrmCLAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 281);
            this.Controls.Add(this.btnCLAccount);
            this.Controls.Add(this.lblCLAccount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCLAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel the Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCLAccount;
        private System.Windows.Forms.Label lblCLAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
    }
}