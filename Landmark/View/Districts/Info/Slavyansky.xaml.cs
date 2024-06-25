using Landmark.View.Landmarks.Slavyansky;
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
    public partial class Slavyansky : Window
    {
        public Slavyansky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksSlv1_Click(object sender, RoutedEventArgs e)
        {
            Slv1 slv1 = new Slv1();
            slv1.Show();
            this.Close();
        }

        private void btn_landmarksSlv2_Click(object sender, RoutedEventArgs e)
        {
            Slv2 slv2 = new Slv2();
            slv2.Show();
            this.Close();
        }

        private void btn_landmarksSlv3_Click(object sender, RoutedEventArgs e)
        {
            Slv3 slv3 = new Slv3();
            slv3.Show();
            this.Close();
        }
    }
}
