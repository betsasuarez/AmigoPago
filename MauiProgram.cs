using AmigoPago.Services;
using AmigoPago.Services.Interfaces;
using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AmigoPago
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif      
            builder.Services.AddSingleton<Views.LoginPage1>();
            builder.Services.AddSingleton<ViewModels.LoginPageViewModel>();

            builder.Services.AddSingleton<ILoginService, LoginService>();
            
            return builder.Build();
        }
    }
}
