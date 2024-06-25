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

namespace Landmark.View.Landmarks.Armavir
{
    /// <summary>
    /// Логика взаимодействия для LandmarkArm6.xaml
    /// </summary>
    public partial class LandmarkArm6 : Window
    {
        public LandmarkArm6()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Armavir armavir = new Districts.Info.Armavir();
            armavir.Show();
            this.Close();
        }
    }
}
