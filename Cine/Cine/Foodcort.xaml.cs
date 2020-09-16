using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
namespace Cine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Foodcort : ContentPage
    {
        
        public Foodcort()
        {

            InitializeComponent();
            combo.IsVisible = false;
            combo2.IsVisible = false;
            

        }
    


        private void Cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;


            if (selectedIndex == 1)
            {
                
                combo.IsVisible = true;
                combo2.IsVisible = false;
               
            }
            else if (selectedIndex == 2)
            {
                combo.IsVisible = true;
                combo2.IsVisible = true;
            }

        }

        private void entrar_Clicked(object sender, EventArgs e)
        {
            int selectedIndex = Cantidad.SelectedIndex;

            if (selectedIndex == -1 && Cantidad.SelectedIndex == -1 && combo.SelectedIndex == -1 && (combo2.IsVisible = true && combo2.SelectedIndex == -1)&&Extras.SelectedIndex==-1&&Bebidas.SelectedIndex==-1&& snacks.SelectedIndex==-1)
            {
                DisplayAlert("Atencion", "Debe Seleccionar Un Producto", "Aceptar");

            }
            else
            { 
                
            double precio=0;
            double precio2=0;
            double bebidas=0;
            double Snacks = 0;
            double extras = 0;
            if (combo.SelectedIndex==1)
            {
                precio = 135.50;
            }else if (combo.SelectedIndex == 2)
            {
                precio = 155.50;
            }
            else if (combo.SelectedIndex == 3)
            {
                precio =85.50;
            }

            if (combo2.SelectedIndex == 1)
            {
                precio2 = 135.50;
            }
            else if (combo2.SelectedIndex == 2)
            {
                precio2 = 155.50;
            }
            else if (combo2.SelectedIndex == 3)
            {
                precio2 = 85.50;
            }

            if (Bebidas.SelectedIndex == 1)
            {
                bebidas = 24;
            }
            else if (Bebidas.SelectedIndex == 2)
            {
                bebidas = 20;
            }
            else if (Bebidas.SelectedIndex == 3)
            {
                bebidas = 15;
            }
                else if (Bebidas.SelectedIndex == 4)
                {
                    bebidas = 15;
                }
                if (snacks.SelectedIndex == 1)
            {
                Snacks = 15;
            }
            else if (snacks.SelectedIndex == 2)
            {
                Snacks = 20;
            }
            else if (snacks.SelectedIndex == 3)
            {
                Snacks = 35;
            }
            
            if (Extras.SelectedIndex == 1)
            {
                extras = 30;
            }
            else if (Extras.SelectedIndex == 2)
            {
                extras = 20;
            }
            else if (Extras.SelectedIndex == 3)
            {
                extras = 50;
            }
            
            double total = bebidas + Snacks + extras + precio+precio2;

            this.Navigation.PushModalAsync(new Facturacion(total));
              }

        }

       
    }
}