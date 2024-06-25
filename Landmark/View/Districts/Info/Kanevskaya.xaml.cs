using Landmark.View.Landmarks.Kanevskaya;
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
    public partial class Kanevskaya : Window
    {
        public Kanevskaya()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksKan1_Click(object sender, RoutedEventArgs e)
        {
            Kan1 kan1 = new Kan1();
            kan1.Show();
            this.Close();
        }

        private void btn_landmarksKan2_Click(object sender, RoutedEventArgs e)
        {
            Kan2 kan2 = new Kan2();
            kan2.Show();
            this.Close();
        }
    }
}
