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

namespace 线程锁
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int TicketNum = 10;
        private object lockObject = new object();
        private void Sell()
        {
            lock (lockObject)
            {
                if (TicketNum > 0)
                {
                    Thread.Sleep(300);
                    TicketNum--;
                    string msg = string.Format("还剩余{0}张机票\n", TicketNum);
                    this.BeginInvoke(new Action(()=>
                    {
                        textBox1.AppendText(msg);
                    }));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicketNum = 10;
            textBox1.Clear();
            Thread[] ths = new Thread[15];
            for (int x = 0; x<15;x++)
            {
                ths[x] = new Thread(Sell);
            }
            foreach(Thread t in ths)
            {
                t.Start();
            }
        }
    }
}
