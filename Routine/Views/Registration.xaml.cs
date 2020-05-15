using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Routine.ViewModels;
using Routine.ViewModels.Pages;
using Routine.Persistence;

namespace Routine.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration(UserViewModel viewModel)
        {
            InitializeComponent();
            var userDB = new SQLiteUserDB(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            BindingContext = new SignUpViewModel(viewModel ?? new UserViewModel(), userDB, pageService);
        }
    }
}