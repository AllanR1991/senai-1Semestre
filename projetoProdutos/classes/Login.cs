using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoProdutos.classes
{
    public class Login
    {
        public bool Logado { get; private set; }
        Usuario objUsuario = new Usuario();
        public Login()
        {
            
            objUsuario.UsuarioPadrao();
            Logar(objUsuario.listaDeUsuarios);
            /* foreach (var item in usuario.listaDeUsuarios)
            {
                Console.WriteLine("Item na lista " + item.Nome);
            } */
        }
        public void Logar(List<Usuario> usuarios)
        {
            string nomeUsuario;
            string senhaUsuario;
            bool usuarioExiste = false;
            bool senhaCorreta = false;
            string mensagemErroLogin = "\nUsuario ou senha estão incorretos.\n";
            do
            {
                nomeUsuario = PeR.PerguntaString("Digite o nome do usuario :");
                senhaUsuario = PeR.PerguntaString("Digite sua senha :");
                usuarioExiste =  (usuarios.Find(x => x.Nome == nomeUsuario) != null);
                if (usuarioExiste)
                {
                    Usuario usuarioEncontrado = (usuarios.Find(x => x.Nome == nomeUsuario));
                    int index = (usuarios.IndexOf(usuarioEncontrado));
                    senhaCorreta = (usuarios[index].Senha == senhaUsuario);
                    if (usuarioExiste && senhaCorreta)
                    {
                        Console.WriteLine("Logado com sucesso");
                        ExibeMenuPrincipal();
                    }else
                    {
                        senhaCorreta = false;
                        PeR.ExibeMensagemPulandoLinha(mensagemErroLogin);

                    }
                }else
                    {
                        Console.WriteLine(mensagemErroLogin);
                    }
            } while (!usuarioExiste || !senhaCorreta);
        }
        public string Deslogar(Usuario usuario)
        {
            return "";
        }

        public  void ExibeMenuPrincipal(){
            int opcaoMenuPrincipal;

            PeR.ExibeMensagemPulandoLinha(@$"
*************************
*                       *
*       System of       *
*        Product        *
*                       *
*************************  
            ");
            do
            {
                opcaoMenuPrincipal = PeR.PerguntaInt(@$"
*************************
*                       *
*    Menu Principal     *
*                       *
*************************
*                       *
*    1) Usuario         *
*    2) Produto         *
*    3) Marca           *
*    4) Deslogar        *
*                       *
*************************  
            ");
                switch (opcaoMenuPrincipal)
                {
                    case 1:
                        objUsuario.ExibeMenuUsuario(objUsuario.listaDeUsuarios);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
                
            } while (opcaoMenuPrincipal == 4);
        }
    }
}