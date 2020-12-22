namespace Happy_Learning
{
    partial class FrmWarnig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWarnig));
            this.btnYES = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYES
            // 
            this.btnYES.FlatAppearance.BorderSize = 0;
            this.btnYES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btnYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYES.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnYES.Location = new System.Drawing.Point(70, 84);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(65, 28);
            this.btnYES.TabIndex = 1;
            this.btnYES.Text = "确定";
            this.btnYES.UseVisualStyleBackColor = true;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSignUp.Location = new System.Drawing.Point(172, 84);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(65, 28);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "去注册";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWarning.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(102, 45);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(114, 20);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "该用户不存在！";
            // 
            // FrmWarnig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 171);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnYES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWarnig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warnig!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblWarning;
    }
}