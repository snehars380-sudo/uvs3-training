using StudentPopupApp.Views;

namespace StudentPopupApp;

public partial class App : Application
{
    public App(MainPage page)
    {
        InitializeComponent();
        MainPage = page;
    }
}