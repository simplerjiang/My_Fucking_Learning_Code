using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 复杂对象列表箱子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = GetDate();
            listBox1.DisplayMember = "EmpName";
            listBox1.ValueMember = "EmpID";
        }
        private List<Employee> GetDate()
        {
            return new List<Employee>
            {
                new Employee{EmpID = "E-1001",EmpName="小方" },
                new Employee{EmpID = "A-1111",EmpName="小江" }
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (listBox1.SelectedIndex > -1)
            {
                string empID = listBox1.SelectedValue.ToString();
                btn.Text = string.Format("当前{0}", empID);
            }
        }
    }
}
