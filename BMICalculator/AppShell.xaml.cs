using BMICalculator.Views;

namespace BMICalculator;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(BMICalculatorPage), typeof(BMICalculatorPage));
        Routing.RegisterRoute(nameof(BMIListPage), typeof(BMIListPage));
    }
}
