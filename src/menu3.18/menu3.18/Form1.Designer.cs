
namespace menu3._18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent(EventHandler load)
        {
            InitializeComponent(load, menuStrip1);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(EventHandler load, MenuStrip menuStrip1)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            菜单ToolStripMenuItem = new ToolStripMenuItem();
            menuopen = new ToolStripMenuItem();
            menuclose = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuexit = new ToolStripMenuItem();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            打开ToolStripMenuItem1 = new ToolStripMenuItem();
            关闭ToolStripMenuItem1 = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            打开ToolStripMenuItem2 = new ToolStripMenuItem();
            关闭ToolStripMenuItem2 = new ToolStripMenuItem();
            搜索ToolStripMenuItem = new ToolStripMenuItem();
            打开ToolStripMenuItem3 = new ToolStripMenuItem();
            关闭ToolStripMenuItem3 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStrip2 = new ToolStrip();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 菜单ToolStripMenuItem, 文件ToolStripMenuItem, 帮助ToolStripMenuItem, 搜索ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            菜单ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuopen, menuclose, toolStripSeparator1, menuexit });
            菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            菜单ToolStripMenuItem.Size = new Size(44, 21);
            菜单ToolStripMenuItem.Text = "菜单";
            // 
            // menuopen
            // 
            menuopen.Name = "menuopen";
            menuopen.Size = new Size(180, 22);
            menuopen.Text = "打开";
            menuopen.Click += menuopen_Click;
            // 
            // menuclose
            // 
            menuclose.Name = "menuclose";
            menuclose.Size = new Size(180, 22);
            menuclose.Text = "关闭";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // menuexit
            // 
            menuexit.Name = "menuexit";
            menuexit.Size = new Size(180, 22);
            menuexit.Text = "退出";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 打开ToolStripMenuItem1, 关闭ToolStripMenuItem1 });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem1
            // 
            打开ToolStripMenuItem1.Name = "打开ToolStripMenuItem1";
            打开ToolStripMenuItem1.Size = new Size(100, 22);
            打开ToolStripMenuItem1.Text = "打开";
            // 
            // 关闭ToolStripMenuItem1
            // 
            关闭ToolStripMenuItem1.Name = "关闭ToolStripMenuItem1";
            关闭ToolStripMenuItem1.Size = new Size(100, 22);
            关闭ToolStripMenuItem1.Text = "关闭";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 打开ToolStripMenuItem2, 关闭ToolStripMenuItem2 });
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(44, 21);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 打开ToolStripMenuItem2
            // 
            打开ToolStripMenuItem2.Name = "打开ToolStripMenuItem2";
            打开ToolStripMenuItem2.Size = new Size(100, 22);
            打开ToolStripMenuItem2.Text = "打开";
            // 
            // 关闭ToolStripMenuItem2
            // 
            关闭ToolStripMenuItem2.Name = "关闭ToolStripMenuItem2";
            关闭ToolStripMenuItem2.Size = new Size(100, 22);
            关闭ToolStripMenuItem2.Text = "关闭";
            // 
            // 搜索ToolStripMenuItem
            // 
            搜索ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 打开ToolStripMenuItem3, 关闭ToolStripMenuItem3 });
            搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            搜索ToolStripMenuItem.Size = new Size(44, 21);
            搜索ToolStripMenuItem.Text = "搜索";
            // 
            // 打开ToolStripMenuItem3
            // 
            打开ToolStripMenuItem3.Name = "打开ToolStripMenuItem3";
            打开ToolStripMenuItem3.Size = new Size(100, 22);
            打开ToolStripMenuItem3.Text = "打开";
            // 
            // 关闭ToolStripMenuItem3
            // 
            关闭ToolStripMenuItem3.Name = "关闭ToolStripMenuItem3";
            关闭ToolStripMenuItem3.Size = new Size(100, 22);
            关闭ToolStripMenuItem3.Text = "关闭";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripLabel1, toolStripComboBox1 });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources._20200202134150_uavri;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources._20200202134150_uavri;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources._20200202134150_uavri;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ForeColor = Color.CornflowerBlue;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(44, 22);
            toolStripLabel1.Text = "工具栏";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 25);
            toolStripComboBox1.Click += toolStripComboBox1_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.Location = new Point(0, 50);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(800, 25);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            load += this.Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 菜单ToolStripMenuItem;
        private ToolStripMenuItem menuopen;
        private ToolStripMenuItem menuclose;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 打开ToolStripMenuItem1;
        private ToolStripMenuItem 关闭ToolStripMenuItem1;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 打开ToolStripMenuItem2;
        private ToolStripMenuItem 关闭ToolStripMenuItem2;
        private ToolStripMenuItem 搜索ToolStripMenuItem;
        private ToolStripMenuItem 打开ToolStripMenuItem3;
        private ToolStripMenuItem 关闭ToolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuexit;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStrip toolStrip2;
        private readonly EventHandler Form1_Load;
    }
}
