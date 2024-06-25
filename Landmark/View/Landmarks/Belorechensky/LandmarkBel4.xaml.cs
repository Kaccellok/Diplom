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
    /// Логика взаимодействия для LandmarkBel4.xaml
    /// </summary>
    public partial class LandmarkBel4 : Window
    {
        public LandmarkBel4()
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
