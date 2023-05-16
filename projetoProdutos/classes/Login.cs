using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoProdutos.classes
{
    public class Login
    {
       
       public bool Logado { get; private set; }
       
       Usuario usuario = new Usuario();

       public Login()
       {
        
       }

       public string Logar(Usuario usuario){
            return "";
       }
       public string Deslogar(Usuario usuario){
            return "";
       }
        
    }
}