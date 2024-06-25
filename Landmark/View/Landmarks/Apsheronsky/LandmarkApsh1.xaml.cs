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

namespace Landmark.View.Landmarks.Apsheronsky
{
    /// <summary>
    /// Логика взаимодействия для LandmarkApsh1.xaml
    /// </summary>
    public partial class LandmarkApsh1 : Window
    {
        public LandmarkApsh1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Apsheronsky apsheronsky = new Districts.Info.Apsheronsky();
            apsheronsky.Show();
            this.Close();
        }
    }
}
