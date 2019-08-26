namespace aula04_atividade02
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(char[] nome, char[] endereco, char[] telefone, char[] bairro, long cep, char[] cidade, char[] estado, long cpf, char rg) : base(nome, endereco, telefone, bairro, cep, cidade, estado)
        {
            this.rg = new char[20];

            this.cpf = cpf;
            this.rg = rg;
        }

        public long cpf { private get; private set; }

        public char rg { private get; private set; }
    }
}