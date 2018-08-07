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

namespace 创建与删除目录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("输入！");
                return;
            }
            filename = textBox1.Text;
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            File.Create(filename).Close();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(false);
                bw.Write((int)20045);
                bw.Write("Hello");
                bw.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                File.Delete(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool b;
            int n;
            string s;

            using (FileStream fsIn = File.OpenRead(textBox1.Text))
            {
                BinaryReader br = new BinaryReader(fsIn);
                b = br.ReadBoolean();
                n = br.ReadInt32();
                s = br.ReadString();
                br.Close();
            }
            MessageBox.Show(b.ToString() + n.ToString() + s);
        }

    }
}
