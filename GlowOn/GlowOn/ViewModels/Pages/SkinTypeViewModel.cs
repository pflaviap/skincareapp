using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GlowOn.Models;
using GlowOn.ViewModels.Interfaces;
using Xamarin.Forms;

namespace GlowOn.ViewModels.Pages
{
    class SkinTypeViewModel : BaseViewModel
    {
        public IList<Option> Q1Options { get { return SkintypeOptionData.Q1Options; } }
        public IList<Option> Q2Options { get { return SkintypeOptionData.Q2Options; } }
        public IList<Option> Q3Options { get { return SkintypeOptionData.Q3Options; } }
        public IList<Option> Q4Options { get { return SkintypeOptionData.Q4Options; } }
        public IList<Option> Q5Options { get { return SkintypeOptionData.Q5Options; } }
        public IList<Option> Q6Options { get { return SkintypeOptionData.Q6Options; } }

        public IList<Option> SelectedOptions = new List<Option>();

        public ICommand ResultsCommand { get; set; }

        private readonly IPageService _pageService;

        Option selectedQ1;
        Option selectedQ2;
        Option selectedQ3;
        Option selectedQ4;
        Option selectedQ5;
        Option selectedQ6;

        public SkinTypeViewModel(IPageService pageService)
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
            SelectedOptions.Add(SelectedQ6);

            int counterA = 0;
            int counterB = 0;
            int counterC = 0;
            int counterD = 0;

            foreach (Option sOption in SelectedOptions)
            {
                if (sOption.letter == "A")
                    counterA = counterA + 1;
                else if (sOption.letter == "B")
                    counterB = counterB + 1;
                else if (sOption.letter == "C")
                    counterC = counterC + 1;
                else if (sOption.letter == "D")
                    counterD = counterD + 1;
            }

            if (counterA > counterB && counterA > counterC && counterA > counterD)
            {
                await _pageService.DisplayAlert("So rare!", "Your skin is definitely normal", "Thank you");
                SelectedOptions.Clear();
                return;
            }
            else if (counterB > counterA && counterB > counterC && counterB > counterD)
            {
                await _pageService.DisplayAlert("Hydration is key", "Your skin is definitely dry", "Thank you");
                SelectedOptions.Clear();
                return;
            }
            else if (counterC > counterA && counterC > counterB && counterC > counterD)
            {
                await _pageService.DisplayAlert("Greasy but cute", "Your skin is definitely oily", "Thank you");
                SelectedOptions.Clear();
                return;
            }
            else if (counterD > counterA && counterD > counterB && counterD > counterC)
            {
                await _pageService.DisplayAlert("The best of both worlds", "Your skin is definitely combination", "Thank you");
                SelectedOptions.Clear();
                return;
            }
            else
            {
                {
                    await _pageService.DisplayAlert("Oops", "We can't really figure it out. Please thing better and try again:)", "Sorry!");
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

        public Option SelectedQ6
        {
            get { return selectedQ6; }
            set
            {
                if (selectedQ6 != value)
                {
                    selectedQ6 = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
