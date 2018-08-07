using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自定义对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmDialog dialong = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dialong == null)
            {
                this.dialong = new frmDialog();
            }
            if (this.dialong.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = string.Format("图书名称:{0}\r\n图书分类{1}", dialong.BookName, dialong.Category);
            }
        }
    }
}
