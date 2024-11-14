using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFatec.Model
{
    public class Entradas
    {
        private int id;
        private DateTime data_entrada;
        private DateTime horario_entrada;
        private int veiculos_id;
        private int usuarios_id;

        public int Id { get => id; set => id = value; }
        public DateTime Data_entrada { get => data_entrada; set => data_entrada = value; }
        public DateTime Horario_entrada { get => horario_entrada; set => horario_entrada = value; }
        public int Veiculos_id { get => veiculos_id; set => veiculos_id = value; }
        public int Usuarios_id { get => usuarios_id; set => usuarios_id = value; }
    }
}
