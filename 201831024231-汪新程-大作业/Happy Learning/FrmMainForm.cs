using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace Happy_Learning
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
            timer1.Start();//计时器开启

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;//获取当前时间
            lblTime.Text = dt.ToString("HH:mm:ss");//格式化该时间，放在lbITime控件上显示
        }

        /// <summary>
        ///往pnIControls中添加一个用户控件, 示子页面内容
        ///形参paraC是一 个用户控件
        ///</summary>
        private void AddControlsToPanel(Control paraC)
        {
            paraC.Dock = DockStyle.Fill;
            pnlControls.Controls.Clear();//清空之前的UC
            pnlControls.Controls.Add(paraC);//增加一个UC
        }
        ///<summary>
        ///点击了btnHome按钮后,新建一个UC Home控件对象，并调用AddControlsToPanel()方法将此控件加入pnIControls容器中
        ///</summary>

        private void btnButton_Click(object sender, EventArgs e)
        {
            UC_Cart ucButton = new UC_Cart();
            AddControlsToPanel(ucButton);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            UC_List ucList = new UC_List();
            AddControlsToPanel(ucList);
        }

        private void btnDialogue_Click(object sender, EventArgs e)
        {
            UC_Dialogue ucDialogue = new UC_Dialogue();
            AddControlsToPanel(ucDialogue);
        }

        private void btnRTF_Click(object sender, EventArgs e)
        {
            FrmRTFEditor FrmRTFEditor = new FrmRTFEditor();
            FrmRTFEditor.ShowDialog();
        }

        private void btnTypingGame_Click(object sender, EventArgs e)
        {
            FrmTypingGame FrmTypingGame = new FrmTypingGame();
            FrmTypingGame.ShowDialog();
        }

        private void btnkidding_Click(object sender, EventArgs e)
        {
            FrmKidding FrmKidding = new FrmKidding();
            FrmKidding.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home ucHome = new UC_Home();
            AddControlsToPanel(ucHome);
        }


        private void btnADONET_Click(object sender, EventArgs e)
        {
            FrmDataReader FrmDataReader = new FrmDataReader();
            FrmDataReader.Visible = true;
            this.Show();
        }
        private void axWMPMusic_Enter(object sender, EventArgs e)
        {
            axWMPMusic.settings.setMode("loop", true);
            this.axWMPMusic.URL = Application.StartupPath + @"\给你给我.mp3";
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UC_Users ucUsers = new UC_Users();
            AddControlsToPanel(ucUsers);
        }

        private void btnDBOrders_Click(object sender, EventArgs e)
        {
            FrmDBOrders FrmDBOrders = new FrmDBOrders();
            FrmDBOrders.ShowDialog();
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            lblHLF.Text = PassUserName.passData + "'s  APP  STORE";//在窗口上方lbl显示该用户名

            AppBLL appBll = new AppBLL();//实例化一个逻辑层
            UserModel User = new UserModel();
            User.UserName = PassUserName.passData;//将该账号的用户名传入MainForm
            PassList.passData = " ";

            string[] Have = appBll.UserHaveApp(User).Trim().Split(' ');//用dataHave数组来存储该用户已经拥有的应用
            foreach (Control control in this.pnlList.Controls)
            {
                for (int i = 0; i < Have.Length; i++)
                {
                    if (control.Text.Trim() == Have[i].ToString().Trim())
                    {
                        control.Visible = true;
                    }
                }
            }

            pnlList.Update();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // pnlList.Update();
        }





    }
}
