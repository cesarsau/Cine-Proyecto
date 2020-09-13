using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cine
{
    public partial class App : Application
    { 
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage(new TabbedPage1());
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.White);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
