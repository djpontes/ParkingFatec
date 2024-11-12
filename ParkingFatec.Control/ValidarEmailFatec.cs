namespace ParkingFatec.Control
{
    public static class ValidarEmailFatec
    {
        public static bool validarEmailFatec(string email)
        {
            try
            {
                // Verifica o formato geral do email
                var enderecoEmail = new System.Net.Mail.MailAddress(email);

                // Adiciona verificação extra para garantir que o domínio seja '@fatec'
                return enderecoEmail.Address == email && email.EndsWith("@fatec.sp.gov.br");
            }
            catch
            {
                return false;
            }
        }
    }
}
