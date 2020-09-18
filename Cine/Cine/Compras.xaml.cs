using System;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Java.Util.Jar.Attributes;

namespace Cine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Compras : ContentPage
    {
        private Timer timer;

        public Compras()
        {
            InitializeComponent();
            Asiento.IsVisible = false;
            Asiento2.IsVisible = false;
            asiento.IsVisible = false;
            asiento2.IsVisible = false;
        }

        private void Listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex == 0)
            {
                Hora.Time = new TimeSpan(16, 30, 00);
                Fecha.Date = new DateTime(2020, 10, 5);
            } else if (selectedIndex == 1)
            {
                Hora.Time = new TimeSpan(15, 30, 00);
                Fecha.Date = new DateTime(2020, 09, 18);
            }
            else if(selectedIndex == 2)
            {
                Hora.Time = new TimeSpan(10, 30, 00);
                Fecha.Date = new DateTime(2020, 09, 25);
            } else if (selectedIndex == 3)
            {
                Hora.Time = new TimeSpan(13, 30, 00);
                Fecha.Date = new DateTime(2020, 09, 21);
            }
            else if (selectedIndex == 4)
            {
                Hora.Time = new TimeSpan(18, 30, 00);
                Fecha.Date = new DateTime(2020, 09, 19);
            }
            else if (selectedIndex == 5)
            {
                Hora.Time = new TimeSpan(20, 30, 00);
                Fecha.Date = new DateTime(2020, 10, 05);
            }
            else if (selectedIndex == 6)
            {
                Hora.Time = new TimeSpan(15, 30, 00);
                Fecha.Date = new DateTime(2020, 09, 17);
            }
            else if (selectedIndex == 7)
            {
                Hora.Time = new TimeSpan(17, 30, 00);
                Fecha.Date = new DateTime(2020, 09, 19);
            }
            else if (selectedIndex == 8)
            {
                Hora.Time = new TimeSpan(10, 30, 00);
                Fecha.Date = new DateTime(2020, 09, 20);
            }
            else if (selectedIndex == 9)
            {
                Hora.Time = new TimeSpan(16, 30, 00);
                Fecha.Date = new DateTime(2020, 09, 21);
            }
        }

        private void Cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex == 0)
            {
                Asiento.IsVisible = true;
                Asiento2.IsVisible = false;
                asiento.IsVisible = true;
                asiento2.IsVisible = false;
            } else if (selectedIndex == 1)
            {
                asiento.IsVisible = true;
                asiento2.IsVisible = true;
                Asiento.IsVisible = true;
                Asiento2.IsVisible = true;
            }
        }

        private void entrar_Clicked(object sender, EventArgs e)
        {
            int selectedIndex = Listado.SelectedIndex;

            if (selectedIndex == -1 || Cantidad.SelectedIndex == -1 || Asiento.SelectedIndex == -1 && (Asiento2.IsVisible = true && Asiento2.SelectedIndex == -1))
            {
                DisplayAlert("Atencion", "Debe llenar todos los campos", "Aceptar");
            } else if (Asiento2.SelectedIndex == Asiento.SelectedIndex)
            {
                DisplayAlert("Atencion", "Seleccione Otro Asiento 2", "Aceptar");
            }
            else
            {
                DisplayAlert("¡Gracias Por su Compra!", "Esperamos los disfrutes", "Aceptar");
            }
        }
    }
}