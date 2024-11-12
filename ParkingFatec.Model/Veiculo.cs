using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFatec.Model
{
    public class Veiculo
    {
        private int id;
        private string placa;
        private string tipo;
        private string modelo;
        private string cor;
        private int usuarios_id;
        private int motoristas_id;

        public int Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Usuarios_id { get => usuarios_id; set => usuarios_id = value; }
        public int Motoristas_id { get => motoristas_id; set => motoristas_id = value; }
    }


}
