namespace Happy_Learning
{
    partial class UC_List
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
            this.listWishes = new System.Windows.Forms.ListBox();
            this.listRealized = new System.Windows.Forms.ListBox();
            this.btnLeftToRight = new System.Windows.Forms.Button();
            this.btnRightToLeft = new System.Windows.Forms.Button();
            this.lblWishes = new System.Windows.Forms.Label();
            this.lblRealized = new System.Windows.Forms.Label();
            this.lblLCL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAddWishes = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDA = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.listWishesPool = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listWishes
            // 
            this.listWishes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listWishes.FormattingEnabled = true;
            this.listWishes.ItemHeight = 23;
            this.listWishes.Items.AddRange(new object[] {
            "疫情早点结束",
            "学校热水器早点安好",
            "多点朋友",
            "过二级"});
            this.listWishes.Location = new System.Drawing.Point(12, 127);
            this.listWishes.Name = "listWishes";
            this.listWishes.Size = new System.Drawing.Size(185, 117);
            this.listWishes.TabIndex = 0;
            // 
            // listRealized
            // 
            this.listRealized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listRealized.FormattingEnabled = true;
            this.listRealized.ItemHeight = 23;
            this.listRealized.Location = new System.Drawing.Point(282, 127);
            this.listRealized.Name = "listRealized";
            this.listRealized.Size = new System.Drawing.Size(185, 117);
            this.listRealized.TabIndex = 0;
            // 
            // btnLeftToRight
            // 
            this.btnLeftToRight.Location = new System.Drawing.Point(206, 154);
            this.btnLeftToRight.Name = "btnLeftToRight";
            this.btnLeftToRight.Size = new System.Drawing.Size(70, 34);
            this.btnLeftToRight.TabIndex = 2;
            this.btnLeftToRight.Text = ">>";
            this.btnLeftToRight.UseVisualStyleBackColor = true;
            this.btnLeftToRight.Click += new System.EventHandler(this.btnLeftToRight_Click);
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Location = new System.Drawing.Point(206, 210);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(70, 34);
            this.btnRightToLeft.TabIndex = 3;
            this.btnRightToLeft.Text = "<<";
            this.btnRightToLeft.UseVisualStyleBackColor = true;
            this.btnRightToLeft.Click += new System.EventHandler(this.btnRightToLeft_Click);
            // 
            // lblWishes
            // 
            this.lblWishes.AutoSize = true;
            this.lblWishes.Location = new System.Drawing.Point(8, 101);
            this.lblWishes.Name = "lblWishes";
            this.lblWishes.Size = new System.Drawing.Size(142, 23);
            this.lblWishes.TabIndex = 4;
            this.lblWishes.Text = "Wishes in 2020";
            // 
            // lblRealized
            // 
            this.lblRealized.AutoSize = true;
            this.lblRealized.Location = new System.Drawing.Point(287, 101);
            this.lblRealized.Name = "lblRealized";
            this.lblRealized.Size = new System.Drawing.Size(174, 23);
            this.lblRealized.TabIndex = 5;
            this.lblRealized.Text = "Realized Wish(es)";
            // 
            // lblLCL
            // 
            this.lblLCL.AutoSize = true;
            this.lblLCL.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCL.Location = new System.Drawing.Point(366, 15);
            this.lblLCL.Name = "lblLCL";
            this.lblLCL.Size = new System.Drawing.Size(297, 34);
            this.lblLCL.TabIndex = 6;
            this.lblLCL.Text = "List Controls Learning";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listRealized);
            this.panel1.Controls.Add(this.listWishes);
            this.panel1.Controls.Add(this.btnLeftToRight);
            this.panel1.Controls.Add(this.lblRealized);
            this.panel1.Controls.Add(this.btnRightToLeft);
            this.panel1.Controls.Add(this.lblWishes);
            this.panel1.Location = new System.Drawing.Point(5, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 340);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAddWishes);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.btnDA);
            this.panel2.Controls.Add(this.btnDS);
            this.panel2.Controls.Add(this.listWishesPool);
            this.panel2.Location = new System.Drawing.Point(508, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 340);
            this.panel2.TabIndex = 8;
            // 
            // txtAddWishes
            // 
            this.txtAddWishes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddWishes.Location = new System.Drawing.Point(51, 258);
            this.txtAddWishes.Name = "txtAddWishes";
            this.txtAddWishes.Size = new System.Drawing.Size(202, 32);
            this.txtAddWishes.TabIndex = 5;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(270, 258);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(145, 39);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "添加愿望";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDA
            // 
            this.btnDA.Location = new System.Drawing.Point(270, 101);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(145, 39);
            this.btnDA.TabIndex = 3;
            this.btnDA.Text = "删除所有愿望";
            this.btnDA.UseVisualStyleBackColor = true;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btnDS
            // 
            this.btnDS.Location = new System.Drawing.Point(270, 40);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(145, 39);
            this.btnDS.TabIndex = 2;
            this.btnDS.Text = "删除选中愿望";
            this.btnDS.UseVisualStyleBackColor = true;
            this.btnDS.Click += new System.EventHandler(this.btnDS_Click);
            // 
            // listWishesPool
            // 
            this.listWishesPool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listWishesPool.FormattingEnabled = true;
            this.listWishesPool.ItemHeight = 23;
            this.listWishesPool.Location = new System.Drawing.Point(51, 40);
            this.listWishesPool.Name = "listWishesPool";
            this.listWishesPool.Size = new System.Drawing.Size(202, 186);
            this.listWishesPool.TabIndex = 0;
            // 
            // UC_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLCL);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_List";
            this.Size = new System.Drawing.Size(1000, 597);
            this.Load += new System.EventHandler(this.UC_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listWishes;
        private System.Windows.Forms.ListBox listRealized;
        private System.Windows.Forms.Button btnLeftToRight;
        private System.Windows.Forms.Button btnRightToLeft;
        private System.Windows.Forms.Label lblWishes;
        private System.Windows.Forms.Label lblRealized;
        private System.Windows.Forms.Label lblLCL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnDS;
        private System.Windows.Forms.ListBox listWishesPool;
        private System.Windows.Forms.TextBox txtAddWishes;

    }
}
