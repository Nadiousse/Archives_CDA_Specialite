using System.ComponentModel;
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

namespace tp_combat_data_binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int battleRound;
        public int BattleRound
        {
            get { return battleRound; }
            set
            {
                if (battleRound != value)
                {
                    battleRound = value;
                    NotifyPropertyChanged("BattleRound");
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public Warrior thomas { get; set; }  
        public Warrior pierreLouis { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            BattleRound = 1;
            thomas = new Warrior("Thomas", 20);
            pierreLouis = new Warrior("Pierre-Louis", 15);

            PlayerOneText.Text = pierreLouis.Name;
            PlayerTwoText.Text = thomas.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BattleRound++;
            pierreLouis.AttackWarrior(thomas);
            thomas.AttackWarrior(pierreLouis);
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}