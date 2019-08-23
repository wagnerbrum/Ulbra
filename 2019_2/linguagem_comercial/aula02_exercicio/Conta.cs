namespace aula02_exercicio
{
    public class Conta
    {
        public Conta(int id, decimal saldo)
        {
            this.id = id;
            this.saldo = saldo;
            this.limite = 100;

        }
        public int id { get; private set; }

        public decimal saldo { get; private set; }

        public decimal limite { get; private set; }
    }
}