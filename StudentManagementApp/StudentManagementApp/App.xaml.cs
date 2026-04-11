using Microsoft.Maui.Controls;

namespace StudentManagementApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new LoginPage());
    }
}