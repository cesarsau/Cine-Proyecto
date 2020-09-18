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
    public partial class Facturacion : ContentPage
    {
        public Facturacion(double total)
        {
            InitializeComponent();
            Total.Text = "Lps. "+total.ToString();
            gif.IsVisible = false;
        }

      

        private void Pagar_Clicked_1(object sender, EventArgs e)
        {
            if (Nombre.Text==""||Correo.Text==""||Telefono.Text==""||Direccion.Text==""||tarjeta.Text==""|| fecha.Text==""||codigo.Text=="")
            {
                DisplayAlert("Atencion","Llene todos los datos","Aceptar");
            }
            else
            {
                int longitud = 14;
                const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                StringBuilder token = new StringBuilder();
                Random rnd = new Random();

                for (int i = 0; i < longitud; i++)
                {
                    int indice = rnd.Next(alfabeto.Length);
                    token.Append(alfabeto[indice]);

                }
                if (tarjeta.Text=="4214 4214 4214 4214"&&fecha.Text=="12/21"&&codigo.Text=="426")
                {
                    gif.IsVisible = true;
                    System.Threading.Thread.Sleep(10000);
                    Pagar.IsVisible = false;
                    this.Navigation.PushModalAsync(new CodigoQR(token.ToString()));
                }
                else
                {
                    DisplayAlert("Atencion","Tarjeta Invalida","Reintentar");
                }                
            }
            
        }
    }
}