namespace aula03_exercicio
{
    public class Usuarios
    {

        public Usuarios(string nome, string local, string telefone, string senha)
        {
            this.nome = nome;
            this.local = local;
            this.telefone = telefone;
            this.senha = senha;
        }
        public string nome { get; private set; }

        public string local { get; private set; }

        public string telefone { get; private set; }

        public string senha { get; private set; }

        public bool FazReserva(Livros livro)
        {
            return true;
        }

        public bool FazReserva(Revistas revista)
        {
            return true;
        }
    }
}