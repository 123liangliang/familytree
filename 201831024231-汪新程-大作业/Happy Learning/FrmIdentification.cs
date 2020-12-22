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
    public partial class FrmIdentification : Form
    {
        public FrmIdentification()
        {
            InitializeComponent();
        }

        private void btnIdentification_Click(object sender, EventArgs e)
        {
            UserBLL userBll = new UserBLL();//实例化逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = txtUserName.Text.ToString().Trim();
            User.UserPwd = txtPassword.Text.ToString().Trim();
            bool exist = userBll.ExistUser(User);
            if (exist == true)//判断该用户名是否在数据库中
            {
                try
                {
                    bool result = userBll.CheckUser(User);
                    if (result == true)
                    {
                        PassUserName.passData = txtUserName.Text;//保存传递的字符串
                        FrmChangePassword frmChangePassword = new FrmChangePassword();
                        frmChangePassword.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("密码不正确!", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex) //如果登陆有异常则登陆失败
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("用户不存在!", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
