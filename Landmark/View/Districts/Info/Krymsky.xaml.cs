using Landmark.View.Landmarks.Krymsky;
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
    public partial class Krymsky : Window
    {
        public Krymsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksKrm1_Click(object sender, RoutedEventArgs e)
        {
            Krym1 krym1 = new Krym1();
            krym1.Show();
            this.Close();
        }

        private void btn_landmarksKrm2_Click(object sender, RoutedEventArgs e)
        {
            Krym2 krym2 = new Krym2();
            krym2.Show();
            this.Close();
        }
    }
}
