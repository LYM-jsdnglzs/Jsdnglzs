using System;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;


namespace 教室电脑管理助手
{
    public partial class Form1 : Form
    {
        private string _filePath;
        private bool _isInitialMode = false;
      
        public Form1()
        {
            InitializeComponent();
            _filePath = Path.Combine(Application.StartupPath, "PW.json");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "PW.json");


            // 场景1: 文件不存在 -> 进入初始化模式
            if (!File.Exists(filePath))
            {
                // 无需弹窗提示（用户要求不显示欢迎信息）
                _isInitialMode = true;
                return;
            }

            // 场景2: 文件存在 -> 读取内容
            string[] lines = File.ReadAllLines(filePath);

            // 文件内容格式错误处理
            if (lines.Length < 1)
            {
                MessageBox.Show("配置文件损坏，请重新设置", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            
            // 判断第一行标识
            if (lines[0] == "T")
            {
                string targetLine = lines[1];
                // 已初始化模式：强制验证密码
                if (lines.Length < 2 || lines[1] != targetLine)
                {
                    MessageBox.Show("密码错误，程序即将退出", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit(); // 直接终止程序
                }
                else
                {
                    _isInitialMode = false; // 正常模式
                }
            }
            else if (lines[0] == "F")
            {
                // 未完成初始化模式
                _isInitialMode = true;
            }
            else
            {
                MessageBox.Show("无效的配置文件", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {

            bool fileExists = File.Exists(_filePath);
            string[] lines = fileExists ? File.ReadAllLines(_filePath) : null;

            // 判断是否处于初始化模式（文件不存在或第一行为F）
            bool isInitialMode = !fileExists || (lines.Length > 0 && lines[0] == "F");

            if (isInitialMode)
            {
                // 初始化模式：保存密码
                string password = textBox1.Text.Trim();
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("密码不能为空");
                    return;
                }

                try
                {
                    File.WriteAllText(_filePath, $"T\n{password}");
                    MessageBox.Show("密码设置成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存失败: {ex.Message}");
                }
            }
            else
            {
                // 已初始化模式：验证密码
                if (lines.Length < 2)
                {
                    MessageBox.Show("密码文件损坏，请重新设置");
                    return;
                }

                string inputPassword = textBox1.Text.Trim();
                string savedPassword = lines[1];

                if (inputPassword == savedPassword)
                {
                    string IPW = textBox1.Text;

                     fun.form2 = new Form2();
                    fun.form2.FormClosed += (s, args) => this.Close();  // 当 Form2 关闭时，关闭 Form1
                    fun.form2.Show();      // 显示 Form2
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("密码错误");
                }
            }
        }
    }
}
            
    

