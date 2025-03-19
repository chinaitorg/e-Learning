using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1: Form
    {
        
        public Form1()
        {
            InitializeComponent();
            alfTextBox1.edit.Text += new EventHandler(this.alfTextBox1_ReturnPressed);
            alfTextBox1.edit.Text = "请输入";
        }
        public event EventHandler Return_Pressed;

        public void alfTextBox1_Load(object sender, EventArgs e)
        {

        }
        private void alfTextBox1_ReturnPressed(object sender, EventArgs e)
        {

            MessageBox.Show("你输入了" + alfTextBox1.edit.Text);
        }
    }
}
