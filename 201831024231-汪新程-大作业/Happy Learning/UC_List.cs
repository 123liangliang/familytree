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
    public partial class UC_List : UserControl
    {
        public UC_List()
        {
            InitializeComponent();
        }

        private void UC_List_Load(object sender, EventArgs e)
        {

        }

        private void btnLeftToRight_Click(object sender, EventArgs e)
        {
            if (this.listWishes.SelectedItem != null)
            {
                this.listRealized.Items.Add(this.listWishes.SelectedItem);
                this.listWishes.Items.Remove(this.listWishes.SelectedItem);
            }
        }

        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            if (this.listRealized.SelectedItem != null)
            {
                this.listWishes.Items.Add(this.listRealized.SelectedItem);
                this.listRealized.Items.Remove(this.listRealized.SelectedItem);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string addedText = this.txtAddWishes.Text.Trim();
            if (addedText.Length < 1)
            {
                MessageBox.Show("愿望为空哟！");
                return;
            }
            if (this.listWishesPool.Items.Contains(addedText))
                MessageBox.Show("愿望<" + addedText + ">在列表中已经存在！");
            else
                this.listWishesPool.Items.Add(addedText);
            this.txtAddWishes.Clear();

        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            while (this.listWishesPool.SelectedIndex >= 0)
                this.listWishesPool.Items.RemoveAt(this.listWishesPool.SelectedIndex);

        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            this.listWishesPool.Items.Clear();

        }
    }
}
