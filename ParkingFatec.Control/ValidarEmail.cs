using System;
using System.Linq;

namespace ParkingFatec.Control
{
    public static class ValidarEmail
    {
        private static readonly string[] DominiosPermitidos =
        {
            "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com", "@fatec.sp.gov.br"
        };

        public static bool validarEmail(string email)
        {
            try
            {
                // ve o formato do email
                var enderecoEmail = new System.Net.Mail.MailAddress(email);

                // ve se o dominio termina com algum dos permitidos
                return enderecoEmail.Address == email &&
                       DominiosPermitidos.Any(dominio => email.EndsWith(dominio, StringComparison.OrdinalIgnoreCase));
            }
            catch
            {
                return false;
            }
        }
    }
}
