using Landmark.View.Landmarks.Ust_Labinsky;
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
  
    public partial class UstLabinsky : Window
    {
        public UstLabinsky()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            DistrictsList districtsList = new DistrictsList();
            districtsList.Show();
            this.Close();
        }

        private void btn_landmarksUL1_Click(object sender, RoutedEventArgs e)
        {
            UL1 uL1 = new UL1();
            uL1.Show();
            this.Close();
        }

        private void btn_landmarksUL2_Click(object sender, RoutedEventArgs e)
        {
            UL2 uL2 = new UL2();
            uL2.Show();
            this.Close();
        }

        private void btn_landmarksUL3_Click(object sender, RoutedEventArgs e)
        {
            UL3 uL3 = new UL3();
            uL3.Show();
            this.Close();
        }
    }
}
