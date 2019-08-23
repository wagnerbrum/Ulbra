using System;

namespace aula03_exercicio
{
    public class Emprestimos
    {
        public Emprestimos(string nomeUsuario, int codigoMaterial, DateTime dataEmprestimo)
        {
            this.nomeUsuario = nomeUsuario;
            this.codigoMaterial = codigoMaterial;
            this.dataEmprestimo = dataEmprestimo;
        }
        public string nomeUsuario { get; private set; }

        public int codigoMaterial { get; private set; }

        public DateTime dataEmprestimo { get; private set; }

        public DateTime dataRetorno { get; set; }

        public int atraso { get; set; }

        // Ou usar o construtor...
        public bool Novo()
        {
            return true;
        }
    }
}