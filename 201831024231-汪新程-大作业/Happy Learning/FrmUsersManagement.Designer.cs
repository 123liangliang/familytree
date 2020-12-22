namespace Happy_Learning
{
    partial class FrmUsersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersManagement));
            this.tabPageUserList = new System.Windows.Forms.TabPage();
            this.myDataGrid = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPageChangeUserInfo = new System.Windows.Forms.TabPage();
            this.cmbSProvince = new System.Windows.Forms.ComboBox();
            this.cmbSIDType = new System.Windows.Forms.ComboBox();
            this.cmbSCity = new System.Windows.Forms.ComboBox();
            this.txtSAdmin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtSRealName = new System.Windows.Forms.TextBox();
            this.txtSPwd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQueName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageAddUsers = new System.Windows.Forms.TabPage();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.cmbIDType = new System.Windows.Forms.ComboBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtr = new System.Windows.Forms.TabControl();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabPageUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).BeginInit();
            this.tabPageChangeUserInfo.SuspendLayout();
            this.tabPageAddUsers.SuspendLayout();
            this.tabCtr.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageUserList
            // 
            this.tabPageUserList.BackColor = System.Drawing.Color.White;
            this.tabPageUserList.Controls.Add(this.btnDel);
            this.tabPageUserList.Controls.Add(this.btnUpdate);
            this.tabPageUserList.Controls.Add(this.myDataGrid);
            this.tabPageUserList.Controls.Add(this.btnRefresh);
            this.tabPageUserList.Controls.Add(this.lblTitle);
            this.tabPageUserList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageUserList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.tabPageUserList.Location = new System.Drawing.Point(4, 25);
            this.tabPageUserList.Name = "tabPageUserList";
            this.tabPageUserList.Size = new System.Drawing.Size(892, 473);
            this.tabPageUserList.TabIndex = 3;
            this.tabPageUserList.Text = "用户表查询";
            // 
            // myDataGrid
            // 
            this.myDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.myDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.UserPwd,
            this.RealName,
            this.IDType,
            this.ID,
            this.Province,
            this.City,
            this.Admin});
            this.myDataGrid.Location = new System.Drawing.Point(3, 107);
            this.myDataGrid.Name = "myDataGrid";
            this.myDataGrid.RowTemplate.Height = 27;
            this.myDataGrid.Size = new System.Drawing.Size(873, 339);
            this.myDataGrid.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            // 
            // UserPwd
            // 
            this.UserPwd.DataPropertyName = "UserPwd";
            this.UserPwd.HeaderText = "密码";
            this.UserPwd.Name = "UserPwd";
            // 
            // RealName
            // 
            this.RealName.DataPropertyName = "RealName";
            this.RealName.HeaderText = "真实姓名";
            this.RealName.Name = "RealName";
            // 
            // IDType
            // 
            this.IDType.DataPropertyName = "IDType";
            this.IDType.HeaderText = "证件类型";
            this.IDType.Name = "IDType";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "证件号码";
            this.ID.Name = "ID";
            // 
            // Province
            // 
            this.Province.DataPropertyName = "Province";
            this.Province.HeaderText = "省份";
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "城市";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "管理员";
            this.Admin.Name = "Admin";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(60, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新用户表";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(388, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Users List";
            // 
            // tabPageChangeUserInfo
            // 
            this.tabPageChangeUserInfo.BackColor = System.Drawing.Color.White;
            this.tabPageChangeUserInfo.Controls.Add(this.cmbSProvince);
            this.tabPageChangeUserInfo.Controls.Add(this.cmbSIDType);
            this.tabPageChangeUserInfo.Controls.Add(this.cmbSCity);
            this.tabPageChangeUserInfo.Controls.Add(this.txtSAdmin);
            this.tabPageChangeUserInfo.Controls.Add(this.label10);
            this.tabPageChangeUserInfo.Controls.Add(this.label11);
            this.tabPageChangeUserInfo.Controls.Add(this.txtSName);
            this.tabPageChangeUserInfo.Controls.Add(this.txtSID);
            this.tabPageChangeUserInfo.Controls.Add(this.txtSRealName);
            this.tabPageChangeUserInfo.Controls.Add(this.txtSPwd);
            this.tabPageChangeUserInfo.Controls.Add(this.label12);
            this.tabPageChangeUserInfo.Controls.Add(this.label13);
            this.tabPageChangeUserInfo.Controls.Add(this.label14);
            this.tabPageChangeUserInfo.Controls.Add(this.label15);
            this.tabPageChangeUserInfo.Controls.Add(this.label16);
            this.tabPageChangeUserInfo.Controls.Add(this.label18);
            this.tabPageChangeUserInfo.Controls.Add(this.btnSubmit);
            this.tabPageChangeUserInfo.Controls.Add(this.btnDelete);
            this.tabPageChangeUserInfo.Controls.Add(this.btnQuery);
            this.tabPageChangeUserInfo.Controls.Add(this.txtQueName);
            this.tabPageChangeUserInfo.Controls.Add(this.label9);
            this.tabPageChangeUserInfo.Controls.Add(this.label8);
            this.tabPageChangeUserInfo.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageChangeUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.tabPageChangeUserInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageChangeUserInfo.Name = "tabPageChangeUserInfo";
            this.tabPageChangeUserInfo.Size = new System.Drawing.Size(892, 473);
            this.tabPageChangeUserInfo.TabIndex = 2;
            this.tabPageChangeUserInfo.Text = "修改用户信息";
            // 
            // cmbSProvince
            // 
            this.cmbSProvince.FormattingEnabled = true;
            this.cmbSProvince.Items.AddRange(new object[] {
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
            this.cmbSProvince.Location = new System.Drawing.Point(607, 251);
            this.cmbSProvince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSProvince.Name = "cmbSProvince";
            this.cmbSProvince.Size = new System.Drawing.Size(265, 38);
            this.cmbSProvince.TabIndex = 46;
            this.cmbSProvince.SelectedIndexChanged += new System.EventHandler(this.cmbSProvince_SelectedIndexChanged);
            // 
            // cmbSIDType
            // 
            this.cmbSIDType.FormattingEnabled = true;
            this.cmbSIDType.Items.AddRange(new object[] {
            "身份证",
            "回乡证",
            "护照",
            "学号"});
            this.cmbSIDType.Location = new System.Drawing.Point(607, 180);
            this.cmbSIDType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSIDType.Name = "cmbSIDType";
            this.cmbSIDType.Size = new System.Drawing.Size(265, 38);
            this.cmbSIDType.TabIndex = 45;
            // 
            // cmbSCity
            // 
            this.cmbSCity.FormattingEnabled = true;
            this.cmbSCity.Location = new System.Drawing.Point(158, 309);
            this.cmbSCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSCity.Name = "cmbSCity";
            this.cmbSCity.Size = new System.Drawing.Size(265, 38);
            this.cmbSCity.TabIndex = 44;
            // 
            // txtSAdmin
            // 
            this.txtSAdmin.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSAdmin.Location = new System.Drawing.Point(607, 319);
            this.txtSAdmin.Name = "txtSAdmin";
            this.txtSAdmin.Size = new System.Drawing.Size(265, 38);
            this.txtSAdmin.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(488, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 31);
            this.label10.TabIndex = 41;
            this.label10.Text = "管理员：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(37, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 31);
            this.label11.TabIndex = 40;
            this.label11.Text = "城市：";
            // 
            // txtSName
            // 
            this.txtSName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSName.Location = new System.Drawing.Point(158, 112);
            this.txtSName.Name = "txtSName";
            this.txtSName.ReadOnly = true;
            this.txtSName.Size = new System.Drawing.Size(265, 38);
            this.txtSName.TabIndex = 37;
            // 
            // txtSID
            // 
            this.txtSID.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSID.Location = new System.Drawing.Point(158, 248);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(265, 38);
            this.txtSID.TabIndex = 36;
            // 
            // txtSRealName
            // 
            this.txtSRealName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSRealName.Location = new System.Drawing.Point(158, 180);
            this.txtSRealName.Name = "txtSRealName";
            this.txtSRealName.Size = new System.Drawing.Size(265, 38);
            this.txtSRealName.TabIndex = 35;
            // 
            // txtSPwd
            // 
            this.txtSPwd.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSPwd.Location = new System.Drawing.Point(607, 115);
            this.txtSPwd.Name = "txtSPwd";
            this.txtSPwd.Size = new System.Drawing.Size(265, 38);
            this.txtSPwd.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(488, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 31);
            this.label12.TabIndex = 33;
            this.label12.Text = "省份：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(488, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 31);
            this.label13.TabIndex = 32;
            this.label13.Text = "证件类型：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(39, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 31);
            this.label14.TabIndex = 31;
            this.label14.Text = "用户名：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(37, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 31);
            this.label15.TabIndex = 30;
            this.label15.Text = "证件号码：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(37, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 31);
            this.label16.TabIndex = 29;
            this.label16.Text = "真实姓名：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(488, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 31);
            this.label18.TabIndex = 28;
            this.label18.Text = "密码：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(503, 399);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 34);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "提交修改";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(286, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 34);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(607, 62);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(105, 34);
            this.btnQuery.TabIndex = 25;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQueName
            // 
            this.txtQueName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueName.Location = new System.Drawing.Point(413, 62);
            this.txtQueName.Name = "txtQueName";
            this.txtQueName.Size = new System.Drawing.Size(166, 38);
            this.txtQueName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "输入要查询的用户名：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "在数据库表中删除或者修改记录";
            // 
            // tabPageAddUsers
            // 
            this.tabPageAddUsers.BackColor = System.Drawing.Color.White;
            this.tabPageAddUsers.Controls.Add(this.cmbCity);
            this.tabPageAddUsers.Controls.Add(this.cmbProvince);
            this.tabPageAddUsers.Controls.Add(this.cmbIDType);
            this.tabPageAddUsers.Controls.Add(this.txtAdmin);
            this.tabPageAddUsers.Controls.Add(this.lblAdmin);
            this.tabPageAddUsers.Controls.Add(this.label17);
            this.tabPageAddUsers.Controls.Add(this.label7);
            this.tabPageAddUsers.Controls.Add(this.btnInsert);
            this.tabPageAddUsers.Controls.Add(this.txtName);
            this.tabPageAddUsers.Controls.Add(this.txtID);
            this.tabPageAddUsers.Controls.Add(this.txtRealName);
            this.tabPageAddUsers.Controls.Add(this.txtPwd);
            this.tabPageAddUsers.Controls.Add(this.label6);
            this.tabPageAddUsers.Controls.Add(this.label5);
            this.tabPageAddUsers.Controls.Add(this.label4);
            this.tabPageAddUsers.Controls.Add(this.label3);
            this.tabPageAddUsers.Controls.Add(this.label2);
            this.tabPageAddUsers.Controls.Add(this.label1);
            this.tabPageAddUsers.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageAddUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.tabPageAddUsers.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddUsers.Name = "tabPageAddUsers";
            this.tabPageAddUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUsers.Size = new System.Drawing.Size(892, 473);
            this.tabPageAddUsers.TabIndex = 1;
            this.tabPageAddUsers.Text = "添加用户";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(134, 318);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(265, 28);
            this.cmbCity.TabIndex = 20;
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
            this.cmbProvince.Location = new System.Drawing.Point(597, 246);
            this.cmbProvince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(265, 28);
            this.cmbProvince.TabIndex = 19;
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
            this.cmbIDType.Location = new System.Drawing.Point(597, 175);
            this.cmbIDType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIDType.Name = "cmbIDType";
            this.cmbIDType.Size = new System.Drawing.Size(265, 28);
            this.cmbIDType.TabIndex = 18;
            this.cmbIDType.SelectedIndexChanged += new System.EventHandler(this.cmbIDType_SelectedIndexChanged);
            // 
            // txtAdmin
            // 
            this.txtAdmin.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdmin.Location = new System.Drawing.Point(597, 306);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(265, 38);
            this.txtAdmin.TabIndex = 17;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdmin.Location = new System.Drawing.Point(478, 306);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(110, 31);
            this.lblAdmin.TabIndex = 15;
            this.lblAdmin.Text = "管理员：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(13, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 31);
            this.label17.TabIndex = 14;
            this.label17.Text = "城市：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(387, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "添加用户";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(355, 393);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(195, 50);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "添加用户";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(134, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 38);
            this.txtName.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtID.Location = new System.Drawing.Point(134, 245);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(265, 38);
            this.txtID.TabIndex = 8;
            // 
            // txtRealName
            // 
            this.txtRealName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRealName.Location = new System.Drawing.Point(134, 177);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(265, 38);
            this.txtRealName.TabIndex = 7;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(599, 102);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(263, 38);
            this.txtPwd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(478, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "省份：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(478, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "证件类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "证件号码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "真实姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(478, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "密码：";
            // 
            // tabCtr
            // 
            this.tabCtr.Controls.Add(this.tabPageAddUsers);
            this.tabCtr.Controls.Add(this.tabPageChangeUserInfo);
            this.tabCtr.Controls.Add(this.tabPageUserList);
            this.tabCtr.Location = new System.Drawing.Point(-2, -3);
            this.tabCtr.Name = "tabCtr";
            this.tabCtr.SelectedIndex = 0;
            this.tabCtr.Size = new System.Drawing.Size(900, 502);
            this.tabCtr.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(747, 67);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(121, 34);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除当前行";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(620, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 496);
            this.Controls.Add(this.tabCtr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersManagement";
            this.Load += new System.EventHandler(this.FrmUsersManagement_Load);
            this.tabPageUserList.ResumeLayout(false);
            this.tabPageUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).EndInit();
            this.tabPageChangeUserInfo.ResumeLayout(false);
            this.tabPageChangeUserInfo.PerformLayout();
            this.tabPageAddUsers.ResumeLayout(false);
            this.tabPageAddUsers.PerformLayout();
            this.tabCtr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageUserList;
        private System.Windows.Forms.DataGridView myDataGrid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tabPageChangeUserInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQueName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageAddUsers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCtr;
        private System.Windows.Forms.TextBox txtSAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.TextBox txtSRealName;
        private System.Windows.Forms.TextBox txtSPwd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbIDType;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbSProvince;
        private System.Windows.Forms.ComboBox cmbSIDType;
        private System.Windows.Forms.ComboBox cmbSCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;

    }
}