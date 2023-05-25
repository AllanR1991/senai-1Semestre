using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleMVC.Model;

namespace ConsoleMVC.View
{
    public class ProdutoView
    {
        //metodo para exibir os dados da lista de produtos
        public void Listar(List<Produto> Produto)
        {
            Console.Clear();
            //foreach  para ler a lista passada como Paramêtro
            foreach (var item in Produto)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}\n"); 
            }
        }

        public Produto Cadastrar(){
            Produto newProduto = new Produto();
            newProduto.Codigo = PeR.PerguntaInt("Informe o código : ");
            newProduto.Nome = PeR.PerguntaString("Informe o nome : ");
            newProduto.Preco = PeR.PerguntaFloat("Informe o preço : ");

            return newProduto;
        }
    }

}