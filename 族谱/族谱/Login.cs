using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWPU
{
    public partial class Login : Form
    {
        static public string xuehao;//用户名，用于保存
        static public string mima;//密码，用于保存
        private string str = System.Environment.CurrentDirectory;
        string conStr = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source =";
        public Login()
        {
            InitializeComponent();
            conStr += str + @"\Student.mdb";
        }
        private bool pdyj()
        {
            //用if来判断框的内容
            if (textBox_xuehao.Text == "")
                return false;
            if (textBox_mima.Text == "")
                return false;
            return true;
        }
        private void button_denglu_Click(object sender, EventArgs e)
        {
            if (!pdyj())
            {
                MessageBox.Show("请输入正确信息");
                return;
            }
            string xuehao = textBox_xuehao.Text.ToString();
            string mima = textBox_mima.Text.ToString();
            OleDbConnection conn = new OleDbConnection(conStr);
            conn.Open();
            string Access = "select 用户名,密码 from login where 用户名='" + this.textBox_xuehao.Text + "'and 密码='" + this.textBox_mima.Text + "'";
            OleDbCommand cmd = new OleDbCommand(Access, conn);
            OleDbDataReader hyw = cmd.ExecuteReader();
              if(hyw.Read())
            {
                //在构造中我们的量就作为判断
                xuehao = textBox_xuehao.Text;
                mima = textBox_mima.Text;
                //一旦连接成功了就弹出窗口
                //MessageBox.Show("登录成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //信息错误，判断条件不成立
                MessageBox.Show("输入用户密码错误");
                textBox_xuehao.Clear();
                textBox_mima.Clear();
            }
            conn.Close();
            }

        private void button_zhuce_Click(object sender, EventArgs e)
        {
            ZhuCe zhuce = new ZhuCe();
            zhuce.Show();
        }

        private void button_zhaohui_Click(object sender, EventArgs e)
        {
            ZhaoHui zhaohui = new ZhaoHui();
            zhaohui.Show();
        }
        }
}
