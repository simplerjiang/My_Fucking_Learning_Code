using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnRadiobuttonCheckedChanged(object sender, EventArgs e)
        {
            if (this.listBox1 == null)
            {
                return;
            }
            RadioButton rdbutton = sender as RadioButton;
            if (rdbutton.Checked)
            {
                string txt = rdbutton.Text;
                listBox1.SelectionMode = (SelectionMode)Enum.Parse(typeof(SelectionMode), txt);
            }

        }
    }
}
