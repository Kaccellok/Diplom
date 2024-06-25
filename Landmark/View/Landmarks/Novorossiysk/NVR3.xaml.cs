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
    /// Логика взаимодействия для NVR3.xaml
    /// </summary>
    public partial class NVR3 : Window
    {
        public NVR3()
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
