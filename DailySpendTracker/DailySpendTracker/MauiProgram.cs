using DailySpendTracker.Services;

namespace DailySpendTracker;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>();

        builder.Services.AddSingleton<DatabaseService>();
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}