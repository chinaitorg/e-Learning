using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 对话框3._17
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Console.WriteLine("选择的文件: " + filePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog.Title = "This is a saveFileDialog";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                MessageBox.Show("保存成功" + filePath);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog()==DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                this.Font = selectedFont;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {  // 改变大板的背景颜色
           // ColorDialog colorDialog = new ColorDialog();
           // if(colorDialog.ShowDialog()==DialogResult.OK)
           // {
           //     Color selectedColor = colorDialog.Color;
           //     this.BackColor = selectedColor;
           //      MessageBox.Show("显示的颜色是"+BackColor.Name);
           // }
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                button4.BackColor = selectedColor;
                //button4.ForeColor = selectedColor;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "雷猴啊";
            if(folderBrowserDialog.ShowDialog()==DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog.SelectedPath;
                MessageBox.Show("选择了"+selectedFolder);
            }
        }
    }
}
