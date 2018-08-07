using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int m_left, m_top, m_width, m_height;
            if (int.TryParse(txtLeft.Text, out m_left) == false)
            {
                m_left = 36;
            }
            if (int.TryParse(txtTop.Text, out m_top) == false)
            {
                m_top = 12;
            }
            if (int.TryParse(txtWidth.Text, out m_width) == false)
            {
                m_width = 80;
            }
            if (int.TryParse(txtHeigh.Text, out m_height) == false)
            {
                m_height = 25;
            }
            this.pnlChild.Left = m_height;
            this.pnlChild.Top = m_top;
            this.pnlChild.Width = m_width;
            this.pnlChild.Height = m_height;
        }
    }
}
