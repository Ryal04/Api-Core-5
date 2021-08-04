using System;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace api.Services
{
    public class CloudMailService : IMailService
    {
        private IConfiguration _cofiguracion;
        public CloudMailService(IConfiguration configuracion)
        {
            _cofiguracion = configuracion ?? throw new ArgumentNullException(nameof(configuracion));
        }

        public void Send(string subject, string message){
             Debug.WriteLine($"Mail enviado de {_cofiguracion["mailSetting:_emailFrom"]} a {_cofiguracion["mailSetting:_emailTo"]} service Cloud");
             Debug.WriteLine($"Asunto: {subject}");
             Debug.WriteLine($"Mensaje: {message}");
        }
    }
}