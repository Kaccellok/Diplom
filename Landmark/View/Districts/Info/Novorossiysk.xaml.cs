using Landmark.View.Landmarks.Novorossiysk;
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
    public partial class Novorossiysk : Window
    {
        public Novorossiysk()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksNvr1_Click(object sender, RoutedEventArgs e)
        {
            NVR1 nVR1 = new NVR1();
            nVR1.Show();
            this.Close();
        }

        private void btn_landmarksNvr2_Click(object sender, RoutedEventArgs e)
        {
            NVR2 nVR2 = new NVR2();
            nVR2.Show();
            this.Close();
        }

        private void btn_landmarksNvr3_Click(object sender, RoutedEventArgs e)
        {
            NVR3 nVR3 = new NVR3();
            nVR3.Show();
            this.Close();
        }

        private void btn_landmarksNvr4_Click(object sender, RoutedEventArgs e)
        {
            NVR4 nVR4 = new NVR4();
            nVR4.Show();
            this.Close();
        }

        private void btn_landmarksNvr5_Click(object sender, RoutedEventArgs e)
        {
            NVR5 nVR5 = new NVR5();
            nVR5.Show();
            this.Close();
        }

        private void btn_landmarksNvr6_Click(object sender, RoutedEventArgs e)
        {
            NVR6 nVR6 = new NVR6();
            nVR6.Show();
            this.Close();
        }

        private void btn_landmarksNvr7_Click(object sender, RoutedEventArgs e)
        {
            NVR7 nVR7 = new NVR7();
            nVR7.Show();
            this.Close();
        }

        private void btn_landmarksNvr8_Click(object sender, RoutedEventArgs e)
        {
            NVR8 nVR8 = new NVR8();
            nVR8.Show();
                this.Close();
        }
    }
}
