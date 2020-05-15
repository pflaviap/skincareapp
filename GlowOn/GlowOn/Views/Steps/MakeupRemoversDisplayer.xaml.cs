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
    public partial class MakeupRemoversDisplayer : ContentPage
    {
        public MakeupRemoversDisplayer()
        {
            InitializeComponent();
            var routineUsers = new SQLiteUsers(DependencyService.Get<ISQLiteDb>());
            var products = new SQLiteProductCatalogue(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            ViewModel = new DisplayerViewModel(routineUsers, products, pageService, "Makeup Remover");
        }

        private async void ChangeCharacteristicsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormPage(new UserViewModel()));
        }

        protected override void OnAppearing()
        {
            ViewModel.LoadDataCommand.Execute(null);
            base.OnAppearing();
        }

        public DisplayerViewModel ViewModel
        {
            get { return BindingContext as DisplayerViewModel; }
            set { BindingContext = value; }
        }
    }
}