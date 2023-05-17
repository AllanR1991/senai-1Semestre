using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoProdutos.classes
{
    public class Login
    {
        public bool Logado { get; private set; }

        public Login()
        {
          Usuario usuario = new Usuario();
          Logar(usuario.listaDeUsuarios);
        }
        public string Logar(List<Usuario> usuarios)
        {
          string nomeUsuario = PeR.PerguntaString("Digite o nome do usuario :");
          string senhaUsuario = PeR.PerguntaString("Digite sua senha :");

          
          return "";
        }
        public string Deslogar(Usuario usuario)
        {
            return "";
        }

    }
}