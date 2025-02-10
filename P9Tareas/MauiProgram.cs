using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace P9Tareas
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).ConfigureEssentials(essentials =>
                {
                    essentials.UseMapServiceToken("pk.eyJ1IjoiYW50b25pbzc1NjQ1IiwiYSI6ImNtNXNqaGV6MDBoaHoya3F1dTIwZmVjZHUifQ.VKQ6UbOXCQIflEUm08bHng");
                })
                ;
        

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
