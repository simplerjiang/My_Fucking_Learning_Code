using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CancellationTokenSource cts = null;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            BigInteger baseNum = 0;
            if (!BigInteger.TryParse(textBox2.Text, out baseNum))
            {
                MessageBox.Show("请输入一个整数作为基数。");
                return;
            }
            IProgress<int> progress = new Progress<int>((p) => progressBar1.Value = p);
            if (cts != null)
            {
                cts.Dispose();
            }
            cts = new CancellationTokenSource();

            Task<BigInteger> task = new Task<BigInteger>(() =>
            {
                BigInteger bint = new BigInteger(1d);
                double totalProgress = (double)baseNum;
                for (int n = 1; n <= baseNum && !cts.IsCancellationRequested; n++)
                {
                    bint*=n;
                    double pr = Convert.ToDouble(n) / totalProgress * 100d;
                    progress.Report(Convert.ToInt32(pr));
                }
                return bint;
            },cts.Token,TaskCreationOptions.LongRunning);
            task.Start();
            button1.Enabled = false;
            button2.Enabled = true;
            while (!task.Wait(50))
            {
                Application.DoEvents();
            }
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Text = "计算结果:" + task.Result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }
    }
}
