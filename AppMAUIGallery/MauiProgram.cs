using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AppMAUIGallery
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Foldit-Light.ttf", "FolditLight");
                    fonts.AddFont("Foldit-Regular.ttf", "FolditRegular");
                    fonts.AddFont("Foldit-ExtraBold.ttf", "FolditBold");
                    fonts.AddFont("Fontello-Icons.ttf", "FontelloIcons");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
