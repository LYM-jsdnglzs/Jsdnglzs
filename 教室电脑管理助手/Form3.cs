using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教室电脑管理助手
{
    public partial class Form3: Form
    {
        private string _filePath;
        public Form3()
        {
            InitializeComponent();
            _filePath = Path.Combine(Application.StartupPath, "PW.json");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "PW.json");
            string[] lines = File.ReadAllLines(filePath);
            string targetLine = lines[1];
            if (APW.Text == targetLine)
            {
                Form4 form4 = new Form4();
                this.Close();
                form4.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("密码错误");
            }
        }
    }
}
