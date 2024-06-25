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

namespace Landmark.View.Landmarks.Seversky
{
    /// <summary>
    /// Логика взаимодействия для Sev2.xaml
    /// </summary>
    public partial class Sev2 : Window
    {
        public Sev2()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Seversky seversky = new Districts.Info.Seversky();
            seversky.Show();
            this.Close();
        }
    }
}
