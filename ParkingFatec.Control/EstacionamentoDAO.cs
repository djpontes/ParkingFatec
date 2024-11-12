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
            string sql = "UPDATE estacionamento SET qntd_vagas_moto = @vagaMoto, qntd_vagas_carro = @vagaCarro";
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

        public Estacionamento obterDadosEstacionamento(int id)
        {
            Estacionamento estacionamento = new Estacionamento();
            string sql = "SELECT id, qntd_vagas_moto, qntd_vagas_carro FROM estacionamento WHERE id = @Id";


            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            estacionamento.Id = reader.GetInt32("id");
                            estacionamento.VagaMoto = reader.GetInt32("qntd_vagas_moto");
                            estacionamento.VagaCarro = reader.GetInt32("qntd_vagas_carro");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados do usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estacionamento;
        }
    }
}
