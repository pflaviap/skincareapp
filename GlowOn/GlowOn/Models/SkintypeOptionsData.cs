using System;
using System.Collections.Generic;
using System.Text;

namespace GlowOn.Models
{
    public static class SkintypeOptionData
    {
        public static IList<Option> Q1Options { get; private set; }
        public static IList<Option> Q2Options { get; private set; }
        public static IList<Option> Q3Options { get; private set; }
        public static IList<Option> Q4Options { get; private set; }
        public static IList<Option> Q5Options { get; private set; }
        public static IList<Option> Q6Options { get; private set; }

        static SkintypeOptionData()
        {
            Q1Options = new List<Option>();
            Q2Options = new List<Option>();
            Q3Options = new List<Option>();
            Q4Options = new List<Option>();
            Q5Options = new List<Option>();
            Q6Options = new List<Option>();

            Q1Options.Add(new Option
            {
                letter = "A",
                Description = "Smooth and refreshed"
            });
            Q1Options.Add(new Option
            {
                letter = "B",
                Description = "Dry and dull"
            });
            Q1Options.Add(new Option
            {
                letter = "C",
                Description = "Greasy and oily"
            });
            Q1Options.Add(new Option
            {
                letter = "D",
                Description = "Shiny on the none and T-zone"
            });

            Q2Options.Add(new Option
            {
                letter = "A",
                Description = "The same as when I put it on"
            });
            Q2Options.Add(new Option
            {
                letter = "B",
                Description = "Patchy, flakey, matte"
            });
            Q2Options.Add(new Option
            {
                letter = "C",
                Description = "Scattered, uneven, shiny"
            });
            Q2Options.Add(new Option
            {
                letter = "D",
                Description = "A bit uneven and dispersed on the nose and T - zone"
            });

            Q3Options.Add(new Option
            {
                letter = "A",
                Description = "Medium to small sized all over"
            });
            Q3Options.Add(new Option
            {
                letter = "B",
                Description = "Small, but tight and dry"
            });
            Q3Options.Add(new Option
            {
                letter = "C",
                Description = "Textured, visible, huge"
            });
            Q3Options.Add(new Option
            {
                letter = "D",
                Description = "Medium to large sized, especially on the nose and T-zone"
            });

            Q4Options.Add(new Option
            {
                letter = "A",
                Description = "Twice a day is more than enough"
            });
            Q4Options.Add(new Option
            {
                letter = "B",
                Description = "Every hour if I could"
            });
            Q4Options.Add(new Option
            {
                letter = "C",
                Description = "Sometimes I avoid it completely"
            });
            Q4Options.Add(new Option
            {
                letter = "D",
                Description = "Twice a day but using something very light"
            });

            Q5Options.Add(new Option
            {
                letter = "A",
                Description = "Pretty much nothing"
            });
            Q5Options.Add(new Option
            {
                letter = "B",
                Description = "Dryness, hydration, flakes everywhere"
            });
            Q5Options.Add(new Option
            {
                letter = "C",
                Description = "Acne, oil control, pores"
            });
            Q5Options.Add(new Option
            {
                letter = "D",
                Description = "Pimples popping sometimes, shiny forehead and nose"
            });

            Q6Options.Add(new Option
            {
                letter = "A",
                Description = "From time to time. Like, once a month at most"
            });
            Q6Options.Add(new Option
            {
                letter = "B",
                Description = "Rarely, I sometimes forget how they look"
            });
            Q6Options.Add(new Option
            {
                letter = "C",
                Description = "They basically never leave my face"
            });
            Q6Options.Add(new Option
            {
                letter = "D",
                Description = "Best case scenario: twice a month"
            });
        }
    }
}
