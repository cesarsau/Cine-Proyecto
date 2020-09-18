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
        
            
        }

        private void btnclick2_Clicked(object sender, EventArgs e)
        {
           
        }

        private void StartLoginIn(object sender, EventArgs e)
        {
            var Email = email.Text;
            var password = Password.Text;

            if (Email.Equals("example@example.com") && password.Equals("123"))
            {
                DisplayAlert("Login", "Login Success", "Okay");

                Navigation.PushModalAsync(new ProfilePage());
            }
        }
    }
}