namespace SmartSpendApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        // Do not set MainPage here (deprecated)
    }

    protected override Window CreateWindow(Microsoft.Maui.IActivationState? activationState)
    {
        // Create and return the Window with your root page
        return new Window(new NavigationPage(new ExpensesPage()));
    }
}