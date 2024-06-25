using Landmark.View.Landmarks.Sochi;
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
    public partial class Sochi : Window
    {
        public Sochi()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksSch1_Click(object sender, RoutedEventArgs e)
        {
            Sochi1 sochi1 = new Sochi1();
            sochi1.Show();
            this.Close();
        }

        private void btn_landmarksSch2_Click(object sender, RoutedEventArgs e)
        {
            Sochi2 sochi2 = new Sochi2();
            sochi2.Show();
            this.Close();
        }

        private void btn_landmarksSch3_Click(object sender, RoutedEventArgs e)
        {
            Sochi3 sochi3 = new Sochi3();
            sochi3.Show();
            this.Close();
        }

        private void btn_landmarksSch4_Click(object sender, RoutedEventArgs e)
        {
            Sochi4 sochi4 = new Sochi4();
            sochi4.Show();
            this.Close();
        }

        private void btn_landmarksSch5_Click(object sender, RoutedEventArgs e)
        {
            Sochi5 sochi5 = new Sochi5();
            sochi5.Show();
            this.Close();
        }
    }
}
