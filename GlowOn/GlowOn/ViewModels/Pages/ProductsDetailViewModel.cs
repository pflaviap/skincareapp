using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using GlowOn.ViewModels.Interfaces;
using GlowOn.Models;
using Xamarin.Forms;

namespace GlowOn.ViewModels.Pages
{
    public class ProductsDetailViewModel
    {
        private readonly IProductCatalogue _productCatalogue;
        private readonly IPageService _pageService;
        public Product Product { get; private set; }
        public ICommand SaveCommand { get; set; }
        public ProductsDetailViewModel(ProductViewModel viewModel, IProductCatalogue productCatalogue, IPageService pageService)
        {
            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            _pageService = pageService;
            _productCatalogue = productCatalogue;

            SaveCommand = new Command(async () => await Save());

            Product = new Product
            {
                ID = viewModel.id,
                ProductName = viewModel.ProductName,
                Brand = viewModel.Brand,
                SkinType = viewModel.SkinType,
                Category = viewModel.Category,
                Ingredients = viewModel.Ingredients,
                AgeCategory = viewModel.AgeCategory,
                ExtraInfo = viewModel.ExtraInfo,
                ForSensitive = viewModel.ForSensitive
            };
        }

        async Task Save()
        {
            if (String.IsNullOrWhiteSpace(Product.ProductName) || String.IsNullOrWhiteSpace(Product.SkinType))
            {
                await _pageService.DisplayAlert("Error", "Please enter the name and the skin type.", "OK");
                return;
            }
            if (Product.ID == 0)
            {
                await _productCatalogue.AddProduct(Product);
                MessagingCenter.Send(this, Events.ProductAdded, Product);
            }
            else
            {
                await _productCatalogue.UpdateProduct(Product);
                MessagingCenter.Send(this, Events.ProductUpdated, Product);
            }
            await _pageService.PopAsync();
        }
    }
}
