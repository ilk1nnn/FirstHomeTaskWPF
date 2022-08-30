using System;
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

namespace WpfApp2
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            Button btn = (Button)sender;
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)rand.Next(1, 255), (byte)rand.Next(1, 255), (byte)rand.Next(1, 233)));
            btn.Background = brush;
        }

        private void btn1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button btn = (Button)sender;
            s1.Children.Remove(btn);
            this.Title = btn.Content.ToString();

        }

        private void btn4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button btn = (Button)sender;
            s2.Children.Remove(btn);
            this.Title = btn.Content.ToString();

        }
    }
}
