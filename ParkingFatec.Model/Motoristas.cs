namespace ParkingFatec.Model
{
    public class Motoristas
    {
        private int id;
        private string nome;
        private string email;
        private string cnh;
        private string ra_rm;
        private string telefone;
        private int tipo;
        private int usuarios_id;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Usuarios_id { get => usuarios_id; set => usuarios_id = value; }
        public string Ra_rm { get => ra_rm; set => ra_rm = value; }
    }
}
