namespace aula03_exercicio
{
    public class Livros : Materiais
    {
        public Livros(int codigo, string assunto, string titulo, string editora, string edicao, string isbn, string autor) : base(codigo, assunto, titulo)
        {
            this.editora = editora;
            this.edicao = edicao;
            this.isbn = isbn;
            this.autor = autor;

        }
        public string editora { get; private set; }

        public string edicao { get; private set; }

        public string isbn { get; private set; }

        public string autor { get; private set; }

        // Dependendo da lógica de negocios, pode ter um print, devolver o próprio objeto, ou só o texto... 
        public void MostrarDetalhes()
        {

        }
    }
}