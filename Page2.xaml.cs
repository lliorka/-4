using System;
using System.Windows;
using System.Windows.Controls;

namespace Практическая_работа_4_Колчин_Михайлова
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtX.Text);
                double p = Convert.ToDouble(txtP.Text);

                double fx = 0;

                // выбор функции

                if (rbSh.IsChecked == true)
                    fx = Math.Sinh(x);

                else if (rbX2.IsChecked == true)
                    fx = Math.Pow(x, 2);

                else if (rbExp.IsChecked == true)
                    fx = Math.Exp(x);

                double result = 0;

                if (x > Math.Abs(p))
                {
                    result = 2 * Math.Pow(fx, 3) + 3 * Math.Pow(p, 2);
                }
                else if (x > 3 && x < Math.Abs(p))
                {
                    result = Math.Abs(fx - p);
                }
                else if (x == Math.Abs(p))
                {
                    result = Math.Pow(fx - p, 2);
                }

                txtResult.Text = result.ToString("F4");
            }
            catch
            {
                MessageBox.Show("Введите корректные числа");
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtP.Clear();
            txtResult.Clear();

            rbSh.IsChecked = false;
            rbX2.IsChecked = false;
            rbExp.IsChecked = false;
        }
    }
}