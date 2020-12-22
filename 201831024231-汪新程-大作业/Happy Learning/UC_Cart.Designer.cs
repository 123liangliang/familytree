namespace Happy_Learning
{
    partial class UC_Cart
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBBL = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblApps = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.grbOS = new System.Windows.Forms.GroupBox();
            this.rdoMacOS = new System.Windows.Forms.RadioButton();
            this.rdoAndroid = new System.Windows.Forms.RadioButton();
            this.rdoLinux = new System.Windows.Forms.RadioButton();
            this.rdoWindows = new System.Windows.Forms.RadioButton();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnDA = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.grbOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBBL
            // 
            this.lblBBL.AutoSize = true;
            this.lblBBL.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBBL.Location = new System.Drawing.Point(462, 21);
            this.lblBBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBBL.Name = "lblBBL";
            this.lblBBL.Size = new System.Drawing.Size(75, 34);
            this.lblBBL.TabIndex = 17;
            this.lblBBL.Text = "Cart";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(632, 486);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(224, 68);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblApps
            // 
            this.lblApps.AutoSize = true;
            this.lblApps.Location = new System.Drawing.Point(159, 554);
            this.lblApps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApps.Name = "lblApps";
            this.lblApps.Size = new System.Drawing.Size(170, 23);
            this.lblApps.TabIndex = 15;
            this.lblApps.Text = "您购买的应用有：";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(159, 486);
            this.lblOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(170, 23);
            this.lblOS.TabIndex = 14;
            this.lblOS.Text = "您的操作系统为：";
            // 
            // grbOS
            // 
            this.grbOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbOS.BackColor = System.Drawing.Color.IndianRed;
            this.grbOS.Controls.Add(this.rdoMacOS);
            this.grbOS.Controls.Add(this.rdoAndroid);
            this.grbOS.Controls.Add(this.rdoLinux);
            this.grbOS.Controls.Add(this.rdoWindows);
            this.grbOS.ForeColor = System.Drawing.Color.White;
            this.grbOS.Location = new System.Drawing.Point(142, 81);
            this.grbOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbOS.Name = "grbOS";
            this.grbOS.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbOS.Size = new System.Drawing.Size(290, 372);
            this.grbOS.TabIndex = 12;
            this.grbOS.TabStop = false;
            this.grbOS.Text = "OS-RadioButton";
            // 
            // rdoMacOS
            // 
            this.rdoMacOS.AutoSize = true;
            this.rdoMacOS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMacOS.ForeColor = System.Drawing.Color.White;
            this.rdoMacOS.Location = new System.Drawing.Point(53, 314);
            this.rdoMacOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMacOS.Name = "rdoMacOS";
            this.rdoMacOS.Size = new System.Drawing.Size(102, 27);
            this.rdoMacOS.TabIndex = 3;
            this.rdoMacOS.TabStop = true;
            this.rdoMacOS.Text = "MacOS";
            this.rdoMacOS.UseVisualStyleBackColor = true;
            this.rdoMacOS.CheckedChanged += new System.EventHandler(this.rdoMacOS_CheckedChanged);
            // 
            // rdoAndroid
            // 
            this.rdoAndroid.AutoSize = true;
            this.rdoAndroid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAndroid.ForeColor = System.Drawing.Color.White;
            this.rdoAndroid.Location = new System.Drawing.Point(53, 232);
            this.rdoAndroid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoAndroid.Name = "rdoAndroid";
            this.rdoAndroid.Size = new System.Drawing.Size(108, 27);
            this.rdoAndroid.TabIndex = 2;
            this.rdoAndroid.TabStop = true;
            this.rdoAndroid.Text = "Android";
            this.rdoAndroid.UseVisualStyleBackColor = true;
            this.rdoAndroid.CheckedChanged += new System.EventHandler(this.rdoAndroid_CheckedChanged);
            // 
            // rdoLinux
            // 
            this.rdoLinux.AutoSize = true;
            this.rdoLinux.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLinux.ForeColor = System.Drawing.Color.White;
            this.rdoLinux.Location = new System.Drawing.Point(53, 150);
            this.rdoLinux.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoLinux.Name = "rdoLinux";
            this.rdoLinux.Size = new System.Drawing.Size(80, 27);
            this.rdoLinux.TabIndex = 1;
            this.rdoLinux.TabStop = true;
            this.rdoLinux.Text = "Linux";
            this.rdoLinux.UseVisualStyleBackColor = true;
            this.rdoLinux.CheckedChanged += new System.EventHandler(this.rdoLinux_CheckedChanged);
            // 
            // rdoWindows
            // 
            this.rdoWindows.AutoSize = true;
            this.rdoWindows.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWindows.ForeColor = System.Drawing.Color.White;
            this.rdoWindows.Location = new System.Drawing.Point(53, 68);
            this.rdoWindows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoWindows.Name = "rdoWindows";
            this.rdoWindows.Size = new System.Drawing.Size(117, 27);
            this.rdoWindows.TabIndex = 0;
            this.rdoWindows.TabStop = true;
            this.rdoWindows.Text = "Windows";
            this.rdoWindows.UseVisualStyleBackColor = true;
            this.rdoWindows.CheckedChanged += new System.EventHandler(this.rdoWindows_CheckedChanged);
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.Color.IndianRed;
            this.lstCart.ForeColor = System.Drawing.Color.White;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 23;
            this.lstCart.Location = new System.Drawing.Point(566, 81);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(290, 372);
            this.lstCart.TabIndex = 18;
            // 
            // btnDA
            // 
            this.btnDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDA.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDA.ForeColor = System.Drawing.Color.White;
            this.btnDA.Location = new System.Drawing.Point(862, 136);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(145, 39);
            this.btnDA.TabIndex = 20;
            this.btnDA.Text = "删除所有应用";
            this.btnDA.UseVisualStyleBackColor = false;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btnDS
            // 
            this.btnDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDS.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnDS.ForeColor = System.Drawing.Color.White;
            this.btnDS.Location = new System.Drawing.Point(862, 81);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(145, 39);
            this.btnDS.TabIndex = 19;
            this.btnDS.Text = "删除选中应用";
            this.btnDS.UseVisualStyleBackColor = false;
            this.btnDS.Click += new System.EventHandler(this.btnDS_Click);
            // 
            // UC_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.btnDS);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lblBBL);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblApps);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.grbOS);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Cart";
            this.Size = new System.Drawing.Size(1000, 597);
            this.Load += new System.EventHandler(this.UC_Cart_Load);
            this.grbOS.ResumeLayout(false);
            this.grbOS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBBL;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblApps;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.GroupBox grbOS;
        private System.Windows.Forms.RadioButton rdoMacOS;
        private System.Windows.Forms.RadioButton rdoAndroid;
        private System.Windows.Forms.RadioButton rdoLinux;
        private System.Windows.Forms.RadioButton rdoWindows;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnDS;
    }
}
