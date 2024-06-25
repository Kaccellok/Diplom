using Landmark.View.Landmarks.Krasnodar;
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
    public partial class Krasnodar : Window
    {
        public Krasnodar()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksKrd1_Click(object sender, RoutedEventArgs e)
        {
            Krd1 krd1 = new Krd1();
            krd1.Show();
            this.Close();
        }

        private void btn_landmarksKrd2_Click(object sender, RoutedEventArgs e)
        {
            Krd2 krd2 = new Krd2();
            krd2.Show();
            this.Close();
        }

        private void btn_landmarksKrd3_Click(object sender, RoutedEventArgs e)
        {
            Krd3 krd3 = new Krd3();
            krd3.Show();
            this.Close();
        }

        private void btn_landmarksKrd4_Click(object sender, RoutedEventArgs e)
        {
            Krd4 krd4 = new Krd4();
            krd4.Show();
            this.Close();
        }

        private void btn_landmarksKrd5_Click(object sender, RoutedEventArgs e)
        {
            Krd5 krd5 = new Krd5();
            krd5.Show();
            this.Close();
        }

        private void btn_landmarksKrd6_Click(object sender, RoutedEventArgs e)
        {
            Krd6 krd6 = new Krd6();
            krd6.Show();
            this.Close();
        }

        private void btn_landmarksKrd7_Click(object sender, RoutedEventArgs e)
        {
            Krd7 krd7 = new Krd7();
            krd7.Show();
            this.Close();
        }
    }
}
