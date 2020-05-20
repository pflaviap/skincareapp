using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlowOn.Views.Steps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoutinePage : ContentPage
    {
        public RoutinePage()
        {
            InitializeComponent();
            imgBackground.Source = ImageSource.FromResource("GlowOn.Assets.Images.background.jpg");
            btnMakeupRemover.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnMakeupRemover.png");
            btnCleanser.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnCleanser.png");
            btnMoisturizer.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnMoisturizer.png");
            btnSPF.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnSPF.png");
        }
        private async void Step1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MakeupRemoversDisplayer());
        }
        private async void Step2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CleansersDisplayer());
        }
        private async void Step3Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HydratingCreamsDisplayer());
        }
        private async void Step4Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SPFsDisplayer());
        }
    }
}