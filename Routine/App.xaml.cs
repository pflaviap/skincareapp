using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Routine.Views;
using Routine.ViewModels;

namespace Routine
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Registration(new UserViewModel()));
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
