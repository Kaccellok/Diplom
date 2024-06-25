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

namespace Landmark.View.Landmarks.Labinsky
{
    /// <summary>
    /// Логика взаимодействия для Lab3.xaml
    /// </summary>
    public partial class Lab3 : Window
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Labinsky labinsky = new Districts.Info.Labinsky();
            labinsky.Show();
            this.Close();
        }
    }
}
