namespace SWPU
{
    partial class Login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1_xuehao = new System.Windows.Forms.Label();
            this.label_mima = new System.Windows.Forms.Label();
            this.textBox_xuehao = new System.Windows.Forms.TextBox();
            this.textBox_mima = new System.Windows.Forms.TextBox();
            this.button_zhuce = new System.Windows.Forms.Button();
            this.button_denglu = new System.Windows.Forms.Button();
            this.label_swpu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_zhaohui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_xuehao
            // 
            this.label1_xuehao.AutoSize = true;
            this.label1_xuehao.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_xuehao.Location = new System.Drawing.Point(188, 312);
            this.label1_xuehao.Name = "label1_xuehao";
            this.label1_xuehao.Size = new System.Drawing.Size(89, 20);
            this.label1_xuehao.TabIndex = 0;
            this.label1_xuehao.Text = "用户名：";
            // 
            // label_mima
            // 
            this.label_mima.AutoSize = true;
            this.label_mima.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_mima.Location = new System.Drawing.Point(208, 352);
            this.label_mima.Name = "label_mima";
            this.label_mima.Size = new System.Drawing.Size(69, 20);
            this.label_mima.TabIndex = 0;
            this.label_mima.Text = "密码：";
            // 
            // textBox_xuehao
            // 
            this.textBox_xuehao.Location = new System.Drawing.Point(292, 312);
            this.textBox_xuehao.Name = "textBox_xuehao";
            this.textBox_xuehao.Size = new System.Drawing.Size(243, 25);
            this.textBox_xuehao.TabIndex = 1;
            // 
            // textBox_mima
            // 
            this.textBox_mima.Location = new System.Drawing.Point(292, 349);
            this.textBox_mima.Name = "textBox_mima";
            this.textBox_mima.Size = new System.Drawing.Size(243, 25);
            this.textBox_mima.TabIndex = 1;
            this.textBox_mima.UseSystemPasswordChar = true;
            // 
            // button_zhuce
            // 
            this.button_zhuce.BackColor = System.Drawing.Color.White;
            this.button_zhuce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zhuce.Location = new System.Drawing.Point(292, 393);
            this.button_zhuce.Name = "button_zhuce";
            this.button_zhuce.Size = new System.Drawing.Size(115, 38);
            this.button_zhuce.TabIndex = 2;
            this.button_zhuce.Text = "注册账号";
            this.button_zhuce.UseVisualStyleBackColor = false;
            this.button_zhuce.Click += new System.EventHandler(this.button_zhuce_Click);
            // 
            // button_denglu
            // 
            this.button_denglu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_denglu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_denglu.ForeColor = System.Drawing.Color.White;
            this.button_denglu.Location = new System.Drawing.Point(292, 437);
            this.button_denglu.Name = "button_denglu";
            this.button_denglu.Size = new System.Drawing.Size(243, 38);
            this.button_denglu.TabIndex = 2;
            this.button_denglu.Text = "登录";
            this.button_denglu.UseVisualStyleBackColor = false;
            this.button_denglu.Click += new System.EventHandler(this.button_denglu_Click);
            // 
            // label_swpu
            // 
            this.label_swpu.AutoSize = true;
            this.label_swpu.Location = new System.Drawing.Point(703, 524);
            this.label_swpu.Name = "label_swpu";
            this.label_swpu.Size = new System.Drawing.Size(47, 15);
            this.label_swpu.TabIndex = 4;
            this.label_swpu.Text = "@swpu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SWPU.Properties.Resources.批注_2020_05_21_130043;
            this.pictureBox1.Location = new System.Drawing.Point(181, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_zhaohui
            // 
            this.button_zhaohui.BackColor = System.Drawing.Color.White;
            this.button_zhaohui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zhaohui.Location = new System.Drawing.Point(420, 393);
            this.button_zhaohui.Name = "button_zhaohui";
            this.button_zhaohui.Size = new System.Drawing.Size(115, 38);
            this.button_zhaohui.TabIndex = 2;
            this.button_zhaohui.Text = "忘记密码";
            this.button_zhaohui.UseVisualStyleBackColor = false;
            this.button_zhaohui.Click += new System.EventHandler(this.button_zhaohui_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 565);
            this.Controls.Add(this.label_swpu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_denglu);
            this.Controls.Add(this.button_zhaohui);
            this.Controls.Add(this.button_zhuce);
            this.Controls.Add(this.textBox_mima);
            this.Controls.Add(this.textBox_xuehao);
            this.Controls.Add(this.label_mima);
            this.Controls.Add(this.label1_xuehao);
            this.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "族谱";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_xuehao;
        private System.Windows.Forms.Label label_mima;
        private System.Windows.Forms.TextBox textBox_xuehao;
        private System.Windows.Forms.TextBox textBox_mima;
        private System.Windows.Forms.Button button_zhuce;
        private System.Windows.Forms.Button button_denglu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_swpu;
        private System.Windows.Forms.Button button_zhaohui;
    }
}

