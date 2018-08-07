using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;


namespace 自定义控件
{
    [DefaultProperty("HoverColor")]
    class MyControl:Control
    {
        protected override System.Drawing.Size DefaultSize
        {
            get
            {
                return new Size(100, 100);
            }
        }
        [Description("当鼠标指针位于控件上时的背景色")]
        public Color HoverColor
        {
            get
            {
                return m_hoverColor;
            }
            set
            {
                m_hoverColor = value;
                Invalidate(); //强制重绘
            }
        }
        private bool isMouseEnter = false; //检测鼠标是否进入客户区
        Color m_hoverColor;
        protected override void OnMouseEnter(EventArgs e) //复写
        {
            isMouseEnter = true; //当鼠标进入，修改变量
            Invalidate();
            base.OnMouseEnter(e); //调用父类方法
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            isMouseEnter = false; //当鼠标离开，变量改为false
            Invalidate();
            base.OnMouseLeave(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(BackColor); //用于填充背景的刷子
            if (isMouseEnter)
            {
                brush.Color = HoverColor;
            }
            e.Graphics.FillRectangle(brush, e.ClipRectangle);
            brush.Dispose();
        }
    }
}
