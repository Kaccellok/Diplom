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

namespace Landmark.View.Landmarks.Krymsky
{
    /// <summary>
    /// Логика взаимодействия для Krym2.xaml
    /// </summary>
    public partial class Krym2 : Window
    {
        public Krym2()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Krymsky krymsky = new Districts.Info.Krymsky();
            krymsky.Show();
            this.Close();
        }
    }
}
