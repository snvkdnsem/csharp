﻿//p85
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DependenyPropertyTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public String Mytext
        {
            get { return (String)GetValue(MyProperty); }
            set { SetValue(MyProperty, value); }
        }

        public static readonly DependencyProperty MyProperty =
            DependencyProperty.Register(
                "MyText", // 의존속성의 지원을 받는 자원
                typeof(String),
                typeof(MainWindow),
                new FrameworkPropertyMetadata(new
                    PropertyChangedCallback(OnMyPropertyChanged)));
                
        private static void OnMyPropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = d as MainWindow;
            SolidColorBrush brush = (SolidColorBrush)new
                BrushConverter().ConvertFromString(e.NewValue.ToString());
            win.Background = brush;
            win.Title = (e.OldValue == null) ? "제목없음" : e.OldValue.ToString();
            win.textBox1.Text = e.NewValue.ToString();
        }

        private void ContextMenu_Click(object sender, RoutedEventArgs e)
        {
            string str = (e.Source as MenuItem).Header as string;
            Mytext = str; // 여기서 Mytext값이 바뀐다.
        }
    }
}
