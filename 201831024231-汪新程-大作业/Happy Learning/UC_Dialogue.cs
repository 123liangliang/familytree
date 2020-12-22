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
    public partial class UC_Dialogue : UserControl
    {
        public UC_Dialogue()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //实例化OpenFileDialog对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"c:\";    //设置初始路径
            //设置格式过滤
            openFileDialog.Filter = "RTF文件|*.rtf|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            //选中“OK”按钮，并返回，则将选中的文件内容加载到文本框中
            if (openFileDialog.ShowDialog() == DialogResult.OK) this.richTextBox1.LoadFile(openFileDialog.FileName);
            //若需要指定用于加载和保存 RichTextBox 控件数据的输入流和输出流的类型，则用以下方法	             	   	 	        
            //this.rtxContents.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog MySaveFileDialog = new SaveFileDialog();
            MySaveFileDialog.Filter = "文本文档(*.txt)|*.txt";
            MySaveFileDialog.CreatePrompt = true;
            MySaveFileDialog.OverwritePrompt = true;
            MySaveFileDialog.RestoreDirectory = true;
            if (MySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.SaveFile(MySaveFileDialog.FileName); 			   	                   
                //rtxContents.SaveFile(mySaveFileDialog.FileName, RichTextBoxStreamType.RichText);
                label1.Text = "状态：你要保存的文件为" + MySaveFileDialog.FileName;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyColorDialog = new ColorDialog();
            MyColorDialog.AllowFullOpen = true;
            MyColorDialog.AnyColor = true;
            if (MyColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.ForeColor = MyColorDialog.Color;
                this.label1.Text = "状态：将文本框中文字颜色设置为" + MyColorDialog.Color.ToString();
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //实例化Font对话框对象
            FontDialog fontDialog = new FontDialog();
            //保存文本框当前字体设置
            fontDialog.Font = richTextBox1.Font;
            fontDialog.Color = richTextBox1.ForeColor;
            fontDialog.AllowScriptChange = true;
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog.Font;   //设定RichTextBox的字体
                richTextBox1.ForeColor = fontDialog.Color;  //设定颜色
            }
        }
    }
}
