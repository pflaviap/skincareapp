using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Routine.ViewModels;
using Routine.ViewModels.Pages;
using Routine.Persistence;

namespace Routine.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsDetailPage : ContentPage
    {
        public ProductsDetailPage(ProductViewModel viewModel)
        {
            InitializeComponent();
            var productStore = new SQLiteProductCatalogue(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            Title = (viewModel.ProductName == null) ? "New Product" : "Edit Product";
            BindingContext = new ProductsDetailViewModel(viewModel ?? new ProductViewModel(), productStore, pageService);
        }
    }
}