using System;
using System.Collections.Generic;
using System.Text;
using GlowOn.Models;

namespace GlowOn.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public int ID { get; set; }
        public UserViewModel() { }

        public UserViewModel(User user)
        {
            ID = user.ID;
            _skinType = user.SkinType;
            _isSensitive = user.IsSensitive;
            _ageCategory = user.AgeCategory;
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

        private bool _isSensitive;
        public bool IsSensitive
        {
            get { return _isSensitive; }
            set
            {
                SetValue(ref _isSensitive, value);
                OnPropertyChanged(nameof(IsSensitive));
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
    }
}
