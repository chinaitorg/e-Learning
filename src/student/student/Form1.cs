using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentInfoApp
{
    public partial class Form1 : Form
    {
        // 文件路径
        private readonly string filePath = "students.txt";

        public Form1()
        {
            InitializeComponent();
            LoadStudents(); // 启动时加载学生信息
        }

        // 保存学生信息
        private void SaveStudent(string name, int age, string gender)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{name},{age},{gender}");
            }
        }

        // 加载学生信息
        private void LoadStudents()
        {
            if (File.Exists(filePath))
            {
                listBoxStudents.Items.Clear(); // 清空列表
                foreach (string line in File.ReadAllLines(filePath))
                {
                    listBoxStudents.Items.Add(line);
                }
            }
        }

        // 保存按钮点击事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = (int)nudAge.Value;
            string gender = cmbGender.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("请输入完整的学生信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveStudent(name, age, gender);
            LoadStudents(); // 刷新列表
            MessageBox.Show("学生信息已保存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 清除按钮点击事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            nudAge.Value = 0;
            cmbGender.SelectedIndex = -1;
        }
    }
}