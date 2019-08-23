namespace aula02_exercicio
{
    public class Cliente
    {
        public Cliente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int id { get; private set;}
        public string nome { get; private set;}
    }
}