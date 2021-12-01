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

namespace Lab_2_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(a.Text);
            int B = int.Parse(b.Text);
            vyvod.Content = A+B;
            //MessageBox.Show(A.ToString());
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(a.Text);
            int B = int.Parse(b.Text);
            vyvod.Content = A - B;
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(a.Text);
            int B = int.Parse(b.Text);
            vyvod.Content = A * B;
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(a.Text);
            int B = int.Parse(b.Text);
            vyvod.Content = A / B;
        }
    }
}
