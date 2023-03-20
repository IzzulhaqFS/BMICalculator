using BMICalculator.ViewModels;

namespace BMICalculator.View;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
		this.BindingContext = new EmployeePageViewModel();
	}
}