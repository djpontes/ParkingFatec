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
            string sql = "INSERT INTO entradas (data_entrada, horario_entrada, modelo, veiculos_id, usuarios_id) VALUES (@data_entrada, @horario_entrada, " +
                "@modelo, @veiculos_id, @usuarios_id)";
            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@data_entrada", entradas.Data_entrada);
                    cmd.Parameters.AddWithValue("@horario_entrada", entradas.Horario_entrada);
                    cmd.Parameters.AddWithValue("@modelo", entradas.Modelo);
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

    }
}
