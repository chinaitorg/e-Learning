using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.Runtime.Serialization;


namespace _3._12textprogram
{
    


    
    public partial class Form1 : Form
    {
        private string filePath = "C:\\Users\\Silergytest\\Desktop\\登录系统\\数据信息";
        
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = false;

        }
        //按键反馈代码
        private void myKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
            {
                string str = password.Text;
                MessageBox.Show("输入了" + str);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("checkedchanged");
            bool isChecked = checkBox1.Checked;
            if (isChecked)
            {
                password.PasswordChar = '\0';

            }
            else
            {
                password.PasswordChar = '*';
            }

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("click");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //选中并且提交，在button中返回选择
        private void button1_Click(object sender, EventArgs e)
        {
            int index = sex.SelectedIndex;//SelectedItem:选中项的值。null表示未选中
            string sel = (string)sex.SelectedItem;//选中项的索引,-1表示未选中
            MessageBox.Show("选择了" + sel);
        }

        private void combo_indexchanged(object sender, EventArgs e)
        {
            string sel = (string)sex.SelectedItem;
            MessageBox.Show("更改为" + sel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
           //想完成系统的保存加载功能
            MessageBox.Show("保存成功");
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // 检查文件是否存在
                if (File.Exists(filePath))
                {
                    // 从本地文件加载数据
                    string nameInput = name.Text;
                    string zhanghaoInput = zhanghao.Text;
                    string passwordInput = password.Text;
                    string sexInput = sex.Text;

                    // 将数据显示在文本框中
                    name.Text = nameInput;
                    zhanghao.Text = zhanghaoInput;
                    password.Text = passwordInput;
                    sex.Text = sexInput;

                    // 提示加载成功
                    MessageBox.Show("数据加载成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // 文件不存在时提示
                    MessageBox.Show("未找到保存的数据文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // 处理异常
                MessageBox.Show("加载数据时出错：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

