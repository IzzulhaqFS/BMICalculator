using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.ViewModels
{
    public partial class EmployeePageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _employeeName;

        [RelayCommand]
        public void Save()
        {

        }
    }
}
