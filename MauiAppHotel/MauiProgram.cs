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
                    fonts.AddFont("ComicNeue-Bold.ttf", "ComicNeueBold");
                    fonts.AddFont("ComicNeue-BoldItalic.ttf", "ComicNeueBoldItalic");
                    fonts.AddFont("ComicNeue-Italic.ttf", "ComicNeueItalic");
                    fonts.AddFont("ComicNeue-Light.ttf", "ComicNeueLight");
                    fonts.AddFont("ComicNeue-Light.ttf", "ComicNeueLight");
                    fonts.AddFont("ComicNeue-Light.ttf", "ComicNeueLight");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
