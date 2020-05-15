using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GlowOn.DBServices;
using GlowOn.ViewModels;
using GlowOn.ViewModels.Pages;

namespace GlowOn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsCatalogue : ContentPage
    {
        public ProductsCatalogue()
        {
            var productCatalogue = new SQLiteProductCatalogue(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            ViewModel = new ProductsCatalogueViewModel(productCatalogue, pageService);
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

        public ProductsCatalogueViewModel ViewModel
        {
            get { return BindingContext as ProductsCatalogueViewModel; }
            set { BindingContext = value; }
        }
    }
}