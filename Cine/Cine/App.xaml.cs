using Cine.Data;
using Cine.Models;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cine
{
    public partial class App : Application
    {
        private static Label LabelScreen;
        private static bool HashInternet;
        private static Page CurrentPage;
        private static Timer timer;
        private static bool NoInterShow;
        private static Button ButtonScreen;

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new TabbedPage1());
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

        public static void StartCheckIfInternet(Label label, Page page)
        {
            LabelScreen = label;
            label.Text = Constants.NoInternetText;
            label.IsVisible = true;
            HashInternet = true;
            CurrentPage = page;
            if (timer == null)
            {
                timer = new Timer((e) =>
                {
                    CheckIfInternetOverTime();
                }, null, 10, (int)TimeSpan.FromSeconds(3).TotalMilliseconds);
            }
        }

        public static void CheckIfInternetOverTime()
        {
            var NetworkConnection = DependencyService.Get<INetworkConnection>();
            NetworkConnection.CheckNetworkConnection();
            if (!NetworkConnection.IsConnected)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    if (HashInternet)
                    {
                        if (!NoInterShow)
                        {
                            HashInternet = false;
                            LabelScreen.IsVisible = true;
                            await ShowDisplayAlert();
                        }
                    }
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    HashInternet = true;
                    LabelScreen.IsVisible = false;
                });
            }
        }

        public static bool CheckIfInternet()
        {
            var NetworkConnection = DependencyService.Get<INetworkConnection>();
            NetworkConnection.CheckNetworkConnection();
            return NetworkConnection.IsConnected;
        }

        public static async Task<bool> CheckIfInternetAlert()
        {
            var NetworkConnection = DependencyService.Get<INetworkConnection>();
            NetworkConnection.CheckNetworkConnection();
            if (!NetworkConnection.IsConnected)
            {
                if (!NoInterShow)
                {
                    await ShowDisplayAlert();
                }
                return await Task.FromResult<bool>(false);
            }
            return await Task.FromResult<bool>(true);
        }

        public static async Task ShowDisplayAlert()
        {
            NoInterShow = false;
            await CurrentPage.DisplayAlert("Internet", "Device has no Internet, please reconnect", "Okay");
        }
    }
}
