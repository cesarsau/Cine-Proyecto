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
    public partial class CodigoQR : ContentPage
    {
        ZXingBarcodeImageView barcode;

        public CodigoQR()
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
            barcode.BarcodeValue = "Nombre: Cesar \nApellidos: Sauceda \n Cuenta: 61741066";


            //this.Content = barcode;
            qr.Children.Add(barcode);


        }
    }
}