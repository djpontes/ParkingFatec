using MySql.Data.MySqlClient;
using ParkingFatec.Model;

namespace ParkingFatec.Control
{
    public class MotoristasDAO
    {
        ConexaoDAO conn = new ConexaoDAO();
        Motoristas motoristas = new Motoristas();
        public void inserirMotorista(Motoristas motoristas)
        {
            string sql = "INSERT INTO motoristas (nome, email, cnh, ra_rm, telefone, tipo, usuarios_id) VALUES (@nome, @email, @cnh, @ra_rm, @telefone," +
                "@tipo, @usuarios_id)";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@nome", motoristas.Nome);
                    cmd.Parameters.AddWithValue("@email", motoristas.Email);
                    cmd.Parameters.AddWithValue("@cnh", motoristas.Cnh);
                    cmd.Parameters.AddWithValue("@ra_rm", motoristas.Ra_rm);
                    cmd.Parameters.AddWithValue("@telefone", motoristas.Telefone);
                    cmd.Parameters.AddWithValue("@tipo", motoristas.Tipo);
                    cmd.Parameters.AddWithValue("@usuarios_id", motoristas.Usuarios_id);

                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message + "\n" + ex.InnerException?.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Motoristas obterDadosMotorista(string cnh)
        {
            Motoristas motorista = null;
            string sql = "SELECT id, nome, email, cnh, ra_rm, telefone, tipo, usuarios_id FROM motoristas WHERE cnh = @cnh";

            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@cnh", cnh);

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
