using System;
using System.Collections.Generic;
using System.Text;
using Routine.Models;

namespace Routine.ViewModels
{
    public class RoutineTViewModel : BaseViewModel
    {
        public int ID { get; set; }
        public RoutineTViewModel() { }
        public RoutineTViewModel(RoutineT routineT)
        {
            ID = routineT.ID;
            _makeupRemover = routineT.MakeupRemover;
            _makeupRemoverBrand = routineT.MakeupRemoverBrand;
            _cleanser = routineT.Cleanser;
            _cleanserBrand = routineT.CleanserBrand;
            _hydratingCream = routineT.HydratingCream;
            _hydratingCreamBrand = routineT.HydratingCreamBrand;
        }

        private string _makeupRemover;
        public string MakeupRemover
        {
            get { return _makeupRemover; }
            set
            {
                SetValue(ref _makeupRemover, value);
                OnPropertyChanged(nameof(MakeupRemover));
            }
        }

        private string _makeupRemoverBrand;
        public string MakeupRemoverBrand
        {
            get { return _makeupRemoverBrand; }
            set
            {
                SetValue(ref _makeupRemoverBrand, value);
                OnPropertyChanged(nameof(MakeupRemoverBrand));
            }
        }

        private string _cleanser;
        public string Cleanser
        {
            get { return _cleanser; }
            set
            {
                SetValue(ref _cleanser, value);
                OnPropertyChanged(nameof(Cleanser));
            }
        }

        private string _cleanserBrand;
        public string CleanserBrand
        {
            get { return _cleanserBrand; }
            set
            {
                SetValue(ref _cleanserBrand, value);
                OnPropertyChanged(nameof(CleanserBrand));
            }
        }

        private string _hydratingCream;
        public string HydratingCream
        {
            get { return _hydratingCream; }
            set
            {
                SetValue(ref _hydratingCream, value);
                OnPropertyChanged(nameof(HydratingCream));
            }
        }

        private string _hydratingCreamBrand;
        public string HydratingCreamBrand
        {
            get { return _hydratingCreamBrand; }
            set
            {
                SetValue(ref _hydratingCreamBrand, value);
                OnPropertyChanged(nameof(HydratingCreamBrand));
            }
        }
    }
}
