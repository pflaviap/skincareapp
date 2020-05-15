using System;
using System.Collections.Generic;
using System.Text;

namespace GlowOn.Models
{
    public static class SensitivityOptionsData
    {
        public static IList<Option> Q1Options { get; private set; }
        public static IList<Option> Q2Options { get; private set; }
        public static IList<Option> Q3Options { get; private set; }
        public static IList<Option> Q4Options { get; private set; }
        public static IList<Option> Q5Options { get; private set; }
        static SensitivityOptionsData()
        {
            Q1Options = new List<Option>();
            Q2Options = new List<Option>();
            Q3Options = new List<Option>();
            Q4Options = new List<Option>();
            Q5Options = new List<Option>();

            Q1Options.Add(new Option
            {
                letter = "A",
                Description = "Yes"
            });
            Q1Options.Add(new Option
            {
                letter = "B",
                Description = "No"
            });
            Q1Options.Add(new Option
            {
                letter = "C",
                Description = "Sometimes"
            });
            Q2Options.Add(new Option
            {
                letter = "A",
                Description = "Yes"
            });
            Q2Options.Add(new Option
            {
                letter = "B",
                Description = "No"
            });
            Q2Options.Add(new Option
            {
                letter = "C",
                Description = "Sometimes"
            });
            Q3Options.Add(new Option
            {
                letter = "A",
                Description = "Yes"
            });
            Q3Options.Add(new Option
            {
                letter = "B",
                Description = "No"
            });
            Q3Options.Add(new Option
            {
                letter = "C",
                Description = "Sometimes"
            });
            Q4Options.Add(new Option
            {
                letter = "A",
                Description = "Yes"
            });
            Q4Options.Add(new Option
            {
                letter = "B",
                Description = "No"
            });
            Q4Options.Add(new Option
            {
                letter = "C",
                Description = "Sometimes"
            });
            Q5Options.Add(new Option
            {
                letter = "A",
                Description = "Yes"
            });
            Q5Options.Add(new Option
            {
                letter = "B",
                Description = "No"
            });
            Q5Options.Add(new Option
            {
                letter = "C",
                Description = "Sometimes"
            });
        }

    }
}
