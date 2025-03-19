namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.alfTextBox1 = new WindowsFormsApp2.AlfTextBox();
            this.SuspendLayout();
            // 
            // alfTextBox1
            // 
            this.alfTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.alfTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alfTextBox1.Location = new System.Drawing.Point(301, 130);
            this.alfTextBox1.Name = "alfTextBox1";
            this.alfTextBox1.Size = new System.Drawing.Size(245, 47);
            this.alfTextBox1.TabIndex = 0;
            this.alfTextBox1.Text = "dadada";
            this.alfTextBox1.UseWaitCursor = true;
            this.alfTextBox1.ReturnPressed += new System.EventHandler(this.alfTextBox1_ReturnPressed);
            this.alfTextBox1.Load += new System.EventHandler(this.alfTextBox1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alfTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AlfTextBox alfTextBox1;

    }
}

