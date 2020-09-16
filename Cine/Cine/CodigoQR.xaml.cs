using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Media;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace Cine
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CodigoQR : ContentPage
	{
		ZXingBarcodeImageView barcode;

		public CodigoQR(string codigo)
		{
			InitializeComponent();

			

			barcode = new ZXingBarcodeImageView
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				AutomationId = "zxingBarcodeImageView",
			};
			barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
			barcode.BarcodeOptions.Width = 300;
			barcode.BarcodeOptions.Height = 300;
			barcode.BarcodeOptions.Margin = 10;
			barcode.BarcodeValue = codigo;


			//this.Content = barcode;
			qr.Children.Add(barcode);

		}

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
			bool bnt= await DisplayAlert("¿Salir?", "Guarde los datos o se perderan", "Si", "No");

			if (bnt == true)
			{
                await this.Navigation.PushModalAsync(new TabbedPage1());
				IsVisible=false;
			}
		}
    }		
    
}
