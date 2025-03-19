using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _313program
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            searchbox1.edit.Text = "fake";
            //添加事件处理(添加委托)
            searchbox1.btn.Click += new EventHandler(this.searchbox1_SearchEvent);

        }
        private void searchbox1_SearchEvent(object sender,EventArgs e)
        {
            MessageBox.Show("开始搜索" + searchbox1.edit.Text);
        }
       
    }

  }
