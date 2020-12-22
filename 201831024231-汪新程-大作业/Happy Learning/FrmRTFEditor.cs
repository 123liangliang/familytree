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
    public partial class FrmRTFEditor : Form
    {
        public FrmRTFEditor()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Enabled = true;//启用编辑区域
            this.richTextBox1.Clear();
            this.richTextBox1.Focus();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化OpenFileDialog对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"c:\";    //设置初始路径
            //设置格式过滤
            openFileDialog.Filter = "文本文件|*.txt|RTF文件|*.rtf|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            //选中“OK”按钮，并返回，则将选中的文件内容加载到文本框中
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.LoadFile(openFileDialog.FileName);//加载RTF格式文件
            }
            //若需要指定用于加载和保存 RichTextBox 控件数据的输入流和输出流的类型，则用以下方法
            //this.rtxContents.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"d:\";
            saveFileDialog.Filter = "文本文件|*.txt|RTF文件|*.rtf|所有文件|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                this.richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            this.richTextBox1.Clear();
            MessageBox.Show("文件已经保存！");
            this.richTextBox1.Enabled = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //Application.Exit();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.richTextBox1.SelectAll();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("建设中……");
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开一个颜色对话框，让用户选择一个颜色，将richTextBox内容设置为该颜色
            //ColorDialog
            //实例化一个ColorDialog的对象new
            //如果用户在颜色对话框选择了一个颜色，则
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() ==DialogResult.OK)
            {
                //设置颜色
                this.richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog()==DialogResult.OK)
            {
                this.richTextBox1.Font = fontDialog.Font;
            }
        }

        private void 新建ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMdiChild CldForm = new FrmMdiChild();
            CldForm.MdiParent = this;
            CldForm.Show();
        }
    }
}
