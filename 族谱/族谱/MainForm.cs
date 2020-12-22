using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWPU
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control paraC)
        {
            paraC.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(paraC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_zhuye uczhuye = new UC_zhuye();
            AddControlsToPanel(uczhuye);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_bixiu ucbixuan = new UC_bixiu();
            AddControlsToPanel(ucbixuan);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_qingdan ucqingdan = new UC_qingdan();
            AddControlsToPanel(ucqingdan);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_huojiang uchuojiang = new UC_huojiang();
            AddControlsToPanel(uchuojiang);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UC_lunwen uclunwen = new UC_lunwen();
            AddControlsToPanel(uclunwen);
            Editor editor = new Editor();
            editor.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UC_chengji ucchengji = new UC_chengji();
            AddControlsToPanel(ucchengji);
            ChengJi chengji = new ChengJi();
            chengji.ShowDialog();
        }


    }
}
