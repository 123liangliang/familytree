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
    public partial class FrmFindPassword : Form
    {
        public FrmFindPassword()
        {
            InitializeComponent();
        }

        private void cmbIDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtID.Enabled = false;
            //令一个文本框可用Enabled
            /// if(this.cmbIDType.SelectedIndex !=-1)
            if (this.cmbIDType.SelectedItem != null)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserBLL userBll = new UserBLL();//实例化逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = txtName.Text.ToString().Trim();
            User.RealName = txtRealName.Text.ToString().Trim();
            User.IDType = cmbIDType.Text.ToString().Trim();
            User.ID = txtID.Text.ToString().Trim();
            User.Province = cmbProvince.Text.ToString().Trim();
            User.City = cmbCity.Text.ToString().Trim();

            if (txtRealName.Text == "" || cmbIDType.Text == "" || txtID.Text == "" || cmbProvince.Text == "" || cmbCity.Text == "")//确定用户所有信息已经填好
            {
                MessageBox.Show("请填完所有信息！", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (userBll.ExistUser(User) == false)//判断数据库中是否存在该用户
                {
                    MessageBox.Show("用户名为" + User.UserName + "的用户不存在! ");
                    return;
                }
                else
                {
                    if (userBll.ConfirmUser(User) == true)//判断验证信息是否输入正确
                    {
                        MessageBox.Show("您的账号是：" + User.UserName + "；密码是：" + User.UserPwd + "。", "恭喜!密码找到了！",
                            MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Try Again!", "Sorry!Sorry!Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
    }
}
