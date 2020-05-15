﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
using GlowOn.ViewModels.Interfaces;
using GlowOn.Models;
using Xamarin.Forms;

namespace GlowOn.ViewModels.Pages
{
    public class FormViewModel : BaseViewModel
    {
        private readonly IUsers _user;
        private readonly IPageService _pageService;

        public User User { get; private set; }
        public ICommand SaveCommand { get; set; }

        //public IList<string> AgeCategories { get { return AgeCategoriesData.AgeCategories; } }

        public FormViewModel(UserViewModel viewModelU, IUsers user, IPageService pageService)
        {
            if(viewModelU == null)
                throw new ArgumentNullException(nameof(viewModelU));

            _pageService = pageService;
            _user = user;

            SaveCommand = new Command(async () => await SaveChanges());

            User = new User
            {
                ID = viewModelU.ID,
                SkinType = viewModelU.SkinType,
                AgeCategory = viewModelU.AgeCategory,
                IsSensitive = viewModelU.IsSensitive
            };
        }

        async Task SaveChanges()
        {
            if((User.SkinType == "Combination") || (User.SkinType == "Normal") || (User.SkinType == "Oily") || (User.SkinType == "Dry"))
            {
                await _user.DeleteUsersAsync();
                MessagingCenter.Send(this, Events.UsersDeleted);
                await _user.AddUser(User);
                MessagingCenter.Send(this, Events.UserAdded, User);
                await _pageService.PopAsync();
            }
            else
            {
                await _pageService.DisplayAlert("Error", "Please enter a valid skintype.", "OK");
                return;
            }
        }
    }
}
