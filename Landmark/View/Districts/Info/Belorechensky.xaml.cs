using Landmark.View.Landmarks.Belorechensky;
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
    /// Логика взаимодействия для Belorechensky.xaml
    /// </summary>
    public partial class Belorechensky : Window
    {
        public Belorechensky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksBel1_Click(object sender, RoutedEventArgs e)
        {
            LandmarkBel1 landmarkBel1 = new LandmarkBel1();
            landmarkBel1.Show();
            this.Close();
        }

        private void btn_landmarksBel2_Click(object sender, RoutedEventArgs e)
        {
            LandmarkBel2 landmarkBel2 = new LandmarkBel2();
            landmarkBel2.Show();
            this.Close();
        }

        private void btn_landmarksBel3_Click(object sender, RoutedEventArgs e)
        {
            LandmarkBel3 landmarkBel3 = new LandmarkBel3();
            landmarkBel3.Show();
            this.Close();
        }

        private void btn_landmarksBel4_Click(object sender, RoutedEventArgs e)
        {
            LandmarkBel4 landmarkBel4 = new LandmarkBel4();
            landmarkBel4.Show();
            this.Close();
        }

        private void btn_landmarksBel5_Click(object sender, RoutedEventArgs e)
        {
            LandmarkBel5 landmarkBel5 = new LandmarkBel5();
            landmarkBel5.Show();
            this.Close();
        }

        private void btn_landmarksBel6_Click(object sender, RoutedEventArgs e)
        {
            LandmarkBel6 landmarkBel6 = new LandmarkBel6();
            landmarkBel6.Show();
            this.Close();
        }
    }
}
