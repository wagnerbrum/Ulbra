namespace aula04_atividade02
{
    public class Pessoa
    {
        public Pessoa(char[] nome, char[] endereco, char[] telefone, char[] bairro, long cep, char[] cidade, char[] estado)
        {
            this.nome = new char[40];
            this.endereco = new char[40];
            this.telefone = new char[15];
            this.bairro = new char[20];
            this.cidade = new char[30];
            this.estado = new char[2];

            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
        }

        public char[] nome { protected get; protected set; }

        public char[] endereco { protected get; protected set; }

        public char[] telefone { protected get; protected set; }

        public char[] bairro { protected get; protected set; }

        public long cep { protected get; protected set; }

        public char[] cidade { protected get; protected set; }

        public char[] estado { protected get; protected set; }

        public int ConPes()
        {
            return 0;
        }
    }
}