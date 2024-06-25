using Landmark.View.Landmarks.Goryachiy_Klyuch;
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
    public partial class GoryachiyKlyuch : Window
    {
        public GoryachiyKlyuch()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksGK1_Click(object sender, RoutedEventArgs e)
        {
            GK1 gK1 = new GK1();
            gK1.Show();
            this.Close();
        }

        private void btn_landmarksGK2_Click(object sender, RoutedEventArgs e)
        {
            GK2 gK2 = new GK2();
            gK2.Show();
            this.Close();
        }

        private void btn_landmarksGK3_Click(object sender, RoutedEventArgs e)
        {
            GK3 gK3 = new GK3();
            gK3.Show();
            this.Close();
        }

        private void btn_landmarksGK4_Click(object sender, RoutedEventArgs e)
        {
            GK4 gK4 = new GK4();
            gK4.Show();
            this.Close();
        }

        private void btn_landmarksGK5_Click(object sender, RoutedEventArgs e)
        {
            GK5 gK5 = new GK5();
            gK5.Show();
            this.Close();
        }

        private void btn_landmarksGK6_Click(object sender, RoutedEventArgs e)
        {
            GK6 gK6 = new GK6();
            gK6.Show();
            this.Close();
        }
    }
}
