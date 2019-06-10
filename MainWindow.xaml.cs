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

namespace UnitConverter
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

        private void tempBtn_Click(object sender, RoutedEventArgs e)
        {
            temperature tempObj = new temperature();
            this.Hide();
            tempObj.ShowDialog();
        }

        private void timeBtn_Click(object sender, RoutedEventArgs e)
        {
            time timeObj = new time();
            this.Hide();
            timeObj.ShowDialog();
        }

        private void lenBtn_Click(object sender, RoutedEventArgs e)
        {
            length lenObj = new length();
            this.Hide();
            lenObj.ShowDialog();
        }
    }
}
