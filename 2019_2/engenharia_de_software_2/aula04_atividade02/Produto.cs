namespace aula04_atividade02
{
    public class Produto
    {
        public Produto(int codigo, string descProduto, float preco, int quantidade)
        {
            this.codigo = codigo;
            this.descProduto = descProduto;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public int codigo { get; set; }

        public string descProduto { get; set; }

        public float preco { get; set; }

        public int quantidade { get; set; }

        public void ListarDados()
        {

        }
    }
}