using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using Routine.ViewModels.Interfaces;
using Routine.Models;
using Xamarin.Forms;

namespace Routine.ViewModels.Pages
{
    public class SignUpViewModel : BaseViewModel
    {
        private readonly IUserDB _userDB;
        private readonly IPageService _pageService;
        public User User { get; private set; }
        public ICommand RegistrationCommand { get; set; }
        public SignUpViewModel(UserViewModel viewModel, IUserDB userDB, IPageService pageService)
        {
            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            _pageService = pageService;
            _userDB = userDB;

            RegistrationCommand = new Command(async () => await Register());

            User = new User
            {
                ID = viewModel.id,
                Name = viewModel.Name,
                Username = viewModel.Username,
                Email = viewModel.Email,
                Password = viewModel.Password
            };
        }

        async Task Register()
        {
            if (String.IsNullOrWhiteSpace(User.Username) || String.IsNullOrWhiteSpace(User.Name) || String.IsNullOrWhiteSpace(User.Email) || String.IsNullOrWhiteSpace(User.Password))
            {
                await _pageService.DisplayAlert("Error", "All fields are mandatory.", "OK");
                return;
            }
            else
            {
                await _userDB.AddUser(User);
                MessagingCenter.Send(this, Events.UserAdded, User);
            }
            await _pageService.PopAsync();
        }
    }
}
