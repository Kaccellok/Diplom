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

namespace Landmark.View.Landmarks.Abinsky
{
    /// <summary>
    /// Логика взаимодействия для LandmarkAbn1.xaml
    /// </summary>
    public partial class LandmarkAbn1 : Window
    {
        public LandmarkAbn1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Abinsk abinsk = new Abinsk();
            abinsk.Show();
            this.Close();
        }
    }
}
