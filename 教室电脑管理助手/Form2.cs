using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教室电脑管理助手
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void  setLabel(Form4 frm)
        {
            K11.Text = frm.k1.Text;
            K22.Text = frm.k2.Text;
            K33.Text = frm.k3.Text;
            K44.Text = frm.k4.Text;
            K55.Text = frm.k5.Text;
            K66.Text = frm.k6.Text;
            K77.Text = frm.k7.Text;
            K88.Text = frm.k8.Text;
            K99.Text = frm.k9.Text;
            K100.Text = frm.k10.Text;

        }
        public void settextBox(Form4 frm)
        {
            textBox1.Text = frm.yuwen.Text;
            textBox2.Text = frm.shuxue.Text;
            textBox3.Text = frm.yingyu.Text;
            if (frm.checkBox1.Checked == true)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                
            }
            else
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 秒
            timer1.Tick += timer1_Tick;

            // 启动 Timer
            timer1.Start();

            // 初始时间显示
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            UpdateDateTimeDisplay();
        }
       
        private void UpdateDateTimeDisplay()
        {
            // 获取当前时间
            DateTime now = DateTime.Now;

            // 格式化日期和星期
            string datePart = now.ToString("MM月dd日");          // 例如：06月15日
            string weekPart = now.ToString("dddd", new CultureInfo("zh-CN")); // 例如：星期六
            string timePart = now.ToString("HH:mm:ss");          // 例如：15:30:45

            // 组合显示文本
            labelDateTime.Text = $"{datePart} {weekPart} {timePart}";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void K11_Click(object sender, EventArgs e)
        {

        }
    }
}
