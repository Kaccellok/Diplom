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

namespace Landmark.View.Landmarks.Yeisk
{
    /// <summary>
    /// Логика взаимодействия для Yeisk4.xaml
    /// </summary>
    public partial class Yeisk4 : Window
    {
        public Yeisk4()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Yeisk yeisk = new Districts.Info.Yeisk();
            yeisk.Show();
            this.Close();
        }
    }
}
