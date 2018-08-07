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

namespace WriteFilesAsync方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Task WriteFilesAsync(string dirPath, int fileNum, ulong fileSize, IProgress<string> progessReport)
        {
            return Task.Run(() =>
            {
                Random rand = new Random();
                byte[] buffer = new byte[fileSize];
                string fullDirPath = Path.GetFullPath(dirPath);
                for (int n = 0; n < fileNum; n++)
                {
                    string fileFullPath = Path.Combine(fullDirPath, "file_" + (n + 1).ToString());
                    FileInfo fileInfo = new FileInfo(fileFullPath);
                    if (fileInfo.Exists)
                    {
                        fileInfo.Delete();
                    }
                    using (FileStream fs = fileInfo.Create())
                    {
                        rand.NextBytes(buffer);
                        BinaryWriter writer = new BinaryWriter(fs);
                        writer.Write(buffer);
                        writer.Flush();
                        writer.Close();
                    }
                    if (progessReport != null)
                    {
                        string msg = string.Format("文件{0}已成功写入" + Environment.NewLine, fileInfo.Name);
                        progessReport.Report(msg);
                    }
                }
            });
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text) == false)
            {
                Directory.CreateDirectory(textBox1.Text);
            }
            int fileNum = 0;
            if (!int.TryParse(textBox2.Text, out fileNum))
            {
                MessageBox.Show("请输入文件个数"); return;
            }
            ulong filesize = 0L;
            if (!ulong.TryParse(textBox3.Text,out filesize))
            {
                MessageBox.Show("请输入文件大小");return;
            }
            textBox4.Clear();
            IProgress<string> prr = null;
            prr = new Progress<string>((s) =>
            {
                textBox4.AppendText(s);
            });
            button1.Enabled = false;
            await WriteFilesAsync(textBox1.Text, fileNum, filesize, prr);
            button1.Enabled = true;
        }
    }               
}
