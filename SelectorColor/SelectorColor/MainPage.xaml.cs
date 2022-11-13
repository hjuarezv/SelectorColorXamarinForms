using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SelectorColor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MostrarColor(object sender, ValueChangedEventArgs e)
        {
            var valorRojo = (int)sliderRojo.Value;
            var valorVerde = (int)sliderVerde.Value;
            var valorAzul = (int)sliderAzul.Value;

            String strColor = String.Format("#{0:X2}{1:X2}{2:X2}", (int)valorRojo, (int)valorVerde, (int)valorAzul);
            
            boxColor.BackgroundColor = Color.FromHex(strColor);

            lblColor.Text = "Color en Hex: " + strColor;
        }
    }
}
