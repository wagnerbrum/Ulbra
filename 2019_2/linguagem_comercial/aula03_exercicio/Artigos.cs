namespace aula03_exercicio
{
    public class Artigos
    {
        public Artigos(string autor, string tituloArtigo, Revistas revista)
        {
            this.autor = autor;
            this.tituloArtigo = tituloArtigo;
            this.revista = revista;
        }
        public string autor { get; private set; }

        public string tituloArtigo { get; private set; }

        public Revistas revista { get; private set; }
    }
}