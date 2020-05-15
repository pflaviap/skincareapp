using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Routine.Models;
using Routine.ViewModels.Interfaces;
using Xamarin.Forms;

namespace Routine.ViewModels.Pages
{
    public class RoutineFormPageViewModel
    {
        private readonly IRoutineCreator _routineCreator;
        private readonly IProductCatalogue _productCatalogue;
        private readonly IPageService _pageService;
        public RoutineT RoutineT { get; private set; }
        public ICommand GetRoutine { get; set; }
        public RoutineFormPageViewModel(RoutineTViewModel viewModel, IRoutineCreator routineCreator, IProductCatalogue productCatalogue, IPageService pageService)
        {
            if(viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            _pageService = pageService;
            _routineCreator = routineCreator;
            _productCatalogue = productCatalogue;

            Random random = new Random();
            RoutineT = new RoutineT
            {
                ID = viewModel.ID,
            };
        }

    }
}
