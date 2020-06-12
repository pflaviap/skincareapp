using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using GlowOn.Models;

namespace GlowOn.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public int id { get; set; }
        public ProductViewModel() { }
        public ProductViewModel(Product product)
        {
            id = product.ID;
            _productName = product.ProductName;
            _brand = product.Brand;
            _skinType = product.SkinType;
            _forSensitive = product.ForSensitive;
            _category = product.Category;
            _ingredients = product.Ingredients;
            _ageCategory = product.AgeCategory;
            _suggestedPrice = product.SuggestedPrice;
            _isInitial = product.IsInitial;
        }

        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set
            {
                SetValue(ref _productName, value);
            }
        }

        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set
            {
                SetValue(ref _brand, value);
            }
        }

        private string _skinType;
        public string SkinType
        {
            get { return _skinType; }
            set
            {
                SetValue(ref _skinType, value);
            }
        }

        private bool _forSensitive;
        public bool ForSensitive
        {
            get { return _forSensitive; }
            set
            {
                SetValue(ref _forSensitive, value);
            }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set
            {
                SetValue(ref _category, value);
                OnPropertyChanged(nameof(ProductImage));
            }
        }

        private string _ingredients;
        public string Ingredients
        {
            get { return _ingredients; }
            set
            {
                SetValue(ref _ingredients, value);
            }
        }

        private string _ageCategory;
        public string AgeCategory
        {
            get { return _ageCategory; }
            set
            {
                SetValue(ref _ageCategory, value);
            }
        }

        private string _suggestedPrice;
        public string SuggestedPrice
        {
            get { return _suggestedPrice; }
            set
            {
                SetValue(ref _suggestedPrice, value);
            }
        }

        private bool _isInitial;
        public bool IsInitial
        {
            get { return _isInitial; }
            set
            {
                SetValue(ref _isInitial, value);
            }
        }
        public ImageSource ProductImage
        {
            get
            {
                if (Category == "Makeup Remover")
                {
                    return ImageSource.FromResource("GlowOn.Assets.Images.makeupRemover.png");
                }
                if (Category == "Cleanser")
                {
                    return ImageSource.FromResource("GlowOn.Assets.Images.cleanser.png");
                }
                if(Category == "Moisturizer")
                {
                    return ImageSource.FromResource("GlowOn.Assets.Images.moisturizer.png");
                }
                return ImageSource.FromResource("GlowOn.Assets.Images.SPF.png");
            }
        }
    }
}
