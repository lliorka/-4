using System;
using System.Windows;
using System.Windows.Controls;

namespace Практическая_работа_4_Колчин_Михайлова
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);
                double z = Convert.ToDouble(txtZ.Text);

                if (x == 0)
                {
                    MessageBox.Show("Ошибка: x не может быть 0");
                    return;
                }

                if (y - x == 0)
                {
                    MessageBox.Show("Ошибка: деление на 0 (y - x = 0)");
                    return;
                }

                double part1 =
                    Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1.0 / 3));

                double part2 =
                    (y - x) * (Math.Cos(y) - z / (y - x)) /
                    (1 + Math.Pow(y - x, 2));

                double result = part1 + part2;

                txtResult.Text = result.ToString("F6");
            }
            catch
            {
                MessageBox.Show("Введите корректные числа");
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
            txtResult.Clear();
        }
    }
}
