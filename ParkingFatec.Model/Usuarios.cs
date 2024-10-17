namespace ParkingFatec.Model
{
    public class Usuarios
    {
        private int id;
        private string nome;
        private string email;
        private string senha;
        private int nivelAcesso;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int NivelAcesso { get => nivelAcesso; set => nivelAcesso = value; }
    }
}
