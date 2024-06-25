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

namespace Landmark.View.Landmarks.Bryukhovetsky
{
    /// <summary>
    /// Логика взаимодействия для LandmarkBrh1.xaml
    /// </summary>
    public partial class LandmarkBrh1 : Window
    {
        public LandmarkBrh1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Bryukhovetsky bryukhovetsky = new Districts.Info.Bryukhovetsky();
            bryukhovetsky.Show();
            this.Close();
        }
    }
}
