using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 打开文件对话k
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                try
                {
                    using (System.IO.FileStream stream = System.IO.File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        Image img = Image.FromStream(stream);
                        pictureBox1.Image = img;
                        stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = null;
                try
                {
                    fileStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                    using (Bitmap bmp = new Bitmap(100, 100))
                    {
                        Graphics g = Graphics.FromImage(bmp);
                        g.Clear(Color.DarkBlue);
                        g.FillEllipse(Brushes.Yellow, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        g.Dispose();
                        bmp.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    MessageBox.Show("图像文件保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fileStream != null)
                    {
                        fileStream.Close();
                        fileStream.Dispose();
                    }
                }
            }
        }
    }
}
