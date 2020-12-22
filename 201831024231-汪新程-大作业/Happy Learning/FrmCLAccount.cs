using System;
using System.Collections.Generic;
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
    public partial class FrmCLAccount : Form
    {
        public FrmCLAccount()
        {
            InitializeComponent();
        }

        private void btnCLAccount_Click(object sender, EventArgs e)
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
                    bool result = userBll.CheckUser(User);//检查密码是否正确
                    if (result == true)
                    {
                        bool DLresult = userBll.CLUser(User);//注销账号
                        if(DLresult ==true)
                        {
                            MessageBox.Show("用户名为  " + User.UserName + "  的账号注销成功! ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请重试!", "密码错误!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex) //如果登陆有异常则登陆失败
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("请重试!", "该用户不存在!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
