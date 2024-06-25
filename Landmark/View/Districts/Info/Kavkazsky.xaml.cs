using Landmark.View.Landmarks.Kavkazsky;
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
using System.Windows.Shapes;

namespace Landmark.View.Districts.Info
{
    /// <summary>
    /// Логика взаимодействия для Krasnodar.xaml
    /// </summary>
    public partial class Kavkazsky : Window
    {
        public Kavkazsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksKav1_Click(object sender, RoutedEventArgs e)
        {
            Kav1 kav1 = new Kav1();
            kav1.Show();
            this.Close();
        }

        private void btn_landmarksKav2_Click(object sender, RoutedEventArgs e)
        {
            Kav2 kav2 = new Kav2();
            kav2.Show();
            this.Close();
        }

        private void btn_landmarksKav3_Click(object sender, RoutedEventArgs e)
        {
            Kav3 kav3 = new Kav3();
            kav3.Show();
            this.Close();
        }

        private void btn_landmarksKav4_Click(object sender, RoutedEventArgs e)
        {
            Kav4 kav4 = new Kav4();
            kav4.Show();
            this.Close();
        }

        private void btn_landmarksKav5_Click(object sender, RoutedEventArgs e)
        {
            Kav5 kav5 = new Kav5();
            kav5.Show();
            this.Close();
        }
    }
}
