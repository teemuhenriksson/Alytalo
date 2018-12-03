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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlyTalovol3
{

    public partial class MainWindow : Window
    {

        public MainWindow()        

        {
            InitializeComponent();
            }
            public Thermostat TalonLampo = new Thermostat();
        }

        //sauna päälle
        public void button1_Click(object sender, RoutedEventArgs e)
        {

            string viesti = "Sauna on päällä";
            if (true)
            {
                SaunaOnOfftxt.Text = (viesti);
            }
        }

        //sauna pois päältä
        public void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                SaunaOnOfftxt.Text = "Sauna ei ole päällä";
            }           
        }

        //olohuone
        public void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {      
            OloHuoneValotxt.Text = "" + OloHuoneSlider.Value;
        }


        //keittiö
        public void slider_Copy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            KeittioValotxt.Text = "" + KeittioSlider.Value;
        }

        public void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        public void button2_Click(object sender, RoutedEventArgs e)
        {
            {
                KeittioValotxt.Text = OloHuoneValotxt.Text;
                OloHuoneValotxt.Clear();
            }
        }

        public void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        public void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }

        //valot 0-100

        private void Kirkas_Click(object sender, RoutedEventArgs e)
        {
            string viesti = "OFF";
            if (true)
            {
                ValoOhjaus2txt.Text = (viesti);
            }
        }

        private void HÄMÄRÄ_Click(object sender, RoutedEventArgs e)
        {
            string viesti = "33%";
            if (true)
            {
                ValoOhjaus2txt.Text = (viesti);
            }
        }

        private void PUOLIVALOT_Click(object sender, RoutedEventArgs e)
        {
            string viesti = "66%";
            if (true)
            {
                ValoOhjaus2txt.Text = (viesti);
            }
        }

        private void KIRKAS_Click_1(object sender, RoutedEventArgs e)
        {
            string viesti = "100%";
            if (true)
            {
                ValoOhjaus2txt.Text = (viesti);
            }
        }

    }
}
