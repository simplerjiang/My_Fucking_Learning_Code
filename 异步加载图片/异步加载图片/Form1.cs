using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 异步加载图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURI.Text))
            {
                MessageBox.Show("请输入URI", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            button1.Enabled = false;
            pictureBox1.LoadAsync(txtURI.Text);
        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lblMsg.Text = string.Format("当前进度：{0}%", e.ProgressPercentage);
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblMsg.Text = "错误信息:" + e.Error.Message;
                return;
            }
            if (e.Cancelled)
            {
                lblMsg.Text = "操作被取消";
            }
            else
            {
                lblMsg.Text = "加载完成";
            }
            button1.Enabled = true;
        }
    }
}
