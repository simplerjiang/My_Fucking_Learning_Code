using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 上下文菜单
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 绿色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Green;
        }

        private void 蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Blue;
        }

        private void 灰色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Gray;
        }
    }
}
