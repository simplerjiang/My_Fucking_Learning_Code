using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox示例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            DisplayCheckResult();
        }
        private void DisplayCheckResult()
        {
            if (label1 != null)
            {
                List<string> strList = new List<string>();
                if (checkBox1.Checked)
                {
                    strList.Add(checkBox1.Text);
                }
                if (checkBox2.Checked)
                {
                    strList.Add(checkBox2.Text);
                }
                if (checkBox3.Checked)
                {
                    strList.Add(checkBox3.Text);
                }
                string res = string.Join("、", strList.ToArray());
                label1.Text = string.Format("您已选择了：{0}", res);
            }
        }
    }
}
