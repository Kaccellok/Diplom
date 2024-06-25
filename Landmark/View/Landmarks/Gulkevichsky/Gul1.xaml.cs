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

namespace Landmark.View.Landmarks.Gulkevichsky
{
    /// <summary>
    /// Логика взаимодействия для Gul1.xaml
    /// </summary>
    public partial class Gul1 : Window
    {
        public Gul1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Gulkevichsky gulkevichsky = new Districts.Info.Gulkevichsky();
            gulkevichsky.Show();
            this.Close();
        }
    }
}
