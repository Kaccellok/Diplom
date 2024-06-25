using Landmark.View.Landmarks.Seversky;
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
    public partial class Seversky : Window
    {
        public Seversky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksSev1_Click(object sender, RoutedEventArgs e)
        {
            Sev1 sev1 = new Sev1();
            sev1.Show();
            this.Close();
        }

        private void btn_landmarksSev2_Click(object sender, RoutedEventArgs e)
        {
            Sev2 sev2 = new Sev2();
            sev2.Show();
            this.Close();
        }
    }
}
