using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Input;
using GlowOn.Models;
using GlowOn.ViewModels;
using GlowOn.ViewModels.Interfaces;
using Xamarin.Forms;

namespace GlowOn.ViewModels.Pages
{
    class SensitivityViewModel :BaseViewModel
    {

        public IList<Option> Q1Options { get { return SensitivityOptionsData.Q1Options; } }
        public IList<Option> Q2Options { get { return SensitivityOptionsData.Q2Options; } }
        public IList<Option> Q3Options { get { return SensitivityOptionsData.Q3Options; } }
        public IList<Option> Q4Options { get { return SensitivityOptionsData.Q4Options; } }
        public IList<Option> Q5Options { get { return SensitivityOptionsData.Q5Options; } }

        public IList<Option> SelectedOptions = new List<Option>();

        public ICommand ResultsCommand { get; set; }

        private readonly IPageService _pageService;

        Option selectedQ1;
        Option selectedQ2;
        Option selectedQ3;
        Option selectedQ4;
        Option selectedQ5;

        public SensitivityViewModel(IPageService pageService)
        {
            _pageService = pageService;

            ResultsCommand = new Command(async () => await DisplayResult());
        }

        async Task DisplayResult()
        {
            SelectedOptions.Add(SelectedQ1);
            SelectedOptions.Add(SelectedQ2);
            SelectedOptions.Add(SelectedQ3);
            SelectedOptions.Add(SelectedQ4);
            SelectedOptions.Add(SelectedQ5);

            int counterA = 0;
            int counterB = 0;
            int counterC = 0;

            foreach (Option sOption in SelectedOptions)
            {
                if (sOption.letter == "A")
                    counterA = counterA + 1;
                else if (sOption.letter == "B")
                    counterB = counterB + 1;
                else if (sOption.letter == "C")
                    counterC = counterC + 1;
            }

            if (counterA > counterB && counterA > counterC)
            {
                await _pageService.DisplayAlert("Be extra careful", "Your skin is sensitive as a flower", "Thank you");
                SelectedOptions.Clear();
                return;
            }
            else if (counterB > counterA && counterB > counterC)
            {
                await _pageService.DisplayAlert("So lucky", "Your skin is far from sensitive", "Thank you");
                SelectedOptions.Clear();
                return;
            }
            else if (counterC > counterA && counterC > counterB)
            {
                await _pageService.DisplayAlert("Pay attention to any change", "Your skin is only sensitive at times", "Thank you");
                SelectedOptions.Clear();
                return;
            }
            else
            {
                {
                    await _pageService.DisplayAlert("Pay attention to any change", "Your skin is only sensitive at times", "Sorry!");
                    SelectedOptions.Clear();
                    return;
                }
            }
        }

        public Option SelectedQ1
        {
            get { return selectedQ1; }
            set
            {
                if (selectedQ1 != value)
                {
                    selectedQ1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public Option SelectedQ2
        {
            get { return selectedQ2; }
            set
            {
                if (selectedQ2 != value)
                {
                    selectedQ2 = value;
                    OnPropertyChanged();
                }
            }
        }

        public Option SelectedQ3
        {
            get { return selectedQ3; }
            set
            {
                if (selectedQ3 != value)
                {
                    selectedQ3 = value;
                    OnPropertyChanged();
                }
            }
        }

        public Option SelectedQ4
        {
            get { return selectedQ4; }
            set
            {
                if (selectedQ4 != value)
                {
                    selectedQ4 = value;
                    OnPropertyChanged();
                }
            }
        }

        public Option SelectedQ5
        {
            get { return selectedQ5; }
            set
            {
                if (selectedQ5 != value)
                {
                    selectedQ5 = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
