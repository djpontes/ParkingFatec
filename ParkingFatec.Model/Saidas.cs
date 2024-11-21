using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFatec.Model
{
    public class Saidas
    {
        private int id;
        private DateTime data_saida;
        private DateTime horario_saida;
        private int veiculos_id;
        private int usuarios_id;

        public int Id { get => id; set => id = value; }
        public DateTime Data_saida { get => data_saida; set => data_saida = value; }
        public DateTime Horario_saida { get => horario_saida; set => horario_saida = value; }
        public int Veiculos_id { get => veiculos_id; set => veiculos_id = value; }
        public int Usuarios_id { get => usuarios_id; set => usuarios_id = value; }
    }
}

