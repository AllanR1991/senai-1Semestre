using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoProdutos.classes
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        
        public Marca marca = new Marca();

        public Usuario CadastradoPor = new Usuario();

        List<Produto> ListaDeProdutos = new List<Produto>();

        /*-------------------------------------------------------*/
        
        public string Cadastrar(Produto produto){
            return "";
        }

        public List<Produto> Listar(){
            return ListaDeProdutos;
        }
        public string Deletar(Produto produto){
            return "";
        }

    }
}