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

namespace Landmark.View.Landmarks.Krasnodar
{
    /// <summary>
    /// Логика взаимодействия для Krd1.xaml
    /// </summary>
    public partial class Krd1 : Window
    {
        public Krd1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Krasnodar krasnodar = new Districts.Info.Krasnodar();
            krasnodar.Show();
            this.Close();
        }
    }
}
