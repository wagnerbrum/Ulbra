using System.Collections.Generic;

namespace aula03_exercicio
{
    public class Revistas : Materiais
    {

        public Revistas(int codigo, string assunto, string titulo, string colecao, string editora) : base(codigo, assunto, titulo)
        {
            this.colecao = colecao;
            this.editora = editora;
        }
        public string colecao { get; private set; }

        public string editora { get; private set; }

        // Vou deixar ele com set liberado e não no construtor pois pelo entendimento do que foi passado, 
        // uma reserva não necessáriamente se faz na contrução do objeto
        public List<Artigos> artigos { get; set; }

        // Dependendo da lógica de negocios, pode ter um print, devolver o próprio objeto, ou só o texto... 
        public void MostrarDetalhes()
        {
            
        }
    }
}