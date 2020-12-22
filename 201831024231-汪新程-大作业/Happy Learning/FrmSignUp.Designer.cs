namespace Happy_Learning
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.cmbIDType = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblRealName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(91, 65);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "用户名：";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(111, 120);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 27);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "密码：";
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblPasswordConfirm.Location = new System.Drawing.Point(88, 175);
            this.lblPasswordConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(112, 27);
            this.lblPasswordConfirm.TabIndex = 2;
            this.lblPasswordConfirm.Text = "确认密码：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 32);
            this.txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(244, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Enabled = false;
            this.txtPasswordConfirm.Location = new System.Drawing.Point(244, 172);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(265, 32);
            this.txtPasswordConfirm.TabIndex = 5;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(249, 9);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(77, 40);
            this.lblSignUp.TabIndex = 6;
            this.lblSignUp.Text = "注册";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(171, 445);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(203, 41);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "确认注册";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(244, 382);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(265, 31);
            this.cmbCity.TabIndex = 17;
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Items.AddRange(new object[] {
            "直辖市",
            "安徽省",
            "福建省",
            "甘肃省",
            "广东省",
            "贵州省",
            "河北省",
            "黑龙江省",
            "河南省",
            "湖北省",
            "湖南省",
            "吉林省",
            "江西省",
            "江苏省",
            "辽宁省",
            "山东省",
            "陕西省",
            "山西省",
            "四川省",
            "云南省",
            "浙江省",
            "青海省",
            "海南省",
            "广西壮族",
            "内蒙古",
            "宁夏回族",
            "西藏",
            "新疆维吾尔",
            "特别行政区",
            "台湾省"});
            this.cmbProvince.Location = new System.Drawing.Point(244, 341);
            this.cmbProvince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(265, 31);
            this.cmbProvince.TabIndex = 16;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
            // 
            // cmbIDType
            // 
            this.cmbIDType.FormattingEnabled = true;
            this.cmbIDType.Items.AddRange(new object[] {
            "身份证",
            "回乡证",
            "护照",
            "学号"});
            this.cmbIDType.Location = new System.Drawing.Point(244, 267);
            this.cmbIDType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIDType.Name = "cmbIDType";
            this.cmbIDType.Size = new System.Drawing.Size(265, 31);
            this.cmbIDType.TabIndex = 15;
            this.cmbIDType.SelectedIndexChanged += new System.EventHandler(this.cmbIDType_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(244, 299);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(265, 32);
            this.txtID.TabIndex = 14;
            // 
            // txtRealName
            // 
            this.txtRealName.Location = new System.Drawing.Point(244, 225);
            this.txtRealName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(265, 32);
            this.txtRealName.TabIndex = 13;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblCity.Location = new System.Drawing.Point(111, 385);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(72, 27);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "城市：";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblProvince.Location = new System.Drawing.Point(111, 344);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(72, 27);
            this.lblProvince.TabIndex = 11;
            this.lblProvince.Text = "省份：";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(88, 304);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(112, 27);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "证件号码：";
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblRealName.Location = new System.Drawing.Point(71, 225);
            this.lblRealName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(152, 27);
            this.lblRealName.TabIndex = 9;
            this.lblRealName.Text = "您的真实姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(88, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "证件类型：";
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.cmbIDType);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtRealName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblRealName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbIDType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRealName;
        private System.Windows.Forms.Label label1;
    }
}