using System;

namespace aula02_exercicio
{
    public class CartaoDeCredito
    {
        public CartaoDeCredito(int numero, DateTime validade)
        {
            this.numero = numero;
            this.validade = validade;
        }
        
        public int numero {get; private set;}

        public DateTime validade {get; private set;}
    }
}