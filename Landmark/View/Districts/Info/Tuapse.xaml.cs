using Landmark.View.Landmarks.Tuapse;
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
    public partial class Tuapse : Window
    {
        public Tuapse()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksTps1_Click(object sender, RoutedEventArgs e)
        {
            Tuapse1 tuapse1 = new Tuapse1();
            tuapse1.Show();
            this.Close();
        }

        private void btn_landmarksTps2_Click(object sender, RoutedEventArgs e)
        {
            Tuapse2 tuapse2 = new Tuapse2();
            tuapse2.Show();
            this.Close();
        }

        private void btn_landmarksTps3_Click(object sender, RoutedEventArgs e)
        {
            Tuapse3 tuapse3 = new Tuapse3();   
            tuapse3.Show();
            this.Close();
        }
    }
}
