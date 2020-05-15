using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using GlowOn.Views;
using GlowOn.Models;
using GlowOn.ViewModels.Interfaces;
using Xamarin.Forms;

namespace GlowOn.ViewModels.Pages
{
    public class ProductsCatalogueViewModel : BaseViewModel
    {
        private ProductViewModel _selectedProduct;
        private IProductCatalogue _productCatalogue;
        private IPageService _pageService;

        private bool _isDataLoaded;

        public ObservableCollection<ProductViewModel> Products { get; private set; }
            = new ObservableCollection<ProductViewModel>();

        public ProductViewModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { SetValue(ref _selectedProduct, value); }
        }

        public ICommand LoadDataCommand { get; private set; }
        public ICommand AddProductCommand { get; private set; }
        public ICommand SelectProductCommand { get; private set; }
        public ICommand DeleteProductCommand { get; private set; }
        public ICommand SearchCommand { get; private set; }

        public ProductsCatalogueViewModel(IProductCatalogue productCatalogue, IPageService pageService)
        {
            _productCatalogue = productCatalogue;
            _pageService = pageService;

            LoadDataCommand = new Command(async () => await LoadData());
            AddProductCommand = new Command(async () => await AddProduct());
            SelectProductCommand = new Command<ProductViewModel>(async p => await SelectProduct(p));
            DeleteProductCommand = new Command<ProductViewModel>(async p => await DeleteProduct(p));

            MessagingCenter.Subscribe<ProductsDetailViewModel, Product>
                (this, Events.ProductAdded, OnProductAdded);

            MessagingCenter.Subscribe<ProductsDetailViewModel, Product>
                (this, Events.ProductUpdated, OnProductUpdated);
        }

        private void OnProductAdded(ProductsDetailViewModel source, Product product)
        {
            Products.Add(new ProductViewModel(product));
        }

        private void OnProductUpdated(ProductsDetailViewModel source, Product product)
        {
            var productInList = Products.Single(p => p.id == product.ID);

            productInList.id = product.ID;
            productInList.ProductName = product.ProductName;
            productInList.Brand = product.Brand;
            productInList.SkinType = product.SkinType;
            productInList.ForSensitive = product.ForSensitive;
            productInList.Category = product.Category;
            productInList.Ingredients = product.Ingredients;
            productInList.AgeCategory = product.AgeCategory;
            productInList.ExtraInfo = product.ExtraInfo;
        }

        private async Task LoadData()
        {
            if (_isDataLoaded)
                return;

            _isDataLoaded = true;
            var products = await _productCatalogue.GetProductsAsync();
            foreach (var product in products)
                Products.Add(new ProductViewModel(product));
        }

        private async Task AddProduct()
        {
            await _pageService.PushAsync(new ProductsDetail(new ProductViewModel()));
        }

        private async Task SelectProduct(ProductViewModel product)
        {
            if (product == null)
                return;

            SelectedProduct = null;
            await _pageService.PushAsync(new ProductsDetail(product));
        }

        private async Task DeleteProduct(ProductViewModel productViewModel)
        {
            if (await _pageService.DisplayAlert("Warning", $"Are you sure you want to delete {productViewModel.ProductName}?", "Yes", "No"))
            {
                Products.Remove(productViewModel);

                var product = await _productCatalogue.GetProduct(productViewModel.id);
                await _productCatalogue.DeleteProduct(product);
            }
        }
    }
}
