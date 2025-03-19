using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第一天学习作业
{
    public partial class Form1: Form
    {
        private Button testButton = new Button();
        public Form1()
        {
            InitializeComponent();
            //标签的手动编辑
            label1.Text = "登录系统页面";
            label1.Location = new Point(450,120);
            //按钮的手动编辑
            button1.Text = "提交";//文本
            button1.Location = new Point(800, 450);//位置（右上角距离）
            button1.Size = new Size(120, 75);//大小

            button2.Text = " 记住密码 ";
            button2.Location = new Point(800, 350);//位置（右上角距离）
            button2.Size = new Size(120, 75);//大小

        }   

        private void button1_click(object sender, EventArgs e)
        {
            
            MessageBox.Show("登录成功");//弹窗显示
           
            //Console.WriteLine("账号密码录入成功");---输出栏显示
        }

        private void Button2_click(object sender, EventArgs e)
        {
            MessageBox.Show("已经记住账号密码");
            //输出栏显示
            Console.WriteLine("记住密码成功");
        }
    }
}
