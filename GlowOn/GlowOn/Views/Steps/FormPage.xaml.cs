using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GlowOn.ViewModels;
using GlowOn.ViewModels.Pages;
using GlowOn.DBServices;

namespace GlowOn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormPage : ContentPage
    {
        public FormPage(UserViewModel viewModel)
        {
            InitializeComponent();
            imgBackground.Source = ImageSource.FromResource("GlowOn.Assets.Images.background.jpg");
            btnSaveChanges.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnSaveChanges.png");
            var user = new SQLiteUsers(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            BindingContext = new FormViewModel(new UserViewModel(), user, pageService);
        }
    }
}