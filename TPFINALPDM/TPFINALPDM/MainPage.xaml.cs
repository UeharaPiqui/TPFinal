using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFINALPDM.Views;
using Xamarin.Forms;

namespace TPFINALPDM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnCRUD_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CRUDMercadoria());
        }

        private async void BtnGeo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeoLocalizaPage());
        }

        private async void BtnCreditos_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Desenvolvedores", "Guilherme Uehara 1440209 \n Isabelle Gomes da Silva 3000249", "Ok");
        }
    }
}
