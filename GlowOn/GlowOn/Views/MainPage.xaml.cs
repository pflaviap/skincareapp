using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GlowOn.Views.Steps;
using GlowOn.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlowOn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            imgLogo.Source = ImageSource.FromResource("GlowOn.Assets.Images.logo.png");
            imgBackground.Source = ImageSource.FromResource("GlowOn.Assets.Images.background.jpg");
            btnQuiz.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnSkintype.png");
            btnRoutine.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnRoutine.png");
            btnCatalogue.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnCatalogue.png");
        }
        private async void QuizClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizPage());
        }
        private async void RoutineClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoutinePage());
        }
        private async void CatalogueClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductsCatalogue());
        }

    }
}