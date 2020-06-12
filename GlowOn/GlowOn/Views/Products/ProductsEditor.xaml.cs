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
    public partial class ProductsEditor : ContentPage
    {
        public ProductsEditor(ProductViewModel viewModel)
        {
            InitializeComponent();
            imgBackground.Source = ImageSource.FromResource("GlowOn.Assets.Images.background.jpg");
            btnSave.Source = ImageSource.FromResource("GlowOn.Assets.Images.btnSave.png");
            var productStore = new SQLiteProductCatalogue(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            Title = (viewModel.ProductName == null) ? "New Product" : "Edit " + viewModel.ProductName;
            BindingContext = new ProductsEditorViewModel(viewModel ?? new ProductViewModel(), productStore, pageService);
        }
    }
}