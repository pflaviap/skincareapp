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
            _extraInfo = product.ExtraInfo;
        }

        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set
            {
                SetValue(ref _productName, value);
                OnPropertyChanged(nameof(ProductName));
            }
        }

        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set
            {
                SetValue(ref _brand, value);
                OnPropertyChanged(nameof(Brand));
            }
        }

        private string _skinType;
        public string SkinType
        {
            get { return _skinType; }
            set
            {
                SetValue(ref _skinType, value);
                OnPropertyChanged(nameof(SkinType));
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
                OnPropertyChanged(nameof(Category));
            }
        }

        private string _ingredients;
        public string Ingredients
        {
            get { return _ingredients; }
            set
            {
                SetValue(ref _ingredients, value);
                OnPropertyChanged(nameof(Ingredients));
            }
        }

        private string _ageCategory;
        public string AgeCategory
        {
            get { return _ageCategory; }
            set
            {
                SetValue(ref _ageCategory, value);
                OnPropertyChanged(nameof(AgeCategory));
            }
        }

        private string _extraInfo;
        public string ExtraInfo
        {
            get { return _extraInfo; }
            set
            {
                SetValue(ref _extraInfo, value);
                OnPropertyChanged(nameof(ExtraInfo));
            }
        }
    }
}
