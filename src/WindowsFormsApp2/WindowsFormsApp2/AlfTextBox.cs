using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    class AlfTextBox : UserControl
    {
        public TextBox edit;

        public void InitializeComponent()
        {
            this.edit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edit.Location = new System.Drawing.Point(22, 64);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 21);
            this.edit.TabIndex = 0;
            this.edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // AlfTextBox
            // 
            this.Controls.Add(this.edit);
            this.Name = "AlfTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public AlfTextBox()
        {
            InitializeComponent();
        }
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            //获得子控件
            if (this.Controls.Count == 0)
                return;
            Control c = this.Controls[0];
            //父窗口控件
            Padding p = this.Padding;
            int x = 0, y = 0;
            int w = this.Width, h = this.Height;
            w -= (p.Left + p.Right);
            x += p.Left;

            //计算文本的高度，使其在正中间
            int h2 = c.PreferredSize.Height;
            if (h2 > h) h2 = h;
            y = (h - h2) / 2;
            c.Location = new Point(x, y);
            c.Size = new Size(w, h2);
        }
        //等同于下
        //[Category("appearance")]//自写属性分区
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]//允许可见并且修改修改
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]//不可见不序列化
        //[Description]
        [Browsable(true)]//控制是否在属性页面展示（false）不展示
        public override string Text
        { get => base.Text; set => base.Text = value; }
        //public override string Text
        //{
        //     get { return edit.Text}
        //    set { edit.Text = value; }
        //}

        //改定义背景颜色
        //public override Color BackColor 
        //{ get => base.BackColor; set => base.BackColor = value; }
        public override Color BackColor
        {
            get
            { return edit.BackColor; }
            set
            {
                edit.BackColor = value;
                base.BackColor = value;
            }
        }
        public event EventHandler ReturnPressed;
        private void edit_KeyPress(object sender ,KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
            {
                ReturnPressed?.Invoke(this, e);
            }
        }
    }
}
