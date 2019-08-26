namespace aula04_atividade02
{
    public class Carrinho
    {
        public Carrinho()
        {

        }

        public Carrinho(List<Produto> produto)
        {
            this.produto = produto;
        }

        public List<Produto> produto { private get; set; }

        public void ExibeCarrinho()
        {

        }

        public float FecharCompra()
        {
            //apenas para não dar erro de não ter retorno
            return 0;
        }
    }
}