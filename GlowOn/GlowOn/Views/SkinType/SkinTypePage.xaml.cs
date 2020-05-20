using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GlowOn.ViewModels;
using GlowOn.ViewModels.Pages;

namespace GlowOn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkinTypePage : ContentPage
    {
        public SkinTypePage()
        {
            InitializeComponent();
            imgBackground.Source = ImageSource.FromResource("GlowOn.Assets.Images.background.jpg");
            btnResult.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnGetResults.png");
            var pageService = new PageService();
            BindingContext = new SkinTypeViewModel(pageService);
        }
    }
}