namespace Happy_Learning
{
    partial class FrmTypingGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTypingGame));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSMenuItemStart = new System.Windows.Forms.ToolStripButton();
            this.TSMenuItemPause = new System.Windows.Forms.ToolStripButton();
            this.timerrate = new System.Windows.Forms.Timer(this.components);
            this.timerlab = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItemStart,
            this.TSMenuItemPause});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSMenuItemStart
            // 
            this.TSMenuItemStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMenuItemStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMenuItemStart.ForeColor = System.Drawing.Color.White;
            this.TSMenuItemStart.Image = ((System.Drawing.Image)(resources.GetObject("TSMenuItemStart.Image")));
            this.TSMenuItemStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMenuItemStart.Name = "TSMenuItemStart";
            this.TSMenuItemStart.Size = new System.Drawing.Size(58, 27);
            this.TSMenuItemStart.Text = "Start";
            this.TSMenuItemStart.Click += new System.EventHandler(this.TSMenuItemStart_Click);
            // 
            // TSMenuItemPause
            // 
            this.TSMenuItemPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMenuItemPause.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMenuItemPause.ForeColor = System.Drawing.Color.White;
            this.TSMenuItemPause.Image = ((System.Drawing.Image)(resources.GetObject("TSMenuItemPause.Image")));
            this.TSMenuItemPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMenuItemPause.Name = "TSMenuItemPause";
            this.TSMenuItemPause.Size = new System.Drawing.Size(73, 27);
            this.TSMenuItemPause.Text = "Pause";
            this.TSMenuItemPause.Click += new System.EventHandler(this.TSMenuItemPause_Click);
            // 
            // timerrate
            // 
            this.timerrate.Tick += new System.EventHandler(this.timerrate_Tick);
            // 
            // timerlab
            // 
            this.timerlab.Tick += new System.EventHandler(this.timerlab_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(332, 8);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(207, 15);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "                         ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnClose.BackgroundImage = global::Happy_Learning.Properties.Resources.电源;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(965, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmTypingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1000, 597);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmTypingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTypingGame";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmTypingGame_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSMenuItemStart;
        private System.Windows.Forms.ToolStripButton TSMenuItemPause;
        private System.Windows.Forms.Timer timerrate;
        private System.Windows.Forms.Timer timerlab;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnClose;
    }
}