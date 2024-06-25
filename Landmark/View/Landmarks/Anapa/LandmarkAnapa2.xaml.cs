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


namespace Landmark.View.Landmarks.Anapa
{
    /// <summary>
    /// Логика взаимодействия для LandmarkAnapa2.xaml
    /// </summary>
    public partial class LandmarkAnapa2 : Window
    {
        public LandmarkAnapa2()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Anapa anapa = new Districts.Info.Anapa();
            anapa.Show();
            this.Close();
        }
    }
}
