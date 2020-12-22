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
    public partial class ZhuCe : Form
    {
        private string str = System.Environment.CurrentDirectory;
        string conStr = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source =";
        public ZhuCe()
        {
            InitializeComponent();
            conStr += str + @"\Student.mdb";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "")
            {
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem != null)
            {
                this.textBox1.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox3.Text != textBox2.Text)
                {
                    MessageBox.Show("两次输入密码不一致！");
                }
                else
                {
                    OleDbConnection conn = new OleDbConnection(conStr);
                    conn.Open();
                    string cmdText = @"insert into login(用户名,密码) values('" + textBox1.Text + "','" + textBox2.Text + "')";
                    OleDbCommand comm = new OleDbCommand(cmdText, conn);
                    int result = comm.ExecuteNonQuery(); 
                    MessageBox.Show("申请提交成功，请前往登录！");
                    this.Dispose();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("请将信息填写完整！");
            }
        }
    }
}
