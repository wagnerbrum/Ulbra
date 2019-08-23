namespace aula02_exercicio
{
    public class Agencia
    {
        public Agencia(int id, int numero)
        {
            this.id = id;
            this.numero = numero;
        }

        public int id { get; private set; }

        public int numero { get; private set; }

    }
}