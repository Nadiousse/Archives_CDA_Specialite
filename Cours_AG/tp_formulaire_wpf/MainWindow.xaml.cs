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

namespace tp_formulaire_wpf
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

        private void buttonSubscription_Click(object sender, RoutedEventArgs e)
        {
            string durationCheck = "";
            bool newsletterCheck = newsletterCheckBox.IsChecked == true;

            if (radioOneMonth.IsChecked == true)
            {
                durationCheck = "1 Month";
            }
            else if (radioSixMonth.IsChecked == true)
            {
                durationCheck = "6 Months";
            }
            else if (radioOneYear.IsChecked == true) 
            {
                durationCheck = "1 Year";
            }

            Database.Subscribers.Add(new Subscriber(firstName.Text, lastName.Text, durationCheck, newsletterCheck));

            MessageBox.Show("Vous avez été enregistré dans la dabse de données.");
        }

        private void buttonShowDatabase_Click(object sender, RoutedEventArgs e)
        {
            textblockDatabase.Text = "";
            foreach (Subscriber subscriber in Database.Subscribers)
            {
                textblockDatabase.Text += subscriber;
                textblockDatabase.Text += "\n\n";
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioSixMonth_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioOneYear_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void newsletterCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Subscriber
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Duration { get; set; }
        public bool Newsletter { get; set; }

        public Subscriber( string initFirstName, string initLastName, string initDuration, bool initNewsLetter)
        {
            FirstName = initFirstName;
            LastName = initLastName;
            Duration = initDuration;
            Newsletter = initNewsLetter;
        }

        public override string ToString()
        {
            string news;

            if (Newsletter)
            {
                news = "yes";
            }
            else
            {
                news = "no";
            }

            return FirstName + " " + LastName + " : " + Duration + "\n" + "Newsletter : " + news;
        }
    }

    public static class Database
    {
        public static List<Subscriber> Subscribers { get; set; } = new List<Subscriber>();

    }
}