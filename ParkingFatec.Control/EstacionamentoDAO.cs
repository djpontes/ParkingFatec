using ParkingFatec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ParkingFatec.Control
{
    public class EstacionamentoDAO
    {
        ConexaoDAO conn = new ConexaoDAO();
        Estacionamento estacionamento = new Estacionamento();

        public void inserirEstacionamento(Estacionamento estacionamento)
        {
            string sql = "INSERT INTO estacionamento (qntd_vagas_moto, qntd_vagas_carro) VALUES (@vagaMoto, @vagaCarro)";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@vagaMoto", estacionamento.VagaMoto);
                    cmd.Parameters.AddWithValue("@vagaCarro", estacionamento.VagaCarro);
                    

                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message + "\n" + ex.InnerException?.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void alterarEstacionamento(Estacionamento estacionamento)
        {
            string sql = "UPDATE estacionamento SET qntd_vagas_moto = @vagaMoto, qntd_vagas_carro = @vagaCarro WHERE id = (SELECT id FROM estacionamento LIMIT 1)";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@vagaMoto", estacionamento.VagaMoto);
                    cmd.Parameters.AddWithValue("@vagaCarro", estacionamento.VagaCarro);

                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message + "\n" + ex.InnerException?.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool existeEstacionamento()
        {
            string sql = "SELECT COUNT(*) FROM estacionamento"; // Conta o número total de registros na tabela
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

        public Estacionamento obterDadosEstacionamento()
        {
            Estacionamento estacionamento = new Estacionamento();
            string sql = "SELECT id, qntd_vagas_moto, qntd_vagas_carro FROM estacionamento LIMIT 1";

            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            estacionamento.Id = reader.GetInt32(reader.GetOrdinal("id"));
                            estacionamento.VagaMoto = reader.GetInt32(reader.GetOrdinal("qntd_vagas_moto"));
                            estacionamento.VagaCarro = reader.GetInt32(reader.GetOrdinal("qntd_vagas_carro"));
                        }
                        else
                        {
                            MessageBox.Show("Nenhum estacionamento encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados do estacionamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estacionamento;
        }



    }

}

