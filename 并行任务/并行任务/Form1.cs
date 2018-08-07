using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 并行任务
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int num1))
            {
                MessageBox.Show("Error!");
                return;
            }
            if (!int.TryParse(textBox2.Text, out int num2))
            {
                MessageBox.Show("Error!");
                return;
            }
            if (!int.TryParse(textBox3.Text, out int num3))
            {
                MessageBox.Show("Error!");
                return;
            }
            Action act1 = () =>
            {
                int sum = 0;
                for (int x = 1; x <= num1; x++)
                {
                    sum += x;
                }
                label1.BeginInvoke(new Action(() => { label1.Text = string.Format("{0}", sum); }));
            };
            Action act2 = () =>
            {
                int sum = 0;
                for (int x = 1; x <= num2; x++)
                {
                    sum += x;
                }
                label2.BeginInvoke(new Action(() => { label2.Text = string.Format("{0}", sum); }));
            };
            Action act3 = () =>
            {
                int sum = 0;
                for (int x = 1; x <= num3; x++)
                {
                    sum += x;
                }
                label3.BeginInvoke(new Action(() => { label3.Text = string.Format("{0}", sum); }));
            };
            Parallel.Invoke(act1,act2,act3);
        }
    }
}
