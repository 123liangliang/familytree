using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace Happy_Learning
{
    public partial class UC_Cart : UserControl
    {
        public UC_Cart()
        {
            InitializeComponent();
        }

        private void rdoWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWindows.Checked == true)
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Checked)
                    this.lblOS.Text = "您的操作系统为：" + rb.Text;
            }
        }
        private void rdoLinux_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLinux.Checked == true)
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Checked)
                    this.lblOS.Text = "您的操作系统为：" + rb.Text;
            }
        }
        private void rdoAndroid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAndroid.Checked == true)
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Checked)
                    this.lblOS.Text = "您的操作系统为：" + rb.Text;
            }
        }
        private void rdoMacOS_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMacOS.Checked == true)
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Checked)
                    this.lblOS.Text = "您的操作系统为：" + rb.Text;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AppBLL appBll = new AppBLL();//实例化一个逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = PassUserName.passData;
            string textAdd = "";
            if (lstCart.Items.Count > 0)
            {
                for (int i = 0; i < lstCart.Items.Count; i++)
                {
                    textAdd += lstCart.Items[i].ToString() + " ";
                }
                bool a = false;//用于判断用户是否已经拥有下面循环语句data[i]中存的这个应用，false代表该用户还没有这个应用
                string have = "";//记录已经拥有的应用
                string app = "";//记录没有拥有的应用
                string[] data = textAdd.Trim().Split(' ');
                string[] dataHave = appBll.UserHaveApp(User).Trim().Split(' ');//用dataHave数组来存储该用户已经拥有的应用
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 0; j < dataHave.Length; j++)
                    {
                        if (data[i] == dataHave[j])
                        {
                            a = true;
                            break;
                        }
                    }
                    if (a == false)
                    {
                        User.App = data[i];
                        appBll.AddApp(User);
                        app += data[i] + " ";
                    }
                    else
                    {
                        have += data[i] + " ";
                    }
                }
                if (have == "")
                {
                    MessageBox.Show("购买成功，重新登录即可看到应用！", "恭喜!", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else if (app == "")
                {
                    MessageBox.Show("您已拥有" + have + ",\n\r不可以贪心哟！", "抱歉！", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("本次成功购买了" + app + "!\n\r但您已拥有" + have + ",不可以贪心哟！", "恭喜！", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("您购物车为空!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UC_Cart_Load(object sender, EventArgs e)
        {
            AppBLL appBll = new AppBLL();//实例化一个逻辑层
            UserModel User = new UserModel();//实例化一个实体
            User.UserName = PassUserName.passData;
            string textAdd = "";
            this.lblApps.Text = "您安装的软件有：";
            string[] Have = appBll.UserHaveApp(User).Trim().Split(' ');//用dataHave数组来存储该用户已经拥有的应用
            for (int j = 0; j < Have.Length; j++)
            {
                textAdd += Have[j] + " ";
            }
            this.lblApps.Text += textAdd;



            if (PassList.passData == " ")
            {
                this.lstCart.Items.Clear();
            }
            else
            {
                string[] data = PassList.passData.Trim().Split(' ');
                for (int i = 0; i < data.Length; i++)
                {
                    lstCart.Items.Add(data[i]);
                }
            }

        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            while (this.lstCart.SelectedIndex >= 0)
                this.lstCart.Items.RemoveAt(this.lstCart.SelectedIndex);
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            this.lstCart.Items.Clear();
        }

    }
}
