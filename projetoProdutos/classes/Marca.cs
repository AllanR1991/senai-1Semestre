using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoProdutos.classes
{
    public class Marca
    {
        public int Codigo { get;private set; }
        public string NomeMarca { get;private set; }
        public DateTime DataCadastro { get;private set; }

        public string Cadastrar (Marca marca){
            return "";
        }
        List<Marca>ListaDeMarca = new List<Marca>();
        public List<Marca> Listar(){
            return ListaDeMarca;
        }
    }
}