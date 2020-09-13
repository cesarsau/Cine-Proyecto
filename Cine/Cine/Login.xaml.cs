using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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
           this.Navigation.PushModalAsync(new Registro());
        }
    }
}