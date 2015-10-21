using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento per la pagina vuota è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace CalcolatriceSample
{
    /// <summary>
    /// Pagina vuota che può essere utilizzata autonomamente oppure esplorata all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        private String stringaASchermo;
        private String stringaPrimaDiCancellazione;


        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }


        

        private void toSchermataUno(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Schermata1), null);
        }



        private void buttonKeyboard(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            

            switch (button.Name)
            {
                case "ce":
                    stringaASchermo = "";
                    schermo.Text = "0";
                    break;
                case "c":

                    break;
                case "cancella":
                    stringaASchermo = stringaPrimaDiCancellazione;
                    schermo.Text = stringaASchermo;
                    break;

                case "divisione":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "/";
                    schermo.Text = stringaASchermo;
                    break;
                case "moltiplicazione":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "*";
                    schermo.Text = stringaASchermo;
                    break;
                case "addizione":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "+";
                    schermo.Text = stringaASchermo;
                    break;
                case "sottrazione":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "-";
                    schermo.Text = stringaASchermo;
                    break;
                case "uguale":
                    break;
                case "virgola":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += ".";
                    schermo.Text = stringaASchermo;
                    break;

                case "uno":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "1";
                    schermo.Text = stringaASchermo;
                    break;

                case "due":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "2";
                    schermo.Text = stringaASchermo;
                    break;

                case "tre":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "3";
                    schermo.Text = stringaASchermo;
                    break;

                case "quattro":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "4";
                    schermo.Text = stringaASchermo;
                    break;

                case "cinque":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "5";
                    schermo.Text = stringaASchermo;
                    break;

                case "sei":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "6";
                    schermo.Text = stringaASchermo;
                    break;

                case "sette":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "7";
                    schermo.Text = stringaASchermo;
                    break;

                case "otto":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "8";
                    schermo.Text = stringaASchermo;
                    break;

                case "nove":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "9";
                    schermo.Text = stringaASchermo;
                    break;

                case "zero":
                    stringaPrimaDiCancellazione = stringaASchermo;
                    stringaASchermo += "0";
                    schermo.Text = stringaASchermo;
                    break;


            }
        }
    }
}
