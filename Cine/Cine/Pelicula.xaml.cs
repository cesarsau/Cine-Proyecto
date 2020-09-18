using Cine.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pelicula : ContentPage
    {
        public Pelicula()
        {

            InitializeComponent();
            BindingContext = new Peliculasviewmodels();
        }

        
    }
}