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
    public partial class UC_Users : UserControl
    {
        public UC_Users()
        {
            InitializeComponent();
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            lblName.Text ="姓名："+ PassUserName.passData;
        }
    }
}
