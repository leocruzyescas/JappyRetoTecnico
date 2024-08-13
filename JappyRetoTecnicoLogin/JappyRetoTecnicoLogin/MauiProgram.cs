using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using JappyRetoTecnicoLogin.Data;
using JappyRetoTecnicoLogin.Services;

namespace JappyRetoTecnicoLogin;

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

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer("Server=DESKTOP-2Q8LN3R; Database=JappyForm; TrustServerCertificate=True; Trusted_Connection=True; MultipleActiveResultSets=true");
        });
        builder.Services.AddHttpClient();
        builder.Services.AddSingleton<ICaptchaService, CaptchaServiceImplementation>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
