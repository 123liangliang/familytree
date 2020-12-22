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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            UserBLL userBll = new UserBLL();//实例化逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = txtUserName.Text.ToString().Trim();
            User.UserPwd = txtPassword.Text.ToString().Trim();
            if (txtPassword.Text == "")//判断是否输入密码
            {
                MessageBox.Show("请输入新密码!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Name = txtUserName.Text;
                if (txtPassword.Text == txtPasswordConfirm.Text)//确定两次输入的密码一致
                {
                    try
                    {
                        bool result = userBll.ChangePassword(User);
                        if (result)
                        MessageBox.Show("密码更改成功！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("密码更改失败！" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = PassUserName.passData;//保存传递的字符串
        }
    }
}
