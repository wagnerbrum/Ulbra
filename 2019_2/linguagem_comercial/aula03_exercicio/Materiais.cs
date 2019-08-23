using System.Collections.Generic;

namespace aula03_exercicio
{
    public class Materiais
    {

        public Materiais(int codigo, string assunto, string titulo)
        {
            this.codigo = codigo;
            this.assunto = assunto;
            this.titulo = titulo;
        }

        public int codigo { get; private set; }

        public string assunto { get; private set; }

        public string titulo { get; private set; }

        // Vou deixar ele com set liberado e não no construtor pois pelo entendimento do que foi passado, 
        // uma reserva não necessáriamente se faz na contrução do objeto
        public List<Reservas> reservas { get; set; }

        public bool Emprestar()
        {
            return true;
        }

        public bool Devolver()
        {
            return true;
        }
    }
}