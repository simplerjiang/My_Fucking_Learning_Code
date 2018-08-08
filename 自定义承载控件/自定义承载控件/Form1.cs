using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自定义承载控件
{
    public partial class Form1 : Form
    {
        ToolStripDateTimePicker mndtPicker = null;
        public Form1()
        {
            InitializeComponent();
            mndtPicker = new ToolStripDateTimePicker();
            mndtPicker.MaxDate = new DateTime(2050, 12, 31);
            mndtPicker.MinDate = new DateTime(2000, 1, 1);
            DateTimePicker dnt = new DateTimePicker();
            报表ToolStripMenuItem.DropDownItems.Add(mndtPicker);
            mndtPicker.ValueChanged += mndtPicker_ValueChanged;
        }
        void mndtPicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("您选择了:" + mndtPicker.Value.ToLongDateString());
        }
    }
    #region 属性
    public class ToolStripDateTimePicker :ToolStripControlHost
    {
        private DateTimePicker m_Picker = null;
        public ToolStripDateTimePicker():base(new DateTimePicker())
        {
            m_Picker = base.Control as DateTimePicker;
            m_Picker.Format = DateTimePickerFormat.Custom;
            m_Picker.CustomFormat = "yyyy年MM月dd日";
        }
        public DateTime MaxDate
        {
            get { return m_Picker.MaxDate; }
            set { m_Picker.MaxDate = value; }
        }
        public DateTime MinDate
        {
            get { return m_Picker.MinDate; }
            set { m_Picker.MinDate = value; }
        }
        public DateTime Value
        {
            get { return m_Picker.Value; }
            set { m_Picker.Value = value; }
        }
        public DateTimePicker DateTimePicker
        {
            get { return m_Picker; }
        }
        public event EventHandler DropDown
        {
            add { m_Picker.DropDown += value; }
            remove { m_Picker.DropDown -= value; }
        }
        public event EventHandler ValueChanged
        {
            add { m_Picker.ValueChanged += value; }
            remove { m_Picker.ValueChanged -= value; }
        }
    }
    #endregion
}
