using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFatec.Model
{
    public class Estacionamento
    {
        private int id;
        private int vagaMoto;
        private int vagaCarro;

        public int Id { get => id; set => id = value; }
        public int VagaMoto { get => vagaMoto; set => vagaMoto = value; }
        public int VagaCarro { get => vagaCarro; set => vagaCarro = value; }
    }
}
