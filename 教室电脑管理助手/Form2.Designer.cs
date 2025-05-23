namespace 教室电脑管理助手
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.K11 = new System.Windows.Forms.Label();
            this.K22 = new System.Windows.Forms.Label();
            this.K33 = new System.Windows.Forms.Label();
            this.K44 = new System.Windows.Forms.Label();
            this.K55 = new System.Windows.Forms.Label();
            this.K66 = new System.Windows.Forms.Label();
            this.K77 = new System.Windows.Forms.Label();
            this.K88 = new System.Windows.Forms.Label();
            this.K99 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.K100 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("宋体", 35F);
            this.labelTime.Location = new System.Drawing.Point(24, 26);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(240, 70);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("宋体", 20F);
            this.labelDateTime.Location = new System.Drawing.Point(26, 110);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(277, 40);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "labelDateTime";
            // 
            // K11
            // 
            this.K11.AutoSize = true;
            this.K11.Location = new System.Drawing.Point(41, 184);
            this.K11.Name = "K11";
            this.K11.Size = new System.Drawing.Size(17, 18);
            this.K11.TabIndex = 2;
            this.K11.Text = "1";
            this.K11.Click += new System.EventHandler(this.K11_Click);
            // 
            // K22
            // 
            this.K22.AutoSize = true;
            this.K22.Location = new System.Drawing.Point(41, 223);
            this.K22.Name = "K22";
            this.K22.Size = new System.Drawing.Size(17, 18);
            this.K22.TabIndex = 3;
            this.K22.Text = "2";
            // 
            // K33
            // 
            this.K33.AutoSize = true;
            this.K33.Location = new System.Drawing.Point(41, 264);
            this.K33.Name = "K33";
            this.K33.Size = new System.Drawing.Size(17, 18);
            this.K33.TabIndex = 4;
            this.K33.Text = "3";
            // 
            // K44
            // 
            this.K44.AutoSize = true;
            this.K44.Location = new System.Drawing.Point(41, 300);
            this.K44.Name = "K44";
            this.K44.Size = new System.Drawing.Size(17, 18);
            this.K44.TabIndex = 5;
            this.K44.Text = "4";
            // 
            // K55
            // 
            this.K55.AutoSize = true;
            this.K55.Location = new System.Drawing.Point(41, 340);
            this.K55.Name = "K55";
            this.K55.Size = new System.Drawing.Size(17, 18);
            this.K55.TabIndex = 6;
            this.K55.Text = "5";
            // 
            // K66
            // 
            this.K66.AutoSize = true;
            this.K66.Location = new System.Drawing.Point(41, 376);
            this.K66.Name = "K66";
            this.K66.Size = new System.Drawing.Size(17, 18);
            this.K66.TabIndex = 7;
            this.K66.Text = "6";
            // 
            // K77
            // 
            this.K77.AutoSize = true;
            this.K77.Location = new System.Drawing.Point(41, 416);
            this.K77.Name = "K77";
            this.K77.Size = new System.Drawing.Size(17, 18);
            this.K77.TabIndex = 8;
            this.K77.Text = "7";
            // 
            // K88
            // 
            this.K88.AutoSize = true;
            this.K88.Location = new System.Drawing.Point(41, 454);
            this.K88.Name = "K88";
            this.K88.Size = new System.Drawing.Size(17, 18);
            this.K88.TabIndex = 9;
            this.K88.Text = "8";
            // 
            // K99
            // 
            this.K99.AutoSize = true;
            this.K99.Location = new System.Drawing.Point(41, 499);
            this.K99.Name = "K99";
            this.K99.Size = new System.Drawing.Size(17, 18);
            this.K99.TabIndex = 10;
            this.K99.Text = "9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(118, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 427);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "作业";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(1, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 125);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "英语(其他)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 27);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(207, 95);
            this.textBox3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(1, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 125);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数学";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(207, 95);
            this.textBox2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(0, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "语文";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(208, 95);
            this.textBox1.TabIndex = 0;
            // 
            // K100
            // 
            this.K100.AutoSize = true;
            this.K100.Location = new System.Drawing.Point(42, 542);
            this.K100.Name = "K100";
            this.K100.Size = new System.Drawing.Size(26, 18);
            this.K100.TabIndex = 12;
            this.K100.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 630);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "关于...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 1050);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.K100);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.K99);
            this.Controls.Add(this.K88);
            this.Controls.Add(this.K77);
            this.Controls.Add(this.K66);
            this.Controls.Add(this.K55);
            this.Controls.Add(this.K44);
            this.Controls.Add(this.K33);
            this.Controls.Add(this.K22);
            this.Controls.Add(this.K11);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label K11;
        private System.Windows.Forms.Label K22;
        private System.Windows.Forms.Label K33;
        private System.Windows.Forms.Label K44;
        private System.Windows.Forms.Label K55;
        private System.Windows.Forms.Label K66;
        private System.Windows.Forms.Label K77;
        private System.Windows.Forms.Label K88;
        private System.Windows.Forms.Label K99;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label K100;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}