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

    public partial class Registro : ContentPage
    {
        public Registro(double total)
        {
            InitializeComponent();
            Total.Text ="Total a Pagar: Lps."+ total.ToString();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            
           
            this.Navigation.PushModalAsync(new Foodcort());
        }
    }
}