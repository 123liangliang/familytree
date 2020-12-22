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
    public partial class ZhaoHui : Form
    {
        static public string user;//用户名，用于保存
        private string str = System.Environment.CurrentDirectory;
        string conStr = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source =";
        public ZhaoHui()
        {
            InitializeComponent();
            conStr += str + @"\Student.mdb";
        }
        private bool pdyj()
        {
            //用if来判断框的内容
            if (textBox1.Text == "")
                return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox3.Text == textBox2.Text)
                {
                    OleDbConnection conn = new OleDbConnection(conStr);
                    conn.Open();
                    string Access = "select 用户名 from login where 用户名='" + this.textBox1.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(Access, conn);
                    OleDbDataReader hyw = cmd.ExecuteReader();
                    if (hyw.Read())
                    {
                        user = textBox1.Text;
                        string cmdText = string.Format("update login set 密码 = '{0}' where 用户名 = '{1}'", textBox2.Text, textBox1.Text);
                        OleDbCommand comm = new OleDbCommand(cmdText, conn);
                        int result = comm.ExecuteNonQuery();
                        MessageBox.Show("密码重置成功！");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("用户名不存在！");
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("两次输入密码不一致！");
                }
            }
            else
            {
             MessageBox.Show("请将信息填写完整！");
            }
        }
    }
}
