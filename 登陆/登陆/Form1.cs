using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登陆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_box.Text.Trim())||string.IsNullOrWhiteSpace(password_box.Text.Trim()))
            {
                MessageBox.Show("请输入用户名或密码");
                return;
            }
            if (username_box.Text.Trim() == "admin" && password_box.Text.Trim() == "123")
            {
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
