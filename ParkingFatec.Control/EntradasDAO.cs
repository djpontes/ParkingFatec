using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ParkingFatec.Model;

namespace ParkingFatec.Control
{
    public class EntradasDAO
    {
        ConexaoDAO conn = new ConexaoDAO();
        Entradas entradas = new Entradas();

        public void inserirEntradas(Entradas entradas)
        {
            string sql = "INSERT INTO registros (data_entrada, horario_entrada, veiculos_id, usuarios_id) VALUES (@data_entrada, @horario_entrada, " +
                "@veiculos_id, @usuarios_id)";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@data_entrada", entradas.Data_entrada);
                    cmd.Parameters.AddWithValue("@horario_entrada", entradas.Horario_entrada);
                    cmd.Parameters.AddWithValue("@veiculos_id", entradas.Veiculos_id);
                    cmd.Parameters.AddWithValue("@usuarios_id", entradas.Usuarios_id);


                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message + "\n" + ex.InnerException?.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool verificarEntradaAtiva(string placa)
        {
            string sql = "SELECT COUNT(*) FROM registros r " +
                         "JOIN veiculos v ON r.veiculos_id = v.id " +
                         "WHERE v.placa = @placa AND r.data_saida IS NULL";

            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@placa", placa);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Retorna true se há uma entrada ativa
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar entrada ativa: " + ex.Message + "\n" + ex.InnerException?.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



    }
}
