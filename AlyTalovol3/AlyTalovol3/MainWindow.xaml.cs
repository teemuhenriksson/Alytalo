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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int sammutettu = 0;
        int puolihimmea = 25;
        int valoisa = 75;
        int kirkas = 100;
        string prosentti = "%";

        public string Dimmer;
        public string Text;
        private object passingText;


        public MainWindow()
        {
            InitializeComponent();
        }

        //saunan päällelaitto
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string viesti = " Sauna on päällä ";
            if (true)
            {
                textBox.Text = (viesti);
            }
        }

        //sauna pois päältä
        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                textBox.Text = "Sauna ei ole päällä";
            }
        }

        //olohuone
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlock1.Text = "" + slider.Value;
        }


        //keittiö
        private void slider_Copy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlock.Text = "" + slider_Copy.Value;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
        }
    }
