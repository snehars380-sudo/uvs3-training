using StudentPopupApp.Services;
using StudentPopupApp.ViewModels;
using StudentPopupApp.Views;

//using Microsoft.Extensions.Logging;
using StudentPopupApp.Services;
using StudentPopupApp.ViewModels;
using StudentPopupApp.Views;

namespace StudentPopupApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>();

        // Services
        builder.Services.AddSingleton<IStudentService, StudentMockService>();

        // ViewModel
        builder.Services.AddTransient<MainViewModel>();

        // Page
        builder.Services.AddTransient<MainPage>();

        return builder.Build();
    }
}