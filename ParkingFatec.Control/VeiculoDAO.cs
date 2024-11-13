using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ParkingFatec.Model;

namespace ParkingFatec.Control
{
    public class VeiculoDAO
    {
        ConexaoDAO conn = new ConexaoDAO();
        Veiculo veiculo = new Veiculo();

        public void inserirVeiculo(Veiculo veiculo)
        {
            string sql = "INSERT INTO veiculos (placa, tipo, modelo, cor, motoristas_id, usuarios_id) VALUES (@placa, @tipo, @modelo, @cor, @motoristas_id, @usuarios_id)";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                    cmd.Parameters.AddWithValue("@tipo", veiculo.Tipo);
                    cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    cmd.Parameters.AddWithValue("@cor", veiculo.Cor);
                    cmd.Parameters.AddWithValue("@motoristas_id", veiculo.Motoristas_id);
                    cmd.Parameters.AddWithValue("@usuarios_id", veiculo.Usuarios_id);


                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message + "\n" + ex.InnerException?.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Motoristas obterDadosVeiculos(string placa)
        {
            Motoristas motorista = null;
            string sql = "SELECT id, placa, tipo, modelo, cor, motoristas_id, usuarios_id FROM veiculos WHERE placa = @placa";

            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@placa", placa);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            motorista = new Motoristas
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Email = reader.GetString("email"),
                                Cnh = reader.GetString("cnh"),
                                Ra_rm = reader.GetString("ra_rm"),
                                Telefone = reader.GetString("telefone"),
                                Tipo = reader.GetInt32("tipo"),
                                Usuarios_id = reader.GetInt32("usuarios_id")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados do usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return motorista;
        }
    }
}
