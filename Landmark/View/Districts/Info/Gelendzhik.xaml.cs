using Landmark.View.Landmarks.Gelendzhik;
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
    public partial class Gelendzhik : Window
    {
        public Gelendzhik()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksGel1_Click(object sender, RoutedEventArgs e)
        {
            Gel1 gel1 = new Gel1();
            gel1.Show();
            this.Close();
        }

        private void btn_landmarksGel2_Click(object sender, RoutedEventArgs e)
        {
            Gel2 gel2 = new Gel2();
            gel2.Show();
            this.Close();
        }

        private void btn_landmarksGel3_Click(object sender, RoutedEventArgs e)
        {
            Gel3 gel3 = new Gel3();
            gel3.Show();
            this.Close();
        }

        private void btn_landmarksGel4_Click(object sender, RoutedEventArgs e)
        {
            Gel4 gel4 = new Gel4();
            gel4.Show();
            this.Close();
        }

        private void btn_landmarksGel5_Click(object sender, RoutedEventArgs e)
        {
            Gel5 gel5 = new Gel5();
            gel5.Show();
            this.Close();
        }

        private void btn_landmarksGel6_Click(object sender, RoutedEventArgs e)
        {
            Gel6 gel6 = new Gel6();
            gel6.Show();
            this.Close();
        }

        private void btn_landmarksGel7_Click(object sender, RoutedEventArgs e)
        {
            Gel7 gel7 = new Gel7();
            gel7.Show();
            this.Close();
        }
    }
}
