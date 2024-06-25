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

namespace Landmark.View.Landmarks.Ust_Labinsky
{
    /// <summary>
    /// Логика взаимодействия для UL2.xaml
    /// </summary>
    public partial class UL2 : Window
    {
        public UL2()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Districts.Info.UstLabinsky ustLabinsky = new Districts.Info.UstLabinsky();
            ustLabinsky.Show();
            this.Close();
        }
    }
}
