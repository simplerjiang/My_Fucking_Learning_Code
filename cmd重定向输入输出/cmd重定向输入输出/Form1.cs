using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace cmd重定向输入输出
{
    public delegate void DelReadStdOutput(string result);
    public delegate void DelReadErrOutput(string result);

    public partial class Form1 : Form
    {
        public event DelReadErrOutput ReadErrOutput;
        public event DelReadStdOutput ReadStdOutput;
        public Form1()
        {
            InitializeComponent();
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
        }
        //3.将相应函数注册到委托事件中  

        private void RealAction(string StartFileName, string StartFileArg)
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
                                                                // 参数  
            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                                                                //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  

            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);
            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess.Start();
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();
            CmdProcess.StandardInput.WriteLine(StartFileArg);


            // 如果打开注释，则以同步方式执行命令，此例子中用Exited事件异步执行。  
            // CmdProcess.WaitForExit();       
        }
        private int Time { get; set; }
        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
            string[] a = result.Split('\n');
            foreach (string i in a)
            {
                this.textBox2.AppendText("输出："+i + Environment.NewLine);
            }
        }

        private void ReadErrOutputAction(string result)
        {
            this.textBox2.AppendText("错误："+result + Environment.NewLine);
        }

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                textBox2.AppendText("结束！");
            }));
            this.Dispose();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RealAction("cmd.exe", textBox1.Text);
        }
    }
}
