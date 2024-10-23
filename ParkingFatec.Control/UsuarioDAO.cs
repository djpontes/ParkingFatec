using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ParkingFatec.Model;

namespace ParkingFatec.Control
{
    public class UsuarioDAO
    {
        ConexaoDAO conn = new ConexaoDAO();
        Usuarios usuarios = new Usuarios();
        public void InserirUsuario(Usuarios usuarios)
        {
            string sql = "INSERT INTO usuarios (nome, email, senha, nivel_acesso) VALUES (@nome, @email, @senha, @nivelAcesso)";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
                    cmd.Parameters.AddWithValue("@email", usuarios.Email);
                    cmd.Parameters.AddWithValue("@senha", usuarios.Senha);
                    cmd.Parameters.AddWithValue("@nivelAcesso", usuarios.NivelAcesso);


                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message + "\n" + ex.InnerException?.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool AutenticarUsuario(Usuarios usuarios)
        {
            string sql = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@email", usuarios.Email);
                    cmd.Parameters.AddWithValue("@senha", usuarios.Senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar: " + ex.Message + "\n" + ex.InnerException?.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExisteUsuario()
        {
            string sql = "SELECT COUNT(*) FROM usuarios"; // Conta o número total de registros na tabela
            try
            {
                using (MySqlConnection conexao = conn.GetConnection()) 
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    int count = Convert.ToInt32(cmd.ExecuteScalar()); // Retorna o número de registros

                    return count > 0; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return false; 
            }
        }

        public void EditarUsuario(Usuarios usuarios)
        {

        }
    }
}

