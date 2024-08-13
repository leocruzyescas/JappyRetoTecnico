using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JappyRetoTecnicoLogin.Services
{
    public interface ICaptchaService
    {
        Task<bool> ValidateCaptchaAsync(string captchaResponse);
    }
}
