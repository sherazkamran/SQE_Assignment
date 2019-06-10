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
using System.Windows.Shapes;

namespace UnitConverter
{
    /// <summary>
    /// Interaction logic for temperature.xaml
    /// </summary>
    public partial class temperature : Window
    {
        public temperature()
        {
            InitializeComponent();
        }

        private void calTemp_Click(object sender, RoutedEventArgs e)
        {
            if (fromComBxTemp.Text == "Celsius (C)" && toComBxTemp.Text == "Fahrenheit (F)")
            {
                celsiusToFahrenheit(txtBxTempVal.Text);
            }
            else if (fromComBxTemp.Text == "Fahrenheit (F)" && toComBxTemp.Text == "Celsius (C)")
            {
                fahrenheitToCelsius(txtBxTempVal.Text);
            }
            else
            {
                MessageBox.Show("Invalid Entry!");
            }
        }

        private void fahrenheitToCelsius(string p)
        {
            float temp2 = float.Parse(p);
            temp2 = temp2 * 9/5;
            float rslt = temp2 + 32;
            txtBxTempRslt.Text = rslt.ToString();
        }

        private void celsiusToFahrenheit(string p)
        {
            float temp1 = float.Parse(p);
            temp1 = temp1-32;
            float rslt = temp1 * 5/9;
            txtBxTempRslt.Text = rslt.ToString();
        }

        private void closeTemp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWinObj = new MainWindow();
            mainWinObj.ShowDialog();
        }
    }
}
