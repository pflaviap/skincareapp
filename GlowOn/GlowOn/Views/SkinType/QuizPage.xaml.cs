using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GlowOn.Views.SkinType;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlowOn.Views.SkinType
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        public QuizPage()
        {
            InitializeComponent();
            imgBackground.Source = ImageSource.FromResource("GlowOn.Assets.Images.background.jpg");
            btnSkintype.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnSkintypeQuiz.png");
            btnSensitivity.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnSensitivityQuiz.png");
        }
        private async void SkintypeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SkinTypePage());
        }
        private async void SensitivityClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SensitivityPage());
        }
    }
}