using Microsoft.Extensions.Logging;
using ConsultarCepApp.Services;
using ConsultarCepApp.Views;
using ConsultarCepApp.ViewModels;

namespace ConsultarCepApp
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddHttpClient<ICepService, CepService>(client =>
            {
                client.BaseAddress = new Uri(" https://cep.awesomeapi.com.br");
            });

            builder.Services.AddHttpClient<ICnpjService, CnpjService>(client =>
            {
                client.BaseAddress = new Uri("https://api.opencnpj.org");
            });

            builder.Services.AddTransient<BuscarCepPage>();
            builder.Services.AddTransient<BuscarCepViewModel>();

            builder.Services.AddTransient<BuscarCnpjPage>();
            builder.Services.AddTransient<BuscarCnpjViewModel>();

            return builder.Build();
        }
    }
}
