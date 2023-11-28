
using FoodDeliveryApp.MVVM.View;
using FoodDevApp.MVVM;
using FoodDevApp.MVVM.Data;
using FoodDevApp.MVVM.ViewModel;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace FoodDevApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .ConfigureSyncfusionCore()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Services.AddSingleton<LocalDBService>();
            builder.Services.TryAddTransient<LogInPage>();

		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<DataBaseContext>();
            builder.Services.AddSingleton<ProductsViewModel>();
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}