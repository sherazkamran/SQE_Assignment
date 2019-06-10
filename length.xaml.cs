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
    /// Interaction logic for length.xaml
    /// </summary>
    public partial class length : Window
    {
        public length()
        {
            InitializeComponent();
        }
        private void calLen_Click(object sender, RoutedEventArgs e)
        {
            if (fromComBxLen.Text == "meter (m)" && toComBxLen.Text == "milimeter (mm)")
            {
                meterToMilimeter(txtBxLenVal.Text);
            }
            else if (fromComBxLen.Text == "milimeter (mm)" && toComBxLen.Text == "meter (m)")
            {
                milimeterToMeter(txtBxLenVal.Text);
            }
            else 
            {
                MessageBox.Show("Invalid Entry!");
            }
        }

        private void milimeterToMeter(string p)
        {
            float num2 = float.Parse(p);
            float rslt = num2 * 1000;
            txtBxLenRslt.Text = rslt.ToString();
        }

        private void meterToMilimeter(string p)
        {
            float num1 = float.Parse(p);
            float rslt = num1/1000;
            txtBxLenRslt.Text = rslt.ToString();
        }

        private void closeLen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWinObj = new MainWindow();
            mainWinObj.ShowDialog();
        }
    }
}
