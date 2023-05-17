
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
        public Usuario(int _codigo, string _nome, string _email, string _senha, DateTime _dataCadastro)
        {
        }

        public void UsuarioPadrao(){
            listaDeUsuarios.Add(new Usuario(1, "admin","admin@admin","admin",DateTime.Now));
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

        public string Deletar(Usuario _newUsuario){
            usuarios.Remove(_newUsuario);
            return "";
        }
    }
}