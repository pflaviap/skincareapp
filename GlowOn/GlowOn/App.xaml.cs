using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GlowOn.Views;

namespace GlowOn
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#EC3E93"),
                BarTextColor = Color.FloralWhite
        };
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
