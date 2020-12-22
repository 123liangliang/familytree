namespace Happy_Learning
{
    partial class FrmFindPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindPassword));
            this.lblRealName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbIDType = new System.Windows.Forms.ComboBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFindPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblRealName.Location = new System.Drawing.Point(59, 157);
            this.lblRealName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(132, 27);
            this.lblRealName.TabIndex = 0;
            this.lblRealName.Text = "您的真实姓名";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(59, 247);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(92, 27);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "证件号码";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblProvince.Location = new System.Drawing.Point(59, 364);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 27);
            this.lblProvince.TabIndex = 2;
            this.lblProvince.Text = "省份";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblCity.Location = new System.Drawing.Point(59, 451);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(52, 27);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "城市";
            // 
            // txtRealName
            // 
            this.txtRealName.Location = new System.Drawing.Point(64, 189);
            this.txtRealName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(296, 34);
            this.txtRealName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(64, 315);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(296, 34);
            this.txtID.TabIndex = 5;
            // 
            // cmbIDType
            // 
            this.cmbIDType.FormattingEnabled = true;
            this.cmbIDType.Items.AddRange(new object[] {
            "身份证",
            "回乡证",
            "护照",
            "学号"});
            this.cmbIDType.Location = new System.Drawing.Point(64, 279);
            this.cmbIDType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIDType.Name = "cmbIDType";
            this.cmbIDType.Size = new System.Drawing.Size(296, 35);
            this.cmbIDType.TabIndex = 6;
            this.cmbIDType.SelectedIndexChanged += new System.EventHandler(this.cmbIDType_SelectedIndexChanged);
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Items.AddRange(new object[] {
            "四川省",
            "湖北省"});
            this.cmbProvince.Location = new System.Drawing.Point(64, 396);
            this.cmbProvince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(296, 35);
            this.cmbProvince.TabIndex = 7;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(64, 483);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(296, 35);
            this.cmbCity.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(139, 552);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 41);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "提交申请";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 34);
            this.txtName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "用户名";
            // 
            // lblFindPassword
            // 
            this.lblFindPassword.AutoSize = true;
            this.lblFindPassword.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFindPassword.Location = new System.Drawing.Point(129, 24);
            this.lblFindPassword.Name = "lblFindPassword";
            this.lblFindPassword.Size = new System.Drawing.Size(137, 40);
            this.lblFindPassword.TabIndex = 12;
            this.lblFindPassword.Text = "找回密码";
            // 
            // FrmFindPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 607);
            this.Controls.Add(this.lblFindPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.cmbIDType);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtRealName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblRealName);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFindPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRealName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbIDType;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFindPassword;
    }
}