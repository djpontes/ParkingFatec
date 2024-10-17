using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ParkingFatec.Control
{
    public class ConexaoDAO
    {
        private string connectionString = "Server = localhost; Database = parking_fatec; UID = root; PWD =;";  // Substitua pela sua string de conexão

        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
