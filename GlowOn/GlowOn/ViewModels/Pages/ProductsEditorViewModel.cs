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
    public class ProductsEditorViewModel
    {
        private readonly IProductCatalogue _productCatalogue;
        private readonly IPageService _pageService;
        public Product Product { get; private set; }
        public ICommand SaveCommand { get; set; }
        public ProductsEditorViewModel(ProductViewModel viewModel, IProductCatalogue productCatalogue, IPageService pageService)
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
                SuggestedPrice = viewModel.SuggestedPrice,
                ForSensitive = viewModel.ForSensitive,
                IsInitial = false
            };
        }

        async Task Save()
        {
            if (String.IsNullOrWhiteSpace(Product.ProductName) || String.IsNullOrWhiteSpace(Product.SkinType) || String.IsNullOrWhiteSpace(Product.Category) || String.IsNullOrWhiteSpace(Product.AgeCategory) || String.IsNullOrWhiteSpace(Product.SuggestedPrice))
            {
                await _pageService.DisplayAlert("Error", "Fields marked with * are mandatory.", "OK");
                return;
            }
            if ((Product.AgeCategory != "14-18") && (Product.AgeCategory != "18-30") && (Product.AgeCategory != "30-45") && (Product.AgeCategory != "45+") && (Product.AgeCategory != "Universal"))
            {
                await _pageService.DisplayAlert("Error", "Please enter a valid age category.", "OK");
                return;
            }
            if ((Product.SkinType != "Combination") && (Product.SkinType != "Normal") && (Product.SkinType != "Oily") && (Product.SkinType != "Dry"))
            {
                await _pageService.DisplayAlert("Error", "Please enter a valid skintype.", "OK");
                return;
            }
            if ((Product.Category != "Makeup Remover") && (Product.Category != "Cleanser") && (Product.Category != "Moisturizer") && (Product.Category != "SPF"))
            {
                await _pageService.DisplayAlert("Error", "Please enter a valid category.", "OK");
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
