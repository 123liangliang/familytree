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
using BLL;
using Model;

namespace Happy_Learning
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserBLL userBll = new UserBLL();//实例化逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = txtName.Text.ToString().Trim();
            User.UserPwd = txtPassword.Text.ToString().Trim();
            User.RealName = txtRealName.Text.ToString().Trim();
            User.IDType = cmbIDType.Text.ToString().Trim();
            User.ID = txtID.Text.ToString().Trim();
            User.Province = cmbProvince.Text.ToString().Trim();
            User.City = cmbCity.Text.ToString().Trim();
            if (txtName.Text == "")//判断是否输入用户名
            {
                MessageBox.Show("请输入用户名!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtPassword.Text == "")//判断是否输入密码
                {
                    MessageBox.Show("请输入密码!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (userBll.ExistUser(User)==true)//判断用户名是否已经在数据库中
                    {
                        MessageBox.Show("该用户已被注册!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (txtRealName.Text == "" || cmbIDType.Text == "" || txtID.Text == "" || cmbProvince.Text == "" || cmbCity.Text == "")//判断是否完善用户相关信息
                        {
                            MessageBox.Show("请完善您的信息!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (txtPassword.Text == txtPasswordConfirm.Text)
                            {
                                try
                                {
                                    bool result = userBll.AddUser(User);
                                    if (result)
                                    {
                                        MessageBox.Show("注册成功！");
                                    }
                                }
                                catch (Exception ex) 
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("两次密码输入不一致!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtPasswordConfirm.Enabled = true;
            }
            else
            {
                txtPasswordConfirm.Enabled = false;
            }
        }

        private void cmbIDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.cmbIDType.SelectedItem != "")
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
    }
}
