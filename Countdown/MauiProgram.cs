using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Countdown.Pages;
using Countdown.ViewModels;
using Microsoft.Extensions.Logging;

namespace Countdown;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<App>();
        builder.Services.AddSingleton<AppShell>();

        builder.Services.AddTransientWithShellRoute<MainPage, MainViewModel>($"//{nameof(MainPage)}");
#if DEBUG
        builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}
