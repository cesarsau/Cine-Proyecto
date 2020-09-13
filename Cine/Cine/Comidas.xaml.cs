using Android.Widget;
using Cine.Models;
using Cine.ViewModels;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using ImageButton = Xamarin.Forms.PlatformConfiguration.AndroidSpecific.ImageButton;

namespace Cine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comidas : ContentPage
    {
        
        public Comidas()
        {
            InitializeComponent();
            BindingContext = new Comidaviewmodels();
           
        }

        private void boton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Foodcort());
        }
    }
}

