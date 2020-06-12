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
        public ProductsDetailViewModel(ProductViewModel viewModel, IProductCatalogue productCatalogue, IPageService pageService)
        {
            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            _pageService = pageService;
            _productCatalogue = productCatalogue;

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
                IsInitial = viewModel.IsInitial
            };
        }
    }
}
