using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread类
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DoWork()
        {
            int n = 0;
            while (n<100)
            {
                n++;
                Thread.Sleep(100);
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        this.progressBar1.Value = n;
                    }));
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            this.BeginInvoke(new Action(delegate ()
            {
                button1.Enabled = true;
                progressBar1.Value = 0;
                MessageBox.Show("操作完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(DoWork);
            button1.Enabled = false;
            thread.Start();
        }
    }
}
