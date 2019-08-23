using System;

namespace aula02_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao exercicio!");

            Cliente cliente1 = new Cliente(1, "Nome 1");
            Cliente cliente2 = new Cliente(2, "Nome 2");

            CartaoDeCredito cartao1 = new CartaoDeCredito(1, new DateTime(2019, 03, 20));
            CartaoDeCredito cartao2 = new CartaoDeCredito(2, new DateTime(2018, 02, 18));

            Console.WriteLine($"Num. Cartão: {cartao1.numero} - Validade: {cartao1.validade.ToString("MM/yy")}");
            Console.WriteLine($"Num. Cartão: {cartao2.numero} - Validade: {cartao2.validade.ToString("MM/yy")}");
        }
    }
}
