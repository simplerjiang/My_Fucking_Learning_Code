using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 用户控件
{
    public partial class MyColorRenderControl : UserControl
    {
        public MyColorRenderControl()
        {
            InitializeComponent();
            timer1.Interval = 3 * 1000;
            this.Load += (sender, e) =>
            {
                timer1.Start();
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            Color c = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            label1.ForeColor = c;
        }
    }
}
