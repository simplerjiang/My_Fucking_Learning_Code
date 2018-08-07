using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 启动新进程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Process p = new Process())
            {
                ProcessStartInfo startinfo = new ProcessStartInfo("notepad.exe");
                p.StartInfo = startinfo;
                p.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uri = "http://www.baidu.com";
            Process.Start(uri);
        }
    }
}
