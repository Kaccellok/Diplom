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
    /// Логика взаимодействия для Gel7.xaml
    /// </summary>
    public partial class Gel7 : Window
    {
        public Gel7()
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
