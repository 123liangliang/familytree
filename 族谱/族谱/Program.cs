using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SWPU
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //先启动登录界面
            Login loginForm = new Login();
            loginForm.ShowDialog();
            //若Login窗体的DialogResult属性为OK,则运行MainForm窗体,作为整个程序的主界面
            if (loginForm.DialogResult == DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}
