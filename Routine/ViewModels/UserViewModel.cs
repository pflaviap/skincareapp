using System;
using System.Collections.Generic;
using System.Text;
using Routine.Models;

namespace Routine.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public int id { get; set; }
        public UserViewModel() { }
        public UserViewModel(User user)
        {
            id = user.ID;
            _name = user.Name;
            _username = user.Username;
            _email = user.Email;
            _password = user.Password;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                SetValue(ref _name, value);
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                SetValue(ref _username, value);
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                SetValue(ref _email, value);
                OnPropertyChanged(nameof(Email));
            }
        }


        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                SetValue(ref _password, value);
                OnPropertyChanged(nameof(Password));
            }
        }
    }
}
