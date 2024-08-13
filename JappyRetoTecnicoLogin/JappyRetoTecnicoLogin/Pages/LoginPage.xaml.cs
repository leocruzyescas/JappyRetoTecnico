
using JappyRetoTecnicoLogin.Models;
using JappyRetoTecnicoLogin.Services;
using JappyRetoTecnicoLogin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JappyRetoTecnicoLogin.Pages;

public partial class LoginPage : ContentPage
{
	private readonly ApplicationDbContext _context;
    private readonly ICaptchaService _captchaService;
    private readonly string _recaptchaSiteKey = "6LetmyUqAAAAAF7ypJTeNGRr6ySOmodYr3Dc5EM5";

    public LoginPage(ApplicationDbContext context, ICaptchaService captchaService)
    {
        InitializeComponent();
        _context = context;
        _captchaService = captchaService;
        BindingContext = new LoginModel();
        LoadCaptcha();
    }
    private void LoadCaptcha()
    {
        var recaptchaHtml = $@"
            <html>
                <head>
                    <script src='https://www.google.com/recaptcha/api.js' async defer></script>
                </head>
                <body>
                    <div class='g-recaptcha' data-sitekey='{_recaptchaSiteKey}'></div>
                </body>
            </html>";

        captchaWebView.Source = new HtmlWebViewSource { Html = recaptchaHtml };
    }
    private async void btnIngresar_Clicked(object sender, EventArgs e)
	{
     
        var captchaResponse = "";
        var isCaptchaValid = await _captchaService.ValidateCaptchaAsync(captchaResponse);


        if (!isCaptchaValid)
        {
            await DisplayAlert("Error", "Captcha verification failed", "OK");
            return;
        }

    }
    private Task<bool> ValidateCaptcha()
    {

        return Task.FromResult(true); 
    }
}