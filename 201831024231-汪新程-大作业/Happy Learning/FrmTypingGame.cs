using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Happy_Learning
{
    public partial class FrmTypingGame : Form
    {
        Hashtable _htlab = new Hashtable(); //存放lab控件
        int _count = 0;   //游戏分数
        int _life = 10;   //生命值，小于0死亡，过关生命10
        public FrmTypingGame()
        {
            InitializeComponent();
        }
        /// <summary>
        ///开始游戏
        /// </ summary>
        /// <paran name="sender"></param>
        /// <param name="e" ></param>
        private void TSMenuItemStart_Click(object sender, EventArgs e)
        {
            this.timerlab.Enabled = true;
            this.timerrate.Enabled = true;
            this.timerrate.Interval = 1;
            this.timerlab.Interval = 1;
            _count = 0;
            _life = 10;
            if (_htlab == null)
                _htlab = new Hashtable();
        }
        /// <summary>
        ///暂停游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name= "e" ></param>
        private void TSMenuItemPause_Click(object sender, EventArgs e)
        {
            this.timerlab.Enabled = false;
            this.timerrate.Enabled = false;
        }
        /// <summary>
        /// 让字符飘动的定时器Tick事件
        ///</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerrate_Tick(object sender, EventArgs e)
        {
            //调用飘动方法，设置飘动速度为10毫秒移动( count / 50) + 1个大小的位置
            flutter(10, (_count / 50) + 1);
        }
        //产生字符的定时事件
        private void timerlab_Tick(object sender, EventArgs e)
        {
            //调用产生字符方法，每888-( count / 50) * 200毫秒产生一个 字号20的字符
            create(888 - (_count / 50) * 200, 20);
        }
        /// <summary>
        ///游戏结束时状态
        /// </summary>
        public void stop()
        {
            this.timerlab.Enabled = false;
            this.timerrate.Enabled = false;
            foreach (DictionaryEntry de in _htlab)
            {
                Label l = (Label)de.Value;
                l.Dispose();
            }
            this.Text = "游戏结束，请从新开始! ";
        }
        /// < summary>
        ///让屏幕控件飘动方法
        /// </summary>
        /// <param name="time">飘动速度</param>
        /// <param name="value">飘动范围一在软件上移动的范围</param>
        public void flutter(int time, int value)
        {
            if (_life <= 0)
            {
                stop();
                MessageBox.Show("生命值为0,游戏结束! ", "对不起");
                return;
            }
            this.timerrate.Interval = time;
            ArrayList a1 = new ArrayList();//存放已经沉淀到最底部的lab在hash中的key
            foreach (DictionaryEntry de in _htlab)
            {
                Label lab = (Label)de.Value;
                if (lab.Location.Y >= this.Size.Height - 80)
                {
                    //如果1ab坐标大于本程序最底部-80执行
                    lab.Dispose();//销毁1ab
                    a1.Add(de.Key); //把当前hash的key存入arraylist
                    _life--; // 落地减生命
                    lblScore.Text = "第" + ((_count / 50) + 1) + "关 您的生命值: "
                    + _life + " 分数: " + _count;
                }
                else
                    lab.Location = new Point(lab.Location.X,
                     lab.Location.Y + value); //让lab像屏幕下方移动
            }
            for (int i = 0; i < a1.Count; i++) //循环从hash移除 已经不显示的lab
            {
                _htlab.Remove(a1[i]);
            }
        }
        /// <summary>
        ///从屏幕产生字符
        /// </summary>
        /// <param name="value">产生速度-毫秒</param)
        /// <param name="font" >字体大小</param>
        public void create(int value, int font)
        {
            lblScore.Text = "第" + ((_count / 50) + 1) + "关 您的生命值: "
                + _life + " 分数: " + _count;
            this.timerlab.Interval = value; //设置产生速度毫秒
            Label lab = new Label();
            lab.AutoSize = true;
            lab.Font = new Font("Century Gothic", font,
                FontStyle.Regular, GraphicsUnit.Point, 0); //设置字体
            Random r = new Random();
            lab.ForeColor = Color.FromArgb(r.Next(100, 255),
              r.Next(100, 255), r.Next(100, 255)); //随机生成颜色
            //屏幕随机出现位置
            lab.Location = new Point((this.Size.Width - 50) -
              r.Next(0, (this.Size.Width - 50)), 28);
            string _char = new myRandom().getChar(1); //获取随机出来的字符
            string labname = ""; //lab名字
            int i = 0;//临时计数器存储当前界面上的1ab是否存在本次生成的字母个数
            foreach (DictionaryEntry de in _htlab)
            {
                if (de.Key.ToString().IndexOf(_char) != -1)
                {
                    i++;
                }
            }
            labname = _char + (i * DateTime.Now.Millisecond);
            lab.Name = labname; //设置1ab名字，防止打乱顺序
            lab.Text = _char; //让此lab显 示生成的字符
            this.Controls.Add(lab);
            //把本次随机出的1ab放入Hashtable集合，方便验证
            _htlab.Add(labname, lab);
        }

        private void FrmTypingGame_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DictionaryEntry de in _htlab)
            {
                if (de.Key.ToString().IndexOf(Convert.ToChar(e.KeyCode)) != -1)
                {
                    Label lab = (Label)_htlab[de.Key];
                    lab.BackColor = Color.White;
                    lab.Dispose(); //销毁1ab
                    _htlab.Remove(de.Key);//从hash移除已经不显示的1ab
                    _count++;
                    lblScore.Text = "第" + ((_count / 50) + 1) + "关 您的生命值: "
                        + _life + " 分数: " + _count;
                    break;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
