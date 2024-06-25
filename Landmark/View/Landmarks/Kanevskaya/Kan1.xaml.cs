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

namespace Landmark.View.Landmarks.Kanevskaya
{
    /// <summary>
    /// Логика взаимодействия для Kan1.xaml
    /// </summary>
    public partial class Kan1 : Window
    {
        public Kan1()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Kanevskaya kanevskaya = new Districts.Info.Kanevskaya();
            kanevskaya.Show();
            this.Close();
        }
    }
}
