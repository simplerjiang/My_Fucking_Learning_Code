using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace 实时报告进度
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Flag = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            long baseNumber = (long)e.Argument;
            BigInteger result = new BigInteger(1L);
            long currentVal = 1L;
            while (currentVal <= baseNumber)
            {
                if (bw.CancellationPending)
                {
                    Flag = true;
                    return;
                }
                result *= currentVal;
                int currentProgress = (int)(((float)currentVal) / ((float)baseNumber) * 100f);
                bw.ReportProgress(currentProgress);
                currentVal++;
            }
            e.Result = result;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Flag)
            {
                txtResult.AppendText("\n用户已取消");
            }
            else if (e.Error !=null)
            {
                txtResult.AppendText("\n错误信息：" + e.Error.Message);
                return;
            }
            else
            {
                txtResult.AppendText("\n计算完成");
                txtResult.AppendText("\r\n计算结果：" + e.Result.ToString());
            }
            
            btnStart.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            long baseNum = default(long);
            if (!long.TryParse(textBox1.Text, out baseNum))
            {
                txtResult.Text = "输入的基数格式错误。";
                return;
            }
            txtResult.Clear();
            txtResult.Text = "开始计算！";
            backgroundWorker1.RunWorkerAsync(baseNum);
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
