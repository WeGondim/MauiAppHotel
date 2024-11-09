using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                    fonts.AddFont("Mogra-Regular.ttf", "Mogra");
                    fonts.AddFont("varelaround_regular.ttf", "varelaround");
                    fonts.AddFont("SpaceGrotesk-VariableFont.ttf", "SpaceGrotesk");
                    fonts.AddFont("PlaywriteGBS-Italic-VariableFont_wght.ttf", "Playwrt_italic");
                    fonts.AddFont("PlaywriteGBS-VariableFont_wght.ttf", "Playwrt");
                });
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
