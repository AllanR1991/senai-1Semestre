
namespace projetoProdutos.classes
{
    public class Usuario
    {
        public List<Usuario> listaDeUsuarios = new List<Usuario>();   
        
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        
          

        public Usuario(){
            
        }
        public Usuario(int _codigo, string _nome, string _email, string _senha, DateTime _dataCadastro){
          this.Codigo = _codigo;
          this.Nome = _nome;
          this.Email = _email;
          this.Senha = _senha;
          this.DataCadastro = _dataCadastro;
        }

        public void UsuarioPadrao(){
           Usuario novoUsuario = new Usuario();
            listaDeUsuarios.Add(new Usuario(0, "admin","admin@admin","admin",DateTime.Now));
            listaDeUsuarios.Add(new Usuario(1, "kamille","kamille@kamille","kamille",DateTime.Now));

          /*   foreach (Usuario usuario in listaDeUsuarios)
          {
            Console.WriteLine("Item na lista "+ usuario.Nome);
          }*/
        } 

        public string Cadastrar(){
            int codigo = PeR.PerguntaInt("Informe o código do usuário :");
            string nome = PeR.PerguntaString("Infome o nome do Usuario :");
            string email = PeR.PerguntaString($"Informe o e-mail do usuario ({nome}) :");
            string senha = PeR.PerguntaString($"Srº(ª) {nome} digite sua senha :");
            DateTime dataAtual = DateTime.Now;

            listaDeUsuarios.Add(new Usuario(codigo, nome,email,senha,dataAtual));   
            return "";
        }

        public string Deletar(List<Usuario> listaUsuario){

            /* produto.removeat(index); */
            return "";
        }

        public void Listar(List<Usuario> listaUsuario){
          PeR.ExibeMensagemPulandoLinha(@"

---------------------------------------------------------------------------------------------
                                     Lista de Usuarios
---------------------------------------------------------------------------------------------

");
            
            foreach (Usuario item in listaDeUsuarios)
            {
              PeR.ExibeMensagemPulandoLinha($"Código : {item.Codigo} - Nome : {item.Nome} - E-mail : {item.Email} ");
            }
            PeR.ExibeMensagemPulandoLinha("---------------------------------------------------------------------------------------------");
        }

        public void ExibeMenuUsuario(List<Usuario> listaUsuario){
          int opcaoMenuUsuario;

            do
            {
                opcaoMenuUsuario = PeR.PerguntaInt(@$"
*************************
*                       *
*     Menu Usuario      *
*                       *
*************************
*                       *
*    1) Cadastar        *
*    2) Deletar         *
*    4) Deslogar        *
*                       *
*************************  
            ");
                switch (opcaoMenuUsuario)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        Listar(listaUsuario);
                        int codigoSelecionado =  PeR.PerguntaInt("Digite o codigo do usuario que deseja deletar : ");
                        
                        Deletar(listaUsuario);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
                
            } while (opcaoMenuUsuario == 4);
        }
    }
}