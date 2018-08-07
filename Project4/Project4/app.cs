using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project4
{
    class app
    {
        [STAThread]
        static void Main(string[] cmdArgs)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Form mainWindow = new Form();
            mainWindow.Text = "我的标题"; // 窗口标题
            mainWindow.Size = new Size(220, 130); //大小
            mainWindow.Location = new Point(150, 85); //位置
            Application.Run(mainWindow);
        }
    }
}
