using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    class MyVisual:UIElement
    {
        public static readonly DependencyProperty FillBrushPoperty = DependencyProperty.Register("FillBrush", typeof(Brush), typeof(MyVisual), new PropertyMetadata(Brushes.Red, new PropertyChangedCallback(FillBrushPropertyChanged)));
        private static void FillBrushPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MyVisual v = d as MyVisual;
            v.InvalidateVisual();
        }
        public Brush FillBrush
        {
            get { return (Brush)GetValue(FillBrushPoperty); }
            set { SetValue(FillBrushPoperty, value); }
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            Size s = this.DesiredSize;
            double cx = s.Width;
            double cy = s.Height;
            drawingContext.DrawEllipse(this.FillBrush, null, new Point(cx, cy), 100d, 100d);
        }
        protected override Size MeasureCore(Size availableSize)
        {

            return new Size(300d, 300d);
        }
    }
}
