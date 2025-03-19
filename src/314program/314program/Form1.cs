using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _314program
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("red");
            comboBox1.Items.Add("blue");
            comboBox1.Items.Add("green");
            listBox1.Items.Add(new Student(52211, "red"));
            listBox1.Items.Add(new Student(52212, "ppap"));
            listBox1.Items.Add(new Student(52213, "ppbp"));
            listBox1.Items.Add(new Student(52214, "ppcp"));
            listBox1.SetSelected(0, true);
            listBox1.SetSelected(2, true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("你选择了"+comboBox1.SelectedIndex+"行的"+comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            string Item = (string)comboBox1.SelectedItem;
            int index1 = index + 1;
            MessageBox.Show("下标为" + index1 + "\n" + "你选择了" + Item);

        }
    }
}
