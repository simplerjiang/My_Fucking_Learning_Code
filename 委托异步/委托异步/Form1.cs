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
namespace 委托异步
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baseNum = default(int);
            if (!int.TryParse(textBox1.Text, out baseNum))
            {
                MessageBox.Show("请输入一个整数！");
                return;
            }
            textBox2.Clear();
            IProgress<int> progressReport = new Progress<int>((p) => { this.progressBar1.Value = p; });
            Func<int, BigInteger> ComputeAction = (bsNum) =>
             {
                 BigInteger bi = new BigInteger(1);
                 for (int i = 1; i <= bsNum; i++)
                 {
                     bi *= i;
                     double ps = Convert.ToDouble(i) / Convert.ToDouble(bsNum) * 100d;
                     this.BeginInvoke(new Action<string>((b) =>
                     {
                         this.textBox2.AppendText(b + Environment.NewLine);
                     }),bi.ToString());
                     progressReport.Report(Convert.ToInt32(ps));
                 }
                 return bi;
             };
            button1.Enabled = false;
            ComputeAction.BeginInvoke(baseNum, new AsyncCallback(FinishCallBack), ComputeAction);
        }
        private void FinishCallBack(IAsyncResult ar)
        {
            Func<int, BigInteger> action = (Func<int, BigInteger>)ar.AsyncState;
            BigInteger res = action.EndInvoke(ar);
            this.BeginInvoke(new Action(() =>
            {
                button1.Enabled = true;
                textBox2.AppendText(string.Format("计算结果{0}", res));
            }));
        }
    }
}
