using Landmark.View.Landmarks.Yeisk;
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
    public partial class Yeisk : Window
    {
        public Yeisk()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksEysk1_Click(object sender, RoutedEventArgs e)
        {
            Yeisk1 yeisk1 = new Yeisk1();
            yeisk1.Show();
            this.Close();
        }

        private void btn_landmarksEysk2_Click(object sender, RoutedEventArgs e)
        {
            Yeisk2 yeisk2 = new Yeisk2();
            yeisk2.Show();
            this.Close();
        }

        private void btn_landmarksEysk3_Click(object sender, RoutedEventArgs e)
        {
            Yeisk3 yeisk3 = new Yeisk3();
            yeisk3.Show();
            this.Close();
        }

        private void btn_landmarksEysk4_Click(object sender, RoutedEventArgs e)
        {
            Yeisk4 yeisk4 = new Yeisk4();
            yeisk4.Show();
            this.Close();
        }

        private void btn_landmarksEysk5_Click(object sender, RoutedEventArgs e)
        {
            Yeisk5 yeisk5 = new Yeisk5();
            yeisk5.Show();
            this.Close();
        }
    }
}
