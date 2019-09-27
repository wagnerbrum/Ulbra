* Design Patterns

	Factory Method
        É um padrão que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alteram o tipo de objeto criado.

    
        interface Produto {
            metodo();
        }

        class ProdutoA implements Produto {
            metodo();
        }

        class ProdutoB implements Produto {
            metodo();
        }

        abstract class Creator {
            abstract Produto criarProduto()
        }

        class CriatorProdutoA extends Creator {
            Produto criarProduto(){
                return new ProdutoA();
            }
        }

        class CriatorProdutoB extends Creator {
            Produto criarProduto(){
                return new ProdutoB();
            }
        }

    Singleton
        É um padrão que permite garantir que uma classe tenha apenas uma instância, enquanto fornece um ponto de acesso global a essa instância.

    