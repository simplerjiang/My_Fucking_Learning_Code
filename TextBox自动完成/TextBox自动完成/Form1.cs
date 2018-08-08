using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox自动完成
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb.Checked)
            {
                if (rdb.Text == "系统资源列表")
                {
                    textBox1.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
                }
                else
                    textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
    }
}
