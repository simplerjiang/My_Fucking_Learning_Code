using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 选项卡
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 2) //如果要跳转到第三页，需要检测
            {
                if (username_box.Text == "" ||password_box.Text==""||email_box.Text==""|| info_txt.Text==""||(info_txt.Text).Length<20)
                {
                    e.Cancel = true;
                    MessageBox.Show(string.Format("{0}{1}{2}{3}{4}",username_box.Text == "", password_box.Text == "", email_box.Text == "", page2.Text == "", info_txt.Text));
                }
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 2)
            {
                textBox2.Text = string.Format("用户名:{0}" +
                    "\r\n密码:{1}" +
                    "\r\n电子邮件地址：{2}" +
                    "\r\n个人简介:{3}", username_box.Text, password_box.Text, email_box.Text, info_txt.Text);
            }
        }
    }
}
