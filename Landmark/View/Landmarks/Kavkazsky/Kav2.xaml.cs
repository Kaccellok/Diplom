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

namespace Landmark.View.Landmarks.Kavkazsky
{
    /// <summary>
    /// Логика взаимодействия для Kav2.xaml
    /// </summary>
    public partial class Kav2 : Window
    {
        public Kav2()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Kavkazsky kavkazsky = new Districts.Info.Kavkazsky();
            kavkazsky.Show();
            this.Close();
        }
    }
}
