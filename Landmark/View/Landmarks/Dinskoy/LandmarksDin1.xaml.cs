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

namespace Landmark.View.Landmarks.Dinskoy
{
    /// <summary>
    /// Логика взаимодействия для LandmarksDin1.xaml
    /// </summary>
    public partial class LandmarksDin1 : Window
    {
        public LandmarksDin1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Dinskoy dinskoy = new Districts.Info.Dinskoy();
            dinskoy.Show();
            this.Close();
        }
    }
}
