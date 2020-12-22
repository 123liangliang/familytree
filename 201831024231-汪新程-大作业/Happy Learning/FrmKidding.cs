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
    public partial class FrmKidding : Form
    {
        public FrmKidding()
        {
            InitializeComponent();
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just Kidding!!!", "SURPRISE!", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.BackColor = Color.FromArgb(249, 204, 226);
            this.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            FrmKidding myForm = new FrmKidding();
            this.Visible = false;
            Random rx = new Random();
            Random ry = new Random();
            myForm.Location = new Point(rx.Next(0, 650), ry.Next(0, 450));
            myForm.ShowDialog();
            this.Dispose();
        }
    }
}
