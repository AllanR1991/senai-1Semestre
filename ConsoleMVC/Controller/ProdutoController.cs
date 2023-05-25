using ConsoleMVC.Model;
using ConsoleMVC.View;

namespace ConsoleMVC.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produto view
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();


        //método controlador para acessar a listagem de produto
        public void ListarProdutos()
        {
            //lista de produtos chamada pela model, no método Ler.
            List<Produto> listaDeProduto = produto.Listar();

            //chamada do método de exibição,recebendo como argumento a lista.
            produtoView.Listar(listaDeProduto);

        }

        //Metodo controlador para acessar o cadastro produto.
        public void CadastrarProduto(){
            Produto produtoCadastrado = produtoView.Cadastrar();
            produto.Inserir(produtoCadastrado);
        }
    }
}