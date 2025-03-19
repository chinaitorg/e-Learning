using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstProgram001
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            //自写点击事件
            button2.Click += new EventHandler(this.OnTest);
        }
        public void OnTest(object sendar,EventArgs e)
        {
            MessageBox.Show("开始");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("启动成功");
        }
    }
}
