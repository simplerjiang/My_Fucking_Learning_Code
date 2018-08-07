using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace MyApp
{
    class MyVisual : UIElement
    {
        #region 注册依赖项属性
        public static readonly DependencyProperty FillBrushProperty = DependencyProperty.
            Register("FillBrush", typeof(Brush), typeof(MyVisual));
        #endregion
        #region 封装依赖项属性
        public Brush FillBrush
        {
            get { return (Brush)GetValue(FillBrushProperty); }
            set { SetValue(FillBrushProperty, value); }
        }
        #endregion
        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(this.FillBrush, null, new Rect(0d, 0d, 80d, 65d));
        }
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            if (e.Property == FillBrushProperty)
            {
                InvalidateVisual();
            }
        }
    }
}
