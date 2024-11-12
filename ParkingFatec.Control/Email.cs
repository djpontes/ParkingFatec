using System;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParkingFatec.Control
{
    public class Email
    {
        ConexaoDAO conn = new ConexaoDAO();

        public void enviarNovaSenha(string email, Form EsqueceuSenhaForm)
        { 
            if (!emailExiste(email))
            {
                MessageBox.Show("E-mail não encontrado. Por favor, verifique se você digitou corretamente.");
                return;
            }

            string novaSenha = gerarSenhaAleatoria(8); 

            bool senhaAtualizada = atualizarSenha(email, novaSenha);

            if (senhaAtualizada)
            {
                enviarEmail(email, novaSenha);
                MessageBox.Show("A nova senha foi enviada para o seu e-mail, não se esqueça de chegar seu spam e lixeira.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EsqueceuSenhaForm.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a senha no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool emailExiste(string email)
        {
            using (MySqlConnection conexao = conn.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM usuarios WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private string gerarSenhaAleatoria(int tamanho)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder senha = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                senha.Append(caracteres[random.Next(caracteres.Length)]);
            }

            return senha.ToString();
        }

        private bool atualizarSenha(string email, string novaSenha)
        {
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    string sql = "UPDATE usuarios SET senha = @Senha WHERE email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Senha", novaSenha);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        private void enviarEmail(string email, string novaSenha)
        {
            MailMessage mail = new MailMessage("parkingfatec@gmail.com", email)
            {
                Subject = "Nova Senha",
                Body = $"Olá, sua nova senha é: {novaSenha}. Por favor, não se esqueça de alterar depois",
                IsBodyHtml = false,
            };

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("parkingfatec", "twen hgci qsce xadu"), 
                EnableSsl = true, //mais seguro o envio de e-mail
            };

            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }
    }
}
