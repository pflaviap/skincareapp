using GlowOn.ViewModels;
using GlowOn.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlowOn.Views.SkinType
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SensitivityPage : ContentPage
    {
        public SensitivityPage()
        {
            InitializeComponent();
            var pageService = new PageService();
            BindingContext = new SensitivityViewModel(pageService);
        }
    }
}