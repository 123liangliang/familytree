namespace Happy_Learning
{
    partial class FrmKidding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKidding));
            this.lblText = new System.Windows.Forms.Label();
            this.btnYES = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblText.Location = new System.Drawing.Point(64, 97);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(376, 28);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "老师，开摄像头直播一次吧！";
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.Color.Transparent;
            this.btnYES.FlatAppearance.BorderSize = 0;
            this.btnYES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYES.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYES.ForeColor = System.Drawing.Color.White;
            this.btnYES.Location = new System.Drawing.Point(104, 207);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(66, 37);
            this.btnYES.TabIndex = 1;
            this.btnYES.Text = "YES";
            this.btnYES.UseVisualStyleBackColor = false;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.Transparent;
            this.btnNO.FlatAppearance.BorderSize = 0;
            this.btnNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNO.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.Location = new System.Drawing.Point(269, 207);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(66, 37);
            this.btnNO.TabIndex = 2;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // FrmKidding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Happy_Learning.Properties.Resources.地信2018二班;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(432, 323);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(720, 405);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKidding";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kidding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Button btnNO;
    }
}