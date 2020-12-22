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
    public partial class FrmDataReader : Form
    {
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private DataSet ds;

        private void LoadData()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\Student.mdb");
            string sql = @"Select * From score";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            DataSet myDataSet = new DataSet();
            da.Fill(ds, "成绩表");
            ds.Tables["成绩表"].PrimaryKey = new DataColumn[] { ds.Tables["成绩表"].Columns["学号"] };
            myDataGrid.DataSource = ds.Tables["成绩表"];
        }

        public FrmDataReader()
        {
            InitializeComponent();
        }

        private void btnLoadScore_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\Student.mdb");
            conn.Open();
            string sql = @"Select * From score";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader dr = comm.ExecuteReader();
            richTextBox1.Text = "学号\t姓名\t体育\t英语\t操作系统\t面向对象\n";
            while (dr.Read())
            {
                richTextBox1.AppendText(dr["学号"] + "\t");
                richTextBox1.AppendText(dr["姓名"] + "\t");
                richTextBox1.AppendText(dr["体育"] + "\t");
                richTextBox1.AppendText(dr["英语"] + "\t");
                richTextBox1.AppendText(dr["操作系统"] + "\t\t");
                richTextBox1.AppendText(dr["面向对象"] + "\t");
                richTextBox1.AppendText("\n");
            }
            conn.Close();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Step 1.定义连接字符串
            string sqlcon = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\Student.mdb";
            //Step 2.创建OleDbConnection对象，建立数据库连接
            OleDbConnection mycon = new OleDbConnection(sqlcon);
            //Step 3.打开数据库
            mycon.Open();
            string stNo = txtNo.Text.ToString().Trim();
            string stName = txtName.Text.ToString().Trim();
            string stSport = txtSports.Text.ToString().Trim();
            string stEnglish = txtEnglish.Text.ToString().Trim();
            string stOS = txtOS.Text.ToString().Trim();
            string stOO = txtOS.Text.ToString().Trim();
            //Step 4.创建command对象，指定要执行sql语句与连接对象mycon
            string comStr = @"Insert into score(学号,姓名,体育,英语,操作系统,面向对象) values(";
            comStr += "'" + stNo + "','" + stName + "','" + stSport + "','" + stEnglish + "','" + stOS + "','" + stOO + "')";
            OleDbConnection conn = new OleDbConnection(sqlcon);
            OleDbCommand cmd = new OleDbCommand(comStr, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("插入出错！" + ex.Message);
            }
            conn.Close();

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //Step 1.定义连接字符串
            string sqlcon = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\Student.mdb";
            //Step 2.创建OleDbConnection对象，建立数据库连接
            OleDbConnection mycon = new OleDbConnection(sqlcon);
            //Step 3.打开数据库
            mycon.Open();
            //Step 3.创建command对象,指定要执行sql语句与连接对象mycon
            string stNo = txtQueNo.Text.ToString().Trim();
            string sql = @"Select * from score where 学号='" + stNo + "'";
            OleDbCommand cmd = new OleDbCommand(sql, mycon);
            //Step 4.执行查询返回结果集
            OleDbDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("学号为" + stNo + "的学生不存在! ");
                return;
            }
            //step5显示查询结果
            txtSNo.Text = dr["学号"].ToString();
            txtSName.Text = dr["姓名"].ToString();
            txtSSport.Text = dr["体育"].ToString();
            txtSEnglish.Text = dr["英语"].ToString();
            txtSOS.Text = dr["操作系统"].ToString();
            txtSOO.Text = dr["面向对象"].ToString();
            //step6关闭数据库
            mycon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\Student.mdb");
            string stNo = txtQueNo.Text.ToString().Trim();
            string sql = @"Delete From score where 学号='" + stNo + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("学号为" + stNo + "的学生成功删除！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除出错！" + ex.Message);
            }
            conn.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //分别取出学号、姓名、各门课程成绩放入变量
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\Student.mdb");
            string stName = txtSName.Text.ToString().Trim();
            string stNo = txtQueNo.Text.ToString().Trim();
            string sql = @"Update score set 姓名='" + stName + "'";
            sql += " where 学号='" + stNo + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("学号为" + stNo + "的学生成功更新！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新出错！" + ex.Message);
            }
            conn.Close();

        }

        private void btnLoadByAdapter_Click(object sender, EventArgs e)
        {
            //Step 1.定义连接字符串
            string sqlcon = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\Student.mdb";
            //Step 2.创建OleDbConnection对象，建立数据库连接
            OleDbConnection mycon = new OleDbConnection(sqlcon);
            //Step 3.打开数据库
            mycon.Open();
            //Step 4.创建OleDbDataAdapter对象,指定要执行sql语句与连接对象mycon
            string comStr = "select * from score'";
            OleDbDataAdapter da = new OleDbDataAdapter(comStr, mycon);
            //Step 5.创建DataSet对象,使用DataAdapter填充数据
            DataSet ds = new DataSet();
            da.Fill(ds, "成绩表");
            //Step 6.将DataSet绑定到DataGrid等数据控件,在窗体.上展现数据
            myDataGrid.DataSource = ds.Tables["成绩表"];

        }

        private void FrmDataReader_Load(object sender, EventArgs e)
        {
            LoadData();
            OleDbCommandBuilder cmdBuild = new OleDbCommandBuilder(da);
            da.InsertCommand = cmdBuild.GetInsertCommand();
            da.DeleteCommand = cmdBuild.GetDeleteCommand();
            da.UpdateCommand = cmdBuild.GetUpdateCommand();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "成绩表");
                ds.AcceptChanges();
                MessageBox.Show("更新成功! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新出错!" + ex.Message);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["成绩表"].Rows[myDataGrid.CurrentRow.Index];
            dr.Delete();
            try
            {
                da.Update(ds, "成绩表");
                ds.AcceptChanges();
                MessageBox.Show("删除成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除出错" + ex.Message);
            }
            myDataGrid.DataSource = ds.Tables["成绩表"];

        }
    }
}
