using Landmark.View.Districts.Info;
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

namespace Landmark.View.Districts
{
    /// <summary>
    /// Логика взаимодействия для DistrictsList.xaml
    /// </summary>
    public partial class DistrictsList : Window
    {
        public DistrictsList()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btn_Abn_Click(object sender, RoutedEventArgs e)
        {
            Abinsk abinsky = new Abinsk();
            abinsky.Show();
            this.Close();
        }

        private void btn_Anapa_Click(object sender, RoutedEventArgs e)
        {
            Anapa anapa = new Anapa();
            anapa.Show();
            this.Close();
        }

        private void btn_Apsh_Click(object sender, RoutedEventArgs e)
        {
            Apsheronsky apsheronsky = new Apsheronsky();
            apsheronsky.Show();
            this.Close();
        }

        private void btn_Arm_Click(object sender, RoutedEventArgs e)
        {
            Armavir arm = new Armavir();
            arm.Show();
            this.Close();
        }

        private void btn_Blg_Click(object sender, RoutedEventArgs e)
        {
            Beloglinsky beloglinsky = new Beloglinsky();
            beloglinsky.Show();
            this.Close();
        }

        private void btn_Brh_Click(object sender, RoutedEventArgs e)
        {
            Bryukhovetsky bryukhovetsky = new Bryukhovetsky();
            bryukhovetsky.Show();
            this.Close();
        }

        private void btn_Vsl_Click(object sender, RoutedEventArgs e)
        {
            Vyselkovsky vyselkovsky = new Vyselkovsky();
            vyselkovsky.Show();
            this.Close();
        }

        private void btn_Gel_Click(object sender, RoutedEventArgs e)
        {
            Gelendzhik gelendzhik = new Gelendzhik();
            gelendzhik.Show();
            this.Close();
        }

        private void btn_Gor_Click(object sender, RoutedEventArgs e)
        {
            GoryachiyKlyuch goryachiyKlyuch = new GoryachiyKlyuch();
            goryachiyKlyuch.Show();
            this.Close();
        }

        private void btn_Din_Click(object sender, RoutedEventArgs e)
        {
            Dinskoy dinskoy = new Dinskoy();
            dinskoy.Show();
            this.Close();
        }

        private void btn_Eysk_Click(object sender, RoutedEventArgs e)
        {
            Yeisk yeisk = new Yeisk();
            yeisk.Show();
            this.Close();
        }

        private void btn_Kvkz_Click(object sender, RoutedEventArgs e)
        {
            Kavkazsky kavkazsky = new Kavkazsky();
            kavkazsky.Show();
            this.Close();
        }

        private void btn_Kln_Click(object sender, RoutedEventArgs e)
        {
            Kalininsky kalininsky = new Kalininsky();
            kalininsky.Show();
            this.Close();
        }

        private void btn_Knv_Click(object sender, RoutedEventArgs e)
        {
            Kanevskaya kanevskaya = new Kanevskaya();
            kanevskaya.Show();
            this.Close();
        }

        private void btn_Krn_Click(object sender, RoutedEventArgs e)
        {
            Korenovsky korenovsky = new Korenovsky();
            korenovsky.Show();
            this.Close();
        }

        private void btn_Krs_Click(object sender, RoutedEventArgs e)
        {
            Krasnoarmeysky krasnoarmeysky = new Krasnoarmeysky();
            krasnoarmeysky.Show();
            this.Close();
        }

        private void btn_Krd_Click(object sender, RoutedEventArgs e)
        {
            Krasnodar krasnodar = new Krasnodar();
            krasnodar.Show();
            this.Close();
        }

        private void btn_Krl_Click(object sender, RoutedEventArgs e)
        {
            Krylovsky krylovsky = new Krylovsky();
            krylovsky.Show();
            this.Close();
        }

        private void btn_Krm_Click(object sender, RoutedEventArgs e)
        {
            Krymsky krymsky = new Krymsky();
            krymsky.Show();
            this.Close();
        }

        private void btn_Krg_Click(object sender, RoutedEventArgs e)
        {
            Kurganinsky kurganinsky = new Kurganinsky();
            kurganinsky.Show();
            this.Close();
        }

