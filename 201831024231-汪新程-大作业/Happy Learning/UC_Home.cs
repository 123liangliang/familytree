using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Learning
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            //获取已经被选中的按钮的Text属性值,并将其存放在PassList.passData之中
            PassList.passData ="";
            foreach (object chkbox in this.grbApps.Controls)
            {
                if (chkbox is CheckBox)
                {
                    if (((CheckBox)chkbox).Checked)
                        PassList.passData += " " + ((CheckBox)chkbox).Text; //循环获取已经被选中的按钮的Text属性值
                }
            }
        }

    }
}
