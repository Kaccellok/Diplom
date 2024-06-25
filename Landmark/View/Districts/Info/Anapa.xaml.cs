using Landmark.View.Landmarks.Anapa;
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
    public partial class Anapa : Window
    {
        public Anapa()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList  districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksAnapa2_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa2 landmarkAnapa2 = new LandmarkAnapa2();
            landmarkAnapa2.Show();
            this.Close();
        }

        private void btn_landmarksAnapa3_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa3 landmarkAnapa3 = new LandmarkAnapa3();
            landmarkAnapa3.Show();
            this.Close();
        }

        private void btn_landmarksAnapa4_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa4 landmarkAnapa4 = new LandmarkAnapa4();
            landmarkAnapa4.Show();
            this.Close();
        }

        private void btn_landmarksAnapa5_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa5 landmarkAnapa5 = new LandmarkAnapa5();
            landmarkAnapa5.Show();
            this.Close();
        }

        private void btn_landmarksAnapa6_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa6 landmarkAnapa6 = new LandmarkAnapa6();
            landmarkAnapa6.Show();
            this.Close();
        }

        private void btn_landmarksAnapa7_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa7 landmarkAnapa7 = new LandmarkAnapa7();
            landmarkAnapa7.Show();
            this.Close();
        }

        private void btn_landmarksAnapa8_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa8 landmarkAnapa8 = new LandmarkAnapa8();
            landmarkAnapa8.Show();
            this.Close();
        }

        private void btn_landmarksAnapa9_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa9 landmarkAnapa9 = new LandmarkAnapa9();
            landmarkAnapa9.Show();
            this.Close();
        }

        private void btn_landmarksAnapa10_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAnapa10 landmarkAnapa10 = new LandmarkAnapa10();
            landmarkAnapa10.Show();
            this.Close();
        }
    }
}