        private void btn_Ksh_Click(object sender, RoutedEventArgs e)
        {
            Kushchevsky kushchevsky = new Kushchevsky();
            kushchevsky.Show();
            this.Close();
        }

        private void btn_Lab_Click(object sender, RoutedEventArgs e)
        {
            Labinsky labinsky = new Labinsky();
            labinsky.Show();
            this.Close();
        }

        private void btn_Lng_Click(object sender, RoutedEventArgs e)
        {
            Leningrad leningrad = new Leningrad();
            leningrad.Show();
            this.Close();
        }

        private void btn_Mst_Click(object sender, RoutedEventArgs e)
        {
            Mostovsky mostovsky = new Mostovsky();
            mostovsky.Show();
            this.Close();
        }

        private void btn_Nvk_Click(object sender, RoutedEventArgs e)
        {
            Novokubansky novokubansky = new Novokubansky();
            novokubansky.Show();
            this.Close();
        }

        private void btn_Nvp_Click(object sender, RoutedEventArgs e)
        {
            Novopokrovsky novopokrovsky = new Novopokrovsky();
            novopokrovsky.Show();
            this.Close();
        }

        private void btn_Nvr_Click(object sender, RoutedEventArgs e)
        {
            Novorossiysk novorossiysk = new Novorossiysk();
            novorossiysk.Show();
            this.Close();
        }

        private void btn_Otr_Click(object sender, RoutedEventArgs e)
        {
            Otradnensky otradnensky = new Otradnensky();
            otradnensky.Show();
            this.Close();
        }

        private void btn_Pvl_Click(object sender, RoutedEventArgs e)
        {
            Pavlovsky pavlovsky = new Pavlovsky();
            pavlovsky.Show();
            this.Close();
        }

        private void btn_Prm_Click(object sender, RoutedEventArgs e)
        {
            PrimorskoAkhtarsky primorskoAkhtarsky = new PrimorskoAkhtarsky();
            primorskoAkhtarsky.Show();
            this.Close();
        }

        private void btn_Svr_Click(object sender, RoutedEventArgs e)
        {
            Seversky seversky = new Seversky();
            seversky.Show();
            this.Close();
        }

        private void btn_Sirius_Click(object sender, RoutedEventArgs e)
        {
            Sirius sirius = new Sirius();
            sirius.Show();
            this.Close();
        }

        private void btn_Slv_Click(object sender, RoutedEventArgs e)
        {
            Slavyansky slavyansky = new Slavyansky();
            slavyansky.Show();
            this.Close();
        }

        private void btn_Sochi_Click(object sender, RoutedEventArgs e)
        {
            Sochi sochi = new Sochi();
            sochi.Show();
            this.Close();
        }

        private void btn_Str_Click(object sender, RoutedEventArgs e)
        {
            Starominskaya starominskaya = new Starominskaya();
            starominskaya.Show();
            this.Close();
        }

        private void btn_Tbl_Click(object sender, RoutedEventArgs e)
        {
            Tbilisi tbilisi = new Tbilisi();
            tbilisi.Show();
            this.Close();
        }

        private void btn_Tmr_Click(object sender, RoutedEventArgs e)
        {
            Temryuksky temryuksky = new Temryuksky();
            temryuksky.Show();
            this.Close();
        }

        private void btn_Tps_Click(object sender, RoutedEventArgs e)
        {
            Tuapse tuapse = new Tuapse();
            tuapse.Show();
            this.Close();
        }

        private void btn_Usp_Click(object sender, RoutedEventArgs e)
        {
            Uspensky uspensky = new Uspensky();
            uspensky.Show();
            this.Close();
        }

        private void btn_Usl_Click(object sender, RoutedEventArgs e)
        {
            UstLabinsky ustLabinsky = new UstLabinsky();
            ustLabinsky.Show();
            this.Close();
        }

        private void btn_Shrb_Click(object sender, RoutedEventArgs e)
        {
            Shcherbinovsky shcherbinovsky = new Shcherbinovsky();
            shcherbinovsky.Show();
            this.Close();
        }

        private void btn_Glk_Click(object sender, RoutedEventArgs e)
        {
            Gulkevichsky gulkevichsky = new Gulkevichsky();
            gulkevichsky.Show();
            this.Close();
        }
    }
}
