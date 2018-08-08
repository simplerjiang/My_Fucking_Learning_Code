using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddSampleItems();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            string[] views = Enum.GetNames(typeof(View)); // 获取ListView 的各种方式，将View枚举里的所有内容转为字符串列表
            foreach (string s in views)
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedIndex = 0;
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string view = (sender as ComboBox).SelectedItem as string; // 获取被选中的字符串
            View v = (View)Enum.Parse(typeof(View), view); // 字符串转为view对象
            listView1.View = v; // 设置listview的view属性
        }
        private void AddSampleItems()
        {
            listView1.Items.Clear();
            ListViewItem item1 = new ListViewItem();
            item1.Text = "小陈";
            item1.ImageIndex = 0;
            item1.SubItems.Add("C语言入门");
            item1.SubItems.Add("3月6日");
            ListViewItem item2 = new ListViewItem();
            item2.Text = "小黄";
            item2.ImageIndex = 1;
            item2.SubItems.Add("VB实战");
            item2.SubItems.Add("2月27日");
            listView1.Items.AddRange(new ListViewItem[] { item1, item2 });
        }
    }
}
