namespace Happy_Learning
{
    partial class FrmDBOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBOrders));
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.Color.White;
            this.btnConnection.Location = new System.Drawing.Point(59, 43);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(156, 49);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnCommand
            // 
            this.btnCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommand.ForeColor = System.Drawing.Color.White;
            this.btnCommand.Location = new System.Drawing.Point(59, 122);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(156, 49);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "Command";
            this.btnCommand.UseVisualStyleBackColor = false;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // FrmDBOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.btnConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDBOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库基本操作";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnCommand;
    }
}