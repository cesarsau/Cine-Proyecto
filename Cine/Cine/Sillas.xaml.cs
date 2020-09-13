using Cine.Models;
using Cine.ViewModels;
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
    public partial class Sillas : ContentPage
    {
        public Sillas()
        {
            InitializeComponent();
            BindingContext = new Sillaciewmodals();
           
        }

    }
}