using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Happy_Learning
{
    public partial class FrmDBOrders : Form
    {
        public FrmDBOrders()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            //Step 1.定义连接字符串
            string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = .\Student.mdb";
            //Step 2.创建OleDbConnection对象，建立数据库连接"
            OleDbConnection mycon = new OleDbConnection(conStr);
            //Step 3.打开数据库
            mycon.Open();
            MessageBox.Show("打开数据库连接成功!");
            //Step 4.关闭数据库
            mycon.Close();
            MessageBox.Show("关闭数据库连接成功!");
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            //Step 1.定义连接字符串
            string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = .\Student.mdb";
            //Step 2.创建OleDbConnection对象，建立数据库连接"
            OleDbConnection mycon = new OleDbConnection(conStr);
            //Step 3.打开数据库
            mycon.Open();
            MessageBox.Show("打开数据库连接成功!");
            //string cmdText = "select * from login"
            string cmdText = @"delete From score where 学号 = " + "'" + 1003 + "'";
            OleDbCommand comm = new OleDbCommand(cmdText, mycon);
            int result = comm.ExecuteNonQuery();
            // OleDbDataReader dr  = comm.ExecuteReader();//真正执行cmdText命令
            MessageBox.Show("执行Command命令成功！\n删除了" + result + "条记录！");


            //comm.ExecuteNonQuery();//执行一些非查询的命令Insert Delete
            //查询结果dr如何处理？.......
        }
    }
}
