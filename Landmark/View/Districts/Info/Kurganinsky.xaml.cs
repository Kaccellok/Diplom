using Landmark.View.Landmarks.Kurganinsky;
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
    public partial class Kurganinsky : Window
    {
        public Kurganinsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksKur1_Click(object sender, RoutedEventArgs e)
        {
            Kur1 kur1 = new Kur1();
            kur1.Show();
            this.Close();
        }

        private void btn_landmarksKur2_Click(object sender, RoutedEventArgs e)
        {
            Kur2 kur2 = new Kur2();
            kur2.Show();
            this.Close();
        }
    }
}
