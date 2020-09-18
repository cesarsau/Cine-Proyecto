using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Cine
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Login : ContentPage
{
        
        
    public Login()
    {
        InitializeComponent();
        btnclick2.Clicked += btnclick2_Clicked;
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void btnclick2_Clicked(object sender, EventArgs e)
        {
           
        }

        private async void StartLoginIn(object sender, EventArgs e)
        {
            var Email = email.Text;
            var password = Password.Text;

            if (Email.Equals("cesarsauceda@unitec.com") && password.Equals("123456"))
            {

                await Navigation.PushAsync(new ProfilePage());
            }
            else
            {
                DisplayAlert("Error","Correo y/o contraseña incorrecta ","Reintentar");
            }
            }
    }
}