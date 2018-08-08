using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图像的定位
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            string[] values = Enum.GetNames(typeof(PictureBoxSizeMode)); //获取所有方式
            comboBox1.Items.AddRange(values);  // 放上所有方式
            comboBox1.SelectedIndex = 0;
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = comboBox1.SelectedItem as string; // 获取选中的内容
            PictureBoxSizeMode sizeMode = (PictureBoxSizeMode)Enum.Parse(typeof(PictureBoxSizeMode),val);
            pictureBox1.SizeMode = sizeMode;
        }
    }
}
