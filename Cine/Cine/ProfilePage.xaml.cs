using Cine.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        public ProfilePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = new Validarviewmodels();
        }
        private async void LogoutClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Salir", "¿Desea Salir?", "Si", "No");
            if (answer)
            {
                await Navigation.PushAsync(new Login());
            }
            else
            {
               
            }
        }
    }
}