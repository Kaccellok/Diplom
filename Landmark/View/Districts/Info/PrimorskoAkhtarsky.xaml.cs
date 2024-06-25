using Landmark.View.Landmarks.Primorsko_Akhtarsky;
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
    public partial class PrimorskoAkhtarsky: Window
    {
        public PrimorskoAkhtarsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksPrm1_Click(object sender, RoutedEventArgs e)
        {
            PA1 pA1 = new PA1();
            pA1.Show();
            this.Close();
        }

        private void btn_landmarksPrm2_Click(object sender, RoutedEventArgs e)
        {
            PA2 pA2 = new PA2();
            pA2.Show();
            this.Close();
        }
    }
}
