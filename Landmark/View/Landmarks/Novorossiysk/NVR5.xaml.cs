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

namespace Landmark.View.Landmarks.Novorossiysk
{
    /// <summary>
    /// Логика взаимодействия для NVR5.xaml
    /// </summary>
    public partial class NVR5 : Window
    {
        public NVR5()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.Novorossiysk novorossiysk = new Districts.Info.Novorossiysk();
            novorossiysk.Show();
            this.Close();
        }
    }
}
