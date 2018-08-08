using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自行绘制列表控件值
{
    public partial class Form1 : Form
    {
        const float FONT_SIZE = 16f;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            string itemText = (sender as ListBox).Items[e.Index] as string;
            using (Font font = new Font(itemText, FONT_SIZE))
            {
                SizeF size = e.Graphics.MeasureString(itemText, font);
                e.ItemHeight = Convert.ToInt32(size.Height);
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            string itemText = (sender as ListBox).Items[e.Index] as string;
            using (Font font = new Font(itemText, FONT_SIZE))
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                e.DrawBackground();
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.DrawString(itemText, font, SystemBrushes.ControlText, e.Bounds, sf);
                }
                sf.Dispose();
            }
        }
    }
}
