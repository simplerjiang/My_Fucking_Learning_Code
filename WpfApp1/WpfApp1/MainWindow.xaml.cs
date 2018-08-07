﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.mvs.FillBrush = Brushes.Red;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.mvs.FillBrush = Brushes.Green;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.mvs.FillBrush = Brushes.Blue;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.mvs.FillBrush = Brushes.Black;
        }
    }
}
