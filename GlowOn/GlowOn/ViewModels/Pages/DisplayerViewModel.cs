using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using GlowOn.Views;
using GlowOn.Models;
using GlowOn.ViewModels.Interfaces;
using Xamarin.Forms;
using System.Collections.Generic;

namespace GlowOn.ViewModels.Pages
{
    public class DisplayerViewModel : BaseViewModel
    {
        private IUsers _user;
        private IProductCatalogue _productCatalogue;
        private IPageService _pageService;
        public ObservableCollection<UserViewModel> Users { get; private set; }
            = new ObservableCollection<UserViewModel>();

        public ObservableCollection<ProductViewModel> MakeupRemovers { get; private set; }
            = new ObservableCollection<ProductViewModel>();

        public ObservableCollection<ProductViewModel> Cleansers { get; private set; }
            = new ObservableCollection<ProductViewModel>();

        public ObservableCollection<ProductViewModel> Moisturizers { get; private set; }
            = new ObservableCollection<ProductViewModel>();

        public ObservableCollection<ProductViewModel> SPFs { get; private set; }
            = new ObservableCollection<ProductViewModel>();
        public IList<Product> ProductsL { get { return ProductData.Products; } }

        public ICommand LoadDataCommand { get; private set; }
        public ICommand SubmitFormCommand { get; private set; }

        public DisplayerViewModel(IUsers user, IProductCatalogue productCatalogue, IPageService pageService, string Category)
        {
            _user = user;
            _productCatalogue = productCatalogue;
            _pageService = pageService;

            LoadDataCommand = new Command(async () => await LoadData(Category));
            SubmitFormCommand = new Command(async () => await SubmitForm());

            foreach (Product p in ProductsL)
            {
                _productCatalogue.AddOrReplace(p);
            }

            MessagingCenter.Subscribe<FormViewModel>
                (this, Events.UsersDeleted, OnUsersDeleted);

            MessagingCenter.Subscribe<FormViewModel, User>
                (this, Events.UserAdded, OnUserAdded);
        }

        private void OnUsersDeleted(FormViewModel source)
        {
            Users.Clear();
            MakeupRemovers.Clear();
            Cleansers.Clear();
            Moisturizers.Clear();
            SPFs.Clear();
        }
        private void OnUserAdded(FormViewModel source, User user)
        {
            Users.Add(new UserViewModel(user));
        }

        private async Task LoadData(string Category)
        {
            var products = await _productCatalogue.GetProductsAsync();
            var users = await _user.GetUsersAsync();

            foreach (var user in users)
            {
                Users.Add(new UserViewModel(user));
                foreach (var product in products)
                {
                    if (product.SkinType == user.SkinType && product.Category == Category && product.ForSensitive == user.IsSensitive && (product.AgeCategory == user.AgeCategory || product.AgeCategory == "Universal"))
                    {
                        if (Category == "Makeup Remover")
                            MakeupRemovers.Add(new ProductViewModel(product));
                        else if (Category == "Cleanser")
                            Cleansers.Add(new ProductViewModel(product));
                        else if (Category == "Moisturizer")
                            Moisturizers.Add(new ProductViewModel(product));
                        else SPFs.Add(new ProductViewModel(product));
                    }
                }
            }

        }

        private async Task SubmitForm()
        {
            await _pageService.PushAsync(new FormPage(new UserViewModel()));
        }
    }
}
