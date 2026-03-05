using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Практическая_работа_4_Колчин_Михайлова
{
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x0 = Convert.ToDouble(txtX0.Text);
                double xk = Convert.ToDouble(txtXk.Text);
                double dx = Convert.ToDouble(txtDx.Text);
                double b = Convert.ToDouble(txtB.Text);

                txtResult.Clear();

                ChartValues<double> values = new ChartValues<double>();

                for (double x = x0; x <= xk; x += dx)
                {
                    double y = 0.0025 * b * Math.Pow(x, 3) + Math.Sqrt(x) + Math.Exp(0.82);

                    txtResult.AppendText($"x={x:F2}  y={y:F4}\n");

                    values.Add(y);
                }

                chart.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "y(x)",
                        Values = values
                    }
                };
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX0.Clear();
            txtXk.Clear();
            txtDx.Clear();
            txtB.Clear();
            txtResult.Clear();

            chart.Series.Clear();
        }

        private void txtResult_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}