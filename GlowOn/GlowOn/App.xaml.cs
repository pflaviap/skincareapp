using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GlowOn.Views;
using GlowOn.ViewModels;

namespace GlowOn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FloralWhite,
                BarTextColor = Color.DeepPink
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
