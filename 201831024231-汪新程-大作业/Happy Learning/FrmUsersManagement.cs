using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace Happy_Learning
{
    public partial class FrmUsersManagement : Form
    {
        public FrmUsersManagement()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            UserBLL userBll = new UserBLL();//实例化逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = txtName.Text.ToString().Trim();
            User.UserPwd = txtPwd.Text.ToString().Trim();
            User.RealName = txtRealName.Text.ToString().Trim();
            User.IDType = cmbIDType.Text.ToString().Trim();
            User.ID = txtID.Text.ToString().Trim();
            User.Province = cmbProvince.Text.ToString().Trim();
            User.City = cmbCity.Text.ToString().Trim();
            User.Admin = txtAdmin.Text.ToString().Trim();
            if (txtName.Text == "")//判断是否输入用户名
            {
                MessageBox.Show("请输入用户名!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtPwd.Text == "")//判断是否输入密码
                {
                    MessageBox.Show("请输入密码!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (userBll.ExistUser(User) == true)//判断用户名是否已经在数据库中
                    {
                        MessageBox.Show("该用户已被注册!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (txtRealName.Text == "" || cmbIDType.Text == "" || txtID.Text == "" || cmbProvince.Text == "" || cmbCity.Text == "" || txtAdmin.Text == "")//判断是否完善用户相关信息
                        {
                            MessageBox.Show("请完善信息!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {
                                bool result = userBll.AddUser(User);
                                if (result)
                                {
                                    MessageBox.Show("添加用户成功！");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void cmbIDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIDType.Text != "")
            {
                this.txtID.Enabled = true;
            }
            else
            {
                this.txtID.Enabled = false;
            }
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //实例化一个CityModel对象
            CityModel City = new CityModel();
            //实例化一个CityBLL
            CityBLL cityBLL = new CityBLL();
            //把cmbSProvince的文本存在City对象的Province类中获得用户所选择的省份
            City.Province = this.cmbProvince.SelectedItem.ToString().Trim();
            //清空cmbSCity里面的城市列表
            this.cmbCity.Items.Clear();
            this.cmbCity.Text = "";
            //根据用户所选择省份，往城市组合框中添加items
            string[] cityData = CityBLL.CityData(City).Trim().Split(' ');
            this.cmbCity.Items.AddRange(cityData);
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            UserBLL userBll = new UserBLL();//实例化逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = txtQueName.Text.ToString().Trim();
            if (userBll.ExistUser(User) == true)
            {
                string[] Info = userBll.UserInfo(User).Trim().Split(' ');//把用户信息转存在一个string数组中
                //把数组里的信息转存至每个txtBox中
                txtSName.Text = Info[0];
                txtSPwd.Text = Info[1];
                txtSRealName.Text = Info[2];
                cmbSIDType.Text = Info[3];
                txtSID.Text = Info[4];
                cmbSProvince.Text = Info[5];
                cmbSCity.Text = Info[6];
                txtSAdmin.Text = Info[7];
            }
            else
            {
                MessageBox.Show("用户名为" + User.UserName + "的用户不存在! ");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserBLL userBll = new UserBLL();//实例化逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = txtQueName.Text.ToString().Trim();
            User.UserPwd = txtSPwd.Text.ToString().Trim();
            User.RealName = txtSRealName.Text.ToString().Trim();
            User.IDType = cmbSIDType.Text.ToString().Trim();
            User.ID = txtSID.Text.ToString().Trim();
            User.Province = cmbSProvince.Text.ToString().Trim();
            User.City = cmbSCity.Text.ToString().Trim();
            User.Admin = txtSAdmin.Text.ToString().Trim();

            if (txtSPwd.Text == "" || txtSRealName.Text == "" || cmbSIDType.Text == "" || txtSID.Text == ""
                || cmbSProvince.Text == "" || cmbSCity.Text == "" || txtSAdmin.Text == "")//判断是否完善用户相关信息
            {
                MessageBox.Show("请完善信息!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //修改用户信息
                    bool result = userBll.ChangeInfo(User);
                    if (result)
                    {
                        MessageBox.Show("用户信息修改成功！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserBLL userBll = new UserBLL();//实例化逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = txtName.Text.ToString().Trim();
            bool result = userBll.CLUser(User);
            if (result)
                MessageBox.Show("用户删除成功！");
        }

        private void cmbSProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //实例化一个CityModel对象
            CityModel City = new CityModel();
            //实例化一个CityBLL
            CityBLL cityBLL = new CityBLL();
            //把cmbSProvince的文本存在City对象的Province类中获得用户所选择的省份
            City.Province = this.cmbSProvince.SelectedItem.ToString().Trim();
            //清空cmbSCity里面的城市列表
            this.cmbSCity.Items.Clear();
            this.cmbSCity.Text = "";
            //根据用户所选择省份，往城市组合框中添加items
            string[] cityData = CityBLL.CityData(City).Trim().Split(' ');
            this.cmbSCity.Items.AddRange(cityData);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.myDataGrid.DataSource = UserBLL.UserList();
            this.myDataGrid.Columns["app"].Visible = false;//手动关闭"app"这个字段这一列哈哈hhhhhh...
        }



        private void FrmUsersManagement_Load(object sender, EventArgs e)
        {
            this.myDataGrid.DataSource = UserBLL.UserList();
            this.myDataGrid.Columns["app"].Visible = false;
            //UserBLL userBll = new UserBLL();
            //userBll.UpdateInfo();

            LoadData();
            OleDbCommandBuilder cmdBuild = new OleDbCommandBuilder(da);
            da.InsertCommand = cmdBuild.GetInsertCommand();
            da.DeleteCommand = cmdBuild.GetDeleteCommand();
            da.UpdateCommand = cmdBuild.GetUpdateCommand();
        }
        #region DataGridView中直接增删改用户信息
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private DataSet ds;

        private void LoadData()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = .\Student.mdb");
            string sql = @"Select * From login";
            da = new OleDbDataAdapter(sql,conn);
            ds = new DataSet();
            DataSet myDataSet = new DataSet();
            da.Fill(ds, "用户表");
            ds.Tables["用户表"].PrimaryKey = new DataColumn[] { ds.Tables["用户表"].Columns["用户名"] };
            myDataGrid.DataSource = ds.Tables["用户表"];
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "用户表");
                ds.AcceptChanges();
                MessageBox.Show("更新成功! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新出错!" + ex.Message);
            }
        }
        #endregion

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["用户表"].Rows[myDataGrid.CurrentRow.Index];
            dr.Delete();
            try
            {
                da.Update(ds, "用户表");
                ds.AcceptChanges();
                MessageBox.Show("删除成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除出错" + ex.Message);
            }
            myDataGrid.DataSource = ds.Tables["用户表"];
        }
    }
}

