using Microsoft.Extensions.Logging;

namespace AppHotel
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
                    // OpenSans
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    // Lexend
                    fonts.AddFont("Lexend-Regular.ttf", "Lexend-Regular");
                    fonts.AddFont("Lexend-SemiBold.ttf", "Lexend-SemiBold");
                    fonts.AddFont("Lexend-Bold.ttf", "Lexend-Bold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
