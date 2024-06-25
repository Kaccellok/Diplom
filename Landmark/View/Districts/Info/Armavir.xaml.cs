using Landmark.View.Landmarks.Armavir;
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
    public partial class Armavir : Window
    {
        public Armavir()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksArm1_Click(object sender, RoutedEventArgs e)
        {
            LandmarkArm1 landmarkArm1 = new LandmarkArm1();
            landmarkArm1.Show();
            this.Close();
        }

        private void btn_landmarksArm2_Click(object sender, RoutedEventArgs e)
        {
            LandmarkArm2 landmarkArm2 = new LandmarkArm2();
            landmarkArm2.Show();
            this.Close();
        }

        private void btn_landmarksArm3_Click(object sender, RoutedEventArgs e)
        {
            LandmarkArm3 landmarkArm3 = new LandmarkArm3();
            landmarkArm3.Show();    
            this.Close();
        }

        private void btn_landmarksArm4_Click(object sender, RoutedEventArgs e)
        {
            LandmarkArm4 landmarkArm4 = new LandmarkArm4();
            landmarkArm4.Show();
            this.Close();
        }

        private void btn_landmarksArm5_Click(object sender, RoutedEventArgs e)
        {
            LandmarkArm5 landmarkArm5 = new LandmarkArm5();
            landmarkArm5.Show();
            this.Close();
        }

        private void btn_landmarksArm6_Click(object sender, RoutedEventArgs e)
        {
            LandmarkArm6 landmarkArm6 = new LandmarkArm6();
            landmarkArm6.Show();
            this.Close();
        }

        private void btn_landmarksArm7_Click(object sender, RoutedEventArgs e)
        {
            LandmarkArm7 landmarkArm7 = new LandmarkArm7();
            landmarkArm7.Show();
            this.Close();
        }

        private void btn_landmarksArm8_Click(object sender, RoutedEventArgs e)
        {
            LandmarkArm8 landmarkArm8 = new LandmarkArm8();
            landmarkArm8.Show();
            this.Close();
        }
    }
}
