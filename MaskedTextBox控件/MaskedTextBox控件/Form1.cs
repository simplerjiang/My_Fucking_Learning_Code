using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string No { get; set; }
        public Employee(string name,string no)
        {
            Name = name;
            No = no;
        }
        public Employee() : this(string.Empty, string.Empty) { }
        public static Employee Parse(string info)
        {
            if (string.IsNullOrWhiteSpace(info))
            {
                throw new ArgumentException("字符串参数不能为空");
            }
            int index = info.IndexOf();
        }
    }
}
