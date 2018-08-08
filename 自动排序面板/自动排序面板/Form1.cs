using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自动排序面板
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] names = Enum.GetNames(typeof(FlowDirection));
            comboBox1.Items.AddRange(names);
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem as string;
            FlowDirection fd = (FlowDirection)Enum.Parse(typeof(FlowDirection), item);
            this.flowLayoutPanel1.FlowDirection = fd;
        }
    }
}
