using BMICalculator.Views;
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
        async Task Save()
        {
            if (string.IsNullOrEmpty(EmployeeName))
                return;

            await Shell.Current.GoToAsync($"{nameof(BMICalculatorPage)}?name={EmployeeName}");
        }

        [RelayCommand]
        async Task ToBMIList()
        {
            await Shell.Current.GoToAsync(nameof(BMIListPage));
        }
    }
}
