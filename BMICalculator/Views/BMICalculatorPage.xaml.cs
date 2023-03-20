using BMICalculator.ViewModels;

namespace BMICalculator.Views;

public partial class BMICalculatorPage : ContentPage
{
	public BMICalculatorPage()
	{
		InitializeComponent();
		this.BindingContext = new BMICalculatorPageViewModel();
	}
}