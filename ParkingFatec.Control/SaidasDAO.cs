using MySql.Data.MySqlClient;
using ParkingFatec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFatec.Control
{
    public class SaidasDAO
    {
        ConexaoDAO conn = new ConexaoDAO();
        Saidas saidas = new Saidas();

        public SaidasDAO()
        {

        }

        public void inserirSaidas(Saidas saidas)
        {
            string sql = "UPDATE registros " +
                         "SET data_saida = @data_saida, horario_saida = @horario_saida " +
                         "WHERE veiculos_id = @veiculos_id AND data_saida IS NULL";

            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@data_saida", saidas.Data_saida);
                    cmd.Parameters.AddWithValue("@horario_saida", saidas.Horario_saida);
                    cmd.Parameters.AddWithValue("@veiculos_id", saidas.Veiculos_id);

                    int rowsAffected = cmd.ExecuteNonQuery(); // Executa o comando e retorna o número de linhas afetadas

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Saída registrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado para atualizar. Verifique se o veículo está registrado e se ainda não possui data de saída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar saída: " + ex.Message +
                                "\nDetalhes: " + ex.InnerException?.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

