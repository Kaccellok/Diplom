﻿using Landmark.View.Landmarks.Temryuksky;
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
    public partial class Temryuksky : Window
    {
        public Temryuksky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksTmr1_Click(object sender, RoutedEventArgs e)
        {
            TM1 tM1 = new TM1();
            tM1.Show();
            this.Close();
        }

        private void btn_landmarksTmr2_Click(object sender, RoutedEventArgs e)
        {
            TM2 tM2 = new TM2();
            tM2.Show();
            this.Close();
        }
    }
}
