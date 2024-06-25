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
using Landmark.View.Landmarks.Apsheronsky;

namespace Landmark.View.Districts.Info
{
    /// <summary>
    /// Логика взаимодействия для Krasnodar.xaml
    /// </summary>
    public partial class Apsheronsky : Window
    {
        public Apsheronsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksApsh1_Click(object sender, RoutedEventArgs e)
        {
            LandmarkApsh1 landmarkApsh1 = new LandmarkApsh1();
            landmarkApsh1.Show();
            this.Close();
        }

        private void btn_landmarksApsh2_Click(object sender, RoutedEventArgs e)
        {
             LandmarkApsh10 landmarkApsh10 = new LandmarkApsh10();
             landmarkApsh10.Show();
             this.Close();
        }

        private void btn_landmarksApsh3_Click(object sender, RoutedEventArgs e)
        {
            LandmarkApsh2 landmarkApsh2 = new LandmarkApsh2();
            landmarkApsh2.Show();
            this.Close();
        }

        private void btn_landmarksApsh10_Click(object sender, RoutedEventArgs e)
        {
            LandmarkApsh3 landmarkApsh3 = new LandmarkApsh3();
            landmarkApsh3.Show();
            this.Close();
        }

        
    }
}
