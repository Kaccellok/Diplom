﻿using System;
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

namespace Landmark.View.Landmarks.Kurganinsky
{
    /// <summary>
    /// Логика взаимодействия для Kur1.xaml
    /// </summary>
    public partial class Kur1 : Window
    {
        public Kur1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Kurganinsky kurganinsky = new Districts.Info.Kurganinsky();
            kurganinsky.Show();
            this.Close();
        }
    }
}
