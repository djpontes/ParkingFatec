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
                    cmd.Parameters.AddWithValue("@ra_rm", motoristas.Ra_rm ?? (object)DBNull.Value);
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
                            string tipo = reader.IsDBNull(reader.GetOrdinal("tipo")) ? string.Empty : reader.GetString("tipo");

                            motorista = new Motoristas
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32("id"),
                                Nome = reader.IsDBNull(reader.GetOrdinal("nome")) ? string.Empty : reader.GetString("nome"),
                                Email = reader.IsDBNull(reader.GetOrdinal("email")) ? string.Empty : reader.GetString("email"),
                                Cnh = reader.IsDBNull(reader.GetOrdinal("cnh")) ? string.Empty : reader.GetString("cnh"),
                                Telefone = reader.IsDBNull(reader.GetOrdinal("telefone")) ? string.Empty : reader.GetString("telefone"),
                                Tipo = tipo,
                                Usuarios_id = reader.IsDBNull(reader.GetOrdinal("usuarios_id")) ? 0 : reader.GetInt32("usuarios_id"),
                                Ra_rm = (tipo == "Visitante") ? string.Empty : reader.IsDBNull(reader.GetOrdinal("ra_rm")) ? string.Empty : reader.GetString("ra_rm") 
                            };
                        }
                        else
                        {
                            MessageBox.Show("Motorista não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void alterarMotorista(Motoristas motoristas)
        {
            string sql = "UPDATE motoristas SET nome = @nome, email = @email, cnh = @cnh, ra_rm = @ra_rm, telefone = @telefone WHERE id = @id";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", motoristas.Id);
                    cmd.Parameters.AddWithValue("@nome", motoristas.Nome);
                    cmd.Parameters.AddWithValue("@email", motoristas.Email);
                    cmd.Parameters.AddWithValue("@cnh", motoristas.Cnh);
                    cmd.Parameters.AddWithValue("@ra_rm", motoristas.Ra_rm);
                    cmd.Parameters.AddWithValue("@telefone", motoristas.Telefone);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar usuário: " + ex.Message);
            }
        }


    }
}
