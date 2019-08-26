namespace aula04_atividade02
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(char[] nome, char[] endereco, char[] telefone, char[] bairro, long cep, char[] cidade, char[] estado, cnpj cpf) : base(nome, endereco, telefone, bairro, cep, cidade, estado)
        {
            this.cnpj = cnpj;
        }

        public long cnpj { private get; private set; }
    }
}