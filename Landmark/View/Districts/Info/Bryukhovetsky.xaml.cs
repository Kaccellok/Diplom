using Landmark.View.Landmarks.Bryukhovetsky;
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
    public partial class Bryukhovetsky : Window
    {
        public Bryukhovetsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksBrh1_Click(object sender, RoutedEventArgs e)
        {
            LandmarkBrh1 landmarkBrh1 = new LandmarkBrh1();
            landmarkBrh1.Show();
            this.Close();
        }
    }
}
