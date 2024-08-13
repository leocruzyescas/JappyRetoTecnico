using JappyRetoTecnicoLogin.Pages;
using JappyRetoTecnicoLogin.Data;
using JappyRetoTecnicoLogin.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace JappyRetoTecnicoLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

     
            var serviceProvider = MauiProgram.CreateMauiApp().Services;
            var context = serviceProvider.GetService<ApplicationDbContext>();
            var captchaService = serviceProvider.GetService<ICaptchaService>();

            MainPage = new LoginPage(context, captchaService);
        }
    }
}
