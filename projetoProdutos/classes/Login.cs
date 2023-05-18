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
            usuario.UsuarioPadrao();
            Logar(usuario.listaDeUsuarios);
            foreach (var item in usuario.listaDeUsuarios)
            {
                Console.WriteLine("Item na lista " + item.Nome);
            }
        }
        public void Logar(List<Usuario> usuarios)
        {
            string nomeUsuario;
            string senhaUsuario;
            do
            {
                nomeUsuario = PeR.PerguntaString("Digite o nome do usuario :");
                senhaUsuario = PeR.PerguntaString("Digite sua senha :");
                
                if ((usuarios.Find(x => x.Nome == nomeUsuario) != null ) && (usuarios.Find(x => x.Senha == senhaUsuario) != null))
                {
                    Usuario usuarioEncontrado = usuarios.Find(x => x.Nome == nomeUsuario);
                    int index = usuarios.IndexOf(usuarioEncontrado);

                    if (usuarios[index].Nome == nomeUsuario && usuarios[index].Senha == senhaUsuario)
                    {
                        Console.WriteLine("Logado com sucesso");
                    }
                }else
                    {
                        Console.WriteLine("Usuario ou senha estão incorretos.");
                    }
            } while ((usuarios.Find(x => x.Nome == nomeUsuario) == null) || (usuarios.Find(x => x.Senha == senhaUsuario) == null));
        }
        public string Deslogar(Usuario usuario)
        {
            return "";
        }

    }
}