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

namespace Landmark.View.Landmarks.Tuapse
{
    /// <summary>
    /// Логика взаимодействия для Tuapse3.xaml
    /// </summary>
    public partial class Tuapse3 : Window
    {
        public Tuapse3()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Tuapse tuapse = new Districts.Info.Tuapse();
            tuapse.Show();
            this.Close();
        }
    }
}
