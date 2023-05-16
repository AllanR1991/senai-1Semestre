
namespace projetoProdutos.classes
{
    public class Usuario
    {
        List<Usuario> usuarios = new List<Usuario>();
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        
        public string Cadastrar(Usuario _newUsuario){
            usuarios.Add(_newUsuario);
            return "";
        }

        public string Deletar(Usuario _newUsuario){
            usuarios.Remove(_newUsuario);
            return "";
        }
    }
}