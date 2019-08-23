namespace aula02
{
    public class Conta
    {
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
        }

        //prop + tab + tab
        public int numero {private get; set; }
        public string titular {get; private set; }
        public string saldo {get; private set; }

        
    }
}