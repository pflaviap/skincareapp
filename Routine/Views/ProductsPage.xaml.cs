using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Routine.Persistence;
using Routine.ViewModels;
using Routine.ViewModels.Pages;

namespace Routine.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            var productCatalogue = new SQLiteProductCatalogue(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            ViewModel = new ProductsPageViewModel(productCatalogue, pageService);
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ViewModel.LoadDataCommand.Execute(null);
            base.OnAppearing();
        }

        void OnProductSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectProductCommand.Execute(e.SelectedItem);
        }

        public ProductsPageViewModel ViewModel
        {
            get { return BindingContext as ProductsPageViewModel; }
            set { BindingContext = value; }
        }
    }
}