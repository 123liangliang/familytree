namespace Happy_Learning
{
    partial class UC_Users
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("微软雅黑", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.Location = new System.Drawing.Point(60, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(241, 68);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "用户信息";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2.Location = new System.Drawing.Point(67, 136);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(72, 27);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "头像：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(67, 191);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名：CXK";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo.Location = new System.Drawing.Point(67, 246);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(216, 27);
            this.lblNo.TabIndex = 3;
            this.lblNo.Text = "学号：201831020000";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl5.Location = new System.Drawing.Point(67, 301);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(112, 27);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "专业：篮球";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl6.Location = new System.Drawing.Point(67, 356);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(498, 27);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "简介：该用户练习C#时长两个月，还请老师多多指教！";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = global::Happy_Learning.Properties.Resources.cxk88;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(135, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 88);
            this.label1.TabIndex = 6;
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(1000, 597);
            this.Load += new System.EventHandler(this.UC_Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label1;
    }
}
