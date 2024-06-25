using Landmark.View.Districts.Info;
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

namespace Landmark.View.Landmarks.Belorechensky
{
    /// <summary>
    /// Логика взаимодействия для LandmarkBel1.xaml
    /// </summary>
    public partial class LandmarkBel1 : Window
    {
        public LandmarkBel1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Belorechensky belorechensky = new Districts.Info.Belorechensky();
            belorechensky.Show();
            this.Close();
        }
    }
}
