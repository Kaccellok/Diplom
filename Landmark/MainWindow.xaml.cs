using Landmark.View.Tests;
using System.Windows;
using Landmark.View.Districts;

namespace Landmark
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

        private void btn_Test_Click(object sender, RoutedEventArgs e)
        {
            MainWindowTest test = new MainWindowTest();
            test.Show();

        }

        private void btn_District_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtList = new DistrictsList();
            districtList.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
