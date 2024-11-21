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
using Пр8;

namespace Пр8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CargoShip ship1;
        private CargoShip ship2;
        
        public MainWindow()
        {
            InitializeComponent();

            ship1 = new CargoShip(100,50,30,"1",400);
            ship2 = (CargoShip)ship1.Clone();
            ship2.Name = "2";
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Кузнецов М.Н. ИСП-31 \nСоздать интерфейсы - корабль, грузовой транспорт. Создать класс грузовой корабль. Класс должен включать конструктор, функцию для формирования строки информации о корабле. Сравнение производить по грузоподъемности.");
        }

        private void btnOutput1_Click(object sender, RoutedEventArgs e)
        {
            Ship1.Text = ship1.GetInfo();
        }

        private void btnOutput2_Click(object sender, RoutedEventArgs e)
        {
            Ship2.Text = ship2.GetInfo();
        }

        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            if (ship1.CompareTo(ship2) < 0)
            {
                Rez.Text=$"{ship1.Name} менее грузоподъемен, чем {ship2.Name}";
            }
            else if (ship1.CompareTo(ship2) > 0)
            {
                Rez.Text = $"{ship1.Name} более грузоподъемен, чем {ship2.Name}";
            }
            else
            {
                Rez.Text = $"{ship1.Name} и {ship2.Name} имеют одинаковую грузоподъемность";
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this .Close();
        }
    }
}