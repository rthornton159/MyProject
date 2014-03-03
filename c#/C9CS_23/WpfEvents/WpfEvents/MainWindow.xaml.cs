using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            button2.Click += new RoutedEventHandler(button2_Click);
        }

        void button2_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            textBlock1.Text = "Hi from Button2";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "Hello World!";
        }
    }
}
