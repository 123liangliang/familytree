using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Learning
{
    public partial class FrmWarnig : Form
    {
        public FrmWarnig()
        {
            InitializeComponent();
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp frmSignup = new FrmSignUp();
            frmSignup.ShowDialog();
        }
    }
}
