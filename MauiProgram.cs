using LancarHoras.Models.LoginOnBase;
using LancarHoras.Pages.Usuario;
using LancarHoras.ViewModel;
using Microsoft.Extensions.Logging;
namespace LancarHoras;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<Usuario>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddScoped<Conexao>();
        builder.Services.AddScoped<ConexaoViewModel>();

        builder.Services.AddTransient<DetailsPage>();
        builder.Services.AddTransient<DetailsViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
