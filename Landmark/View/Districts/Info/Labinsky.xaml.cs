using Landmark.View.Landmarks.Labinsky;
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
    public partial class Labinsky : Window
    {
        public Labinsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksLab1_Click(object sender, RoutedEventArgs e)
        {
            Lab1 lab1 = new Lab1();
            lab1.Show();
            this.Close();
        }

        private void btn_landmarksLab2_Click(object sender, RoutedEventArgs e)
        {
            Lab2 lab2 = new Lab2();
            lab2.Show();
            this.Close();
        }

        private void btn_landmarksLab3_Click(object sender, RoutedEventArgs e)
        {
            Lab3 lab3 = new Lab3();
            lab3.Show();
            this.Close();
        }

        private void btn_landmarksLab4_Click(object sender, RoutedEventArgs e)
        {
            Lab4 lab4 = new Lab4();
            lab4.Show();
            this.Close();
        }
    }
}
