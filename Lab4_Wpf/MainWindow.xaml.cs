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

namespace Lab4_Wpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGr = Convert.ToDouble(rate2.Text);
            double sumGr = Convert.ToDouble(sum2.Text);
            double resGr = rateGr * sumGr;
            resSum2.Text = resGr.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDr = Convert.ToDouble(rate3.Text);
            double sumDr = Convert.ToDouble(sum3.Text);
            double resDr = rateDr * sumDr;
            resSum3.Text = resDr.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double convD = Convert.ToDouble(conv.Text);
            double resD = convD * 0.0254;
            res.Text = resD.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double convD = Convert.ToDouble(conv1.Text);
            double resD = convD * 0.3;
            res1.Text = resD.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double convD = Convert.ToDouble(conv2.Text);
            double resD = convD * 1609.34;
            res2.Text = resD.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double convD = Convert.ToDouble(conv3.Text);
            double resD = convD * 1066.8;
            res3.Text = resD.ToString();
        }
    }
}
