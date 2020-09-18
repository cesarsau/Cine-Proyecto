using Cine.ViewModels;
using System;
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
            Init();

            
        }

        void Init()
        {
            App.StartCheckIfInternet(LblNoInternet, this);
           
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}