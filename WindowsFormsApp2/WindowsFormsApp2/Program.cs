using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class MyAppContext : ApplicationContext
    {
        static int WindowCount; // 记录窗体个数

        private Form window1, window2, window3;
        public MyAppContext()
        {
            WindowCount = 0;
            window1 = new Form();
            window1.Text = "窗口1";
            window1.Size = new System.Drawing.Size(300, 200);
            window1.Location = new System.Drawing.Point(50, 200);
            window1.Name = "form1"; // 窗口名字
            window1.FormClosed += onWindowClosed;
            WindowCount += 1;
            window2 = new Form();
            window2.Text = "窗口2";
            window2.Size = new System.Drawing.Size(160, 270);
            window2.Location = new System.Drawing.Point(250, 69);
            window2.Name = "form2";
            window2.FormClosed += onWindowClosed; //关闭时的事件句柄
            WindowCount += 1;
            window3 = new Form();
            window3.Text = "窗口3";
            window3.Size = new System.Drawing.Size(320, 200);
            window3.Location = new System.Drawing.Point(300, 180);
            window3.Name = "form3";
            window3.FormClosed += onWindowClosed;
            WindowCount += 1;

            window1.Show();
            window3.Show();
            window2.Show();
        }
        private void onWindowClosed(object sender, FormClosedEventArgs e)
        {
            WindowCount -= 1;
            if (WindowCount == 0)
            {
                ExitThread();
            }
        }
    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MyAppContext());
        }
    }
}
