using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace first_wpf_app
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

        public int count { get; set; } = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            count--;

            DisplayNumber.Text = count.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            count++;

            DisplayNumber.Text = count.ToString();
        }

        private void numberOne_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numberTwo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberOne.Text, out int num1) && int.TryParse(numberTwo.Text, out int num2))
            {
                int result = num1 - num2;

                ResultTextBlock.Text = result.ToString();
            }
            else
            {
                ResultTextBlock.Text = "Invalide !";
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberOne.Text, out int num1) && int.TryParse(numberTwo.Text, out int num2))
            {
                int result = num1 + num2;

                ResultTextBlock.Text = result.ToString();
            }
            else
            {
                ResultTextBlock.Text = "Invalide !";
            }
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberOne.Text, out int num1) && int.TryParse(numberTwo.Text, out int num2) && num2 != 0)
            {
                int result = num1 / num2;

                ResultTextBlock.Text = result.ToString();
            }
            else
            {
                ResultTextBlock.Text = "Invalide !";
            }
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberOne.Text, out int num1) && int.TryParse(numberTwo.Text, out int num2))
            {
                int result = num1 * num2;

                ResultTextBlock.Text = result.ToString();
            }
            else
            {
                ResultTextBlock.Text = "Invalide !";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(MinNumber.Text, out int num1) && int.TryParse(MaxNumber.Text, out int num2))
            {
                Random randomNumber = new Random();

                int result = randomNumber.Next(num1, num2+1);

                DisplayRandomNumber.Text = result.ToString();
            }
            else
            {
                DisplayRandomNumber.Text = "Invalide !";
            }
        }
    }
}