using System;
using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckData(object sender, RoutedEventArgs e)
        {
            int intValue;
            long longValue;
            short shortValue;

            if (int.TryParse(intTextBox.Text, out intValue))
            {
                MessageBox.Show($"Тип данных int верный, ура победа. Ваше число: {intValue}");
            }
            else
            {
                MessageBox.Show("тип данных int был введен неверно, попробуйте еще раз");
            }

            if (long.TryParse(longTextBox.Text, out longValue))
            {
                MessageBox.Show($"Тип данных Long верный, вы молодец. Ваше число: {longValue}");
            }
            else
            {
                MessageBox.Show("Тип данных Long неверен, попробуйте еще раз, но купив ботл, он стоит точно меньше, чем ваше число (Если не отрицательное).");
            }

            if (short.TryParse(shortTextBox.Text, out shortValue))
            {
                MessageBox.Show($"Тип данных Short был введен верно, поздравляю. Ваше число: {shortValue}");
            }
            else
            {
                MessageBox.Show("Тип данных short был введен неверно. Ботл дешевле, чем ваше число (Если не отрицательное)");
            }
        }
    }
}
