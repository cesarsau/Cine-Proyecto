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
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Init();
            NavigationPage navigationPage = new NavigationPage(new Login());
            navigationPage.IconImageSource = "ic_login.png";
          
            Children.Add(navigationPage);
        }

        void Init()
        {
        }
    }
}