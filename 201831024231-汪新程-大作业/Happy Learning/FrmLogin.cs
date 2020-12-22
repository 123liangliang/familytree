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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                        this.DialogResult = DialogResult.OK;
                        PassUserName.passData = User.UserName; //保存当前登录账号的用户名，以便将该用户名传入MainForm界面
                    }
                    else
                    {
                        MessageBox.Show("Try Again!", "Sorry!Sorry!Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex) //如果登陆有异常则登陆失败
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                FrmWarnig frmWarnig = new FrmWarnig();
                frmWarnig.ShowDialog();
            }
        }

        private void lblForgotInfor_Click(object sender, EventArgs e)
        {
            FrmFindPassword frmFindPassword = new FrmFindPassword();
            frmFindPassword.ShowDialog();
        }

        private void lblForgotInfor_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void lblForgotInfor_MouseUp(object sender, MouseEventArgs e)
        {
            //this.ForeColor = Color.Red;
        }

        private void lblForgotInfor_MouseMove(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void lblForgotInfor_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromArgb(0, 71, 160);
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp frmSignup = new FrmSignUp();
            frmSignup.ShowDialog();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            FrmIdentification frmIdentification = new FrmIdentification();
            frmIdentification.ShowDialog();
        }

        private void lblCLAccount_Click(object sender, EventArgs e)
        {
            FrmCLAccount frmCLAccount = new FrmCLAccount();
            frmCLAccount.ShowDialog();
        }

        private void lblAdministrator_Click(object sender, EventArgs e)
        {
            FrmAdminCheck frmAdminCheck = new FrmAdminCheck();
            frmAdminCheck.ShowDialog(); 
        }
    }
}
