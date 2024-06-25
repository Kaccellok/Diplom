using Landmark.View.Landmarks.Gulkevichsky;
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
    public partial class Gulkevichsky : Window
    {
        public Gulkevichsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksGul1_Click(object sender, RoutedEventArgs e)
        {
            Gul1 gul1 = new Gul1();
            gul1.Show();
            this.Close();
        }

        private void btn_landmarksGul2_Click(object sender, RoutedEventArgs e)
        {
            Gul2 gul2 = new Gul2();
            gul2.Show();
            this.Close();
        }

        
    }
}
