using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z顺序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Paint += label1_Paint;
            label2.Paint += label2_Paint;
            label3.Paint += label3_Paint;
            label1.MouseClick += OnLabelMouseClick;
            label2.MouseClick += OnLabelMouseClick;
            label3.MouseClick += OnLabelMouseClick;
        }
        void label3_Paint(object sender, PaintEventArgs e)
        {
            Label lb = sender as Label;
            Pen pen = new Pen(Color.Yellow, 15f);
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, lb.Width, lb.Height));
            pen.Dispose();
        }
        void label2_Paint(object sender, PaintEventArgs e)
        {
            Label lb = sender as Label;
            Pen pen = new Pen(Color.Blue, 15f);
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, lb.Width, lb.Height));
            pen.Dispose();
        }
        void label1_Paint(object sender, PaintEventArgs e)
        {
            Label lb = sender as Label;
            Pen pen = new Pen(Color.Red, 15f);
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, lb.Width, lb.Height));
            pen.Dispose();
        }
        private void OnLabelMouseClick(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                c.BringToFront();
            }
            else if (e.Button == MouseButtons.Right)
            {
                c.SendToBack();
            }
        }
    }
}
