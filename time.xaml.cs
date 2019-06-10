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
    /// Interaction logic for time.xaml
    /// </summary>
    public partial class time : Window
    {
        public time()
        {
            InitializeComponent();
        }

        private void calTime_Click(object sender, RoutedEventArgs e)
        {
            if (fromComBxTime.Text == "second (sec)" && toComBxTime.Text == "minute (min.)")
            {
                secToMin(txtBxTimeVal.Text);
            }
            else if (fromComBxTime.Text == "minute (min.)" && toComBxTime.Text == "second (sec)")
            {
                minToSec(txtBxTimeVal.Text);
            }
            else
            {
                MessageBox.Show("Invalid Entry!");
            }
        }

        private void minToSec(string p)
        {
            float time2 = float.Parse(p);
            float rslt = time2 * 60;
            txtBxTimeRslt.Text = rslt.ToString();
        }

        private void secToMin(string p)
        {
            float time1 = float.Parse(p);
            float rslt = time1/60;
            txtBxTimeRslt.Text = rslt.ToString();
        }

        private void closeTime_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWinObj = new MainWindow();
            mainWinObj.ShowDialog();
        }
    }
}
