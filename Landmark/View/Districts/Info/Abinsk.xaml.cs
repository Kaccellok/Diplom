using Landmark.View.Landmarks.Abinsky;
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
    /// Логика взаимодействия для Abinsk.xaml
    /// </summary>
    public partial class Abinsk : Window
    {
        public Abinsk()
        {
            InitializeComponent();
        }

        private void btn_landmarksAbinsk1_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAbn1 landmarkAbn1 = new LandmarkAbn1();
            landmarkAbn1.Show();
            this.Close();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksAbinsk2_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAbn2 landmarkAbn2 = new LandmarkAbn2();
            landmarkAbn2.Show();
            this.Close();
        }

        private void btn_landmarksAbinsk3_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAbn3 landmarkAbn3 = new LandmarkAbn3();
            landmarkAbn3.Show();
            this.Close();
        }

        private void btn_landmarksAbinsk4_Click(object sender, RoutedEventArgs e)
        {
            LandmarkAbn4 landmarkAbn4 = new LandmarkAbn4();
            landmarkAbn4.Show();
            this.Close();
        }
    }
}
