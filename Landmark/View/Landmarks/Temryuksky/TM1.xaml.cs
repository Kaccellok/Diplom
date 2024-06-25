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

namespace Landmark.View.Landmarks.Temryuksky
{
    /// <summary>
    /// Логика взаимодействия для TM1.xaml
    /// </summary>
    public partial class TM1 : Window
    {
        public TM1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Temryuksky temryuksky = new Districts.Info.Temryuksky();
            temryuksky.Show();
            this.Close();

        }
    }
}
