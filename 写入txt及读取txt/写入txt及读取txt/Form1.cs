using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 写入txt及读取txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                return;

            }
            File.WriteAllText(textBox3.Text, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox3.Text))
            {
                return;
            }
            textBox2.Text = File.ReadAllText(textBox3.Text);
        }
    }
}
