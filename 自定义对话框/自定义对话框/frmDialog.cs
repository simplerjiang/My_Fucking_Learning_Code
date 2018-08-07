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
    public partial class frmDialog : Form
    {
        public frmDialog()
        {
            InitializeComponent();
        }
        public string BookName
        {
            get { return this.txtBookname.Text; }
        }
        public string Category
        {
            get { return this.comboBox2.SelectedItem as string; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBookname.Text.Length == 0)
            {
                lblMsg.Text = "请输入图书名称";
                DialogResult = DialogResult.None; //保持不关闭
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
