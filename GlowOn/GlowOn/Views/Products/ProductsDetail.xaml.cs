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
    public partial class ProductsDetail : ContentPage
    {
        public ProductsDetail(ProductViewModel viewModel)
        {
            InitializeComponent();
            var productStore = new SQLiteProductCatalogue(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            Title = (viewModel.ProductName == null) ? "New Product" : "Edit Product";
            BindingContext = new ProductsDetailViewModel(viewModel ?? new ProductViewModel(), productStore, pageService);
        }
    }
}