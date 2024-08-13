using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JappyRetoTecnicoLogin.Services
{
    public class CaptchaServiceImplementation : ICaptchaService
    {
        private readonly HttpClient _httpClient;

        public CaptchaServiceImplementation(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> ValidateCaptchaAsync(string captchaResponse)
        {

            var secretKey = "6LetmyUqAAAAAI6gedJ4vbL42W_j5s3VJuY7An08";
            var requestUri = $"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={captchaResponse}";

            var response = await _httpClient.GetStringAsync(requestUri);

            return response.Contains("\"success\": true");
        }
    }
}
