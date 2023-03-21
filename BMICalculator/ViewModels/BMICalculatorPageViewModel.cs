﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.ViewModels
{
    [QueryProperty(nameof(Name), "name")]
    public partial class BMICalculatorPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _name;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BMIScore))]
        [NotifyPropertyChangedFor(nameof(BMIResult))]
        public double _height;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BMIScore))]
        [NotifyPropertyChangedFor(nameof(BMIResult))]
        public double _weight;

        public double BMIScore
            => Math.Round(Weight/Math.Pow(Height/100, 2), 2);

        public string BMIResult
        {
            get
            {
                if (BMIScore < 18.5)
                    return "Underweight";
                else if (BMIScore < 25)
                    return "Healthy";
                else if (BMIScore < 30)
                    return "Overweight";
                else
                    return "Obese";
            }
        }
    }
}
