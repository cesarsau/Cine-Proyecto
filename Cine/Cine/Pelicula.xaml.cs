using Cine.Models;
using Cine.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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