using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自定义对话框1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TestDialog dialog = new TestDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = dialog.ShowDialog();
            this.button1.Text = "对话框结果：" + result.ToString();
        }
    }
}
