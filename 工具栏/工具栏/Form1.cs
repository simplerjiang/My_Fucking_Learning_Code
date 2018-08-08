using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 工具栏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.toolStrip1.ImageList = this.imageList1;
            this.toolBtnAdd.ImageIndex = 0;
            this.toolBtnAccept.ImageIndex = 1;
            this.toolBtnEdit.ImageIndex = 2;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem is ToolStripButton)
            {
                if (e.ClickedItem == toolBtnSubmet)
                {
                    if(txttoolKeyword.Text !="")
                    {
                        MessageBox.Show(string.Format("您输入的关键字是:{0}", txttoolKeyword));
                    }
                }
            }
        }
    }
}
