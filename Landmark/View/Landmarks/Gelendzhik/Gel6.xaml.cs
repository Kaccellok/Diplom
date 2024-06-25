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

namespace Landmark.View.Landmarks.Gelendzhik
{
    /// <summary>
    /// Логика взаимодействия для Gel6.xaml
    /// </summary>
    public partial class Gel6 : Window
    {
        public Gel6()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Gelendzhik gelendzhik = new Districts.Info.Gelendzhik();
            gelendzhik.Show();
            this.Close();
        }
    }
}
