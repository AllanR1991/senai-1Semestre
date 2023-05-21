namespace projetoProdutos.classes
{
    public class Login
    {
        public bool Logado { get; private set; }

        public Usuario logado;
        Usuario objUsuario = new Usuario();

        Marca objMarca= new Marca();
        public Login()
        {
             
        }

        public void InicializaUsuario(){
            objUsuario.UsuarioPadrao();
        }
        public void Logar(Login login)
        {
            List<Usuario> objLista = objUsuario.listaDeUsuarios;
            string nomeUsuario;
            string senhaUsuario;
            bool senhaCorreta = false;
            bool usuarioExiste = false;
            string mensagemErroLogin = "\nUsuario ou senha estão incorretos.\n";
            do
            {
                nomeUsuario = PeR.PerguntaString("Digite o nome do usuario :");
                senhaUsuario = PeR.PerguntaString("Digite sua senha :");

                usuarioExiste = (objLista.Find(x => x.Nome == nomeUsuario) != null);

                if (usuarioExiste)
                {
                    /*Procura um objeto usuario que contem o nome digitado em "nomeUsuario"*/
                    Usuario usuarioEncontrado = objLista.Find(x => x.Nome == nomeUsuario);
                    /*Pega o indice do objeto encontrado e armazena em index*/
                    int index = objLista.IndexOf(usuarioEncontrado);
                    /*vericia se a senha é igual o indice encontrado*/
                    senhaCorreta = (
                        objLista[index].Nome == nomeUsuario && objLista[index].Senha == senhaUsuario
                    );

                    if (senhaCorreta)
                    {
                        Usuario usuarioLogado;
                        PeR.ExibeMensagemPulandoLinha("Logado com sucesso");
                        PeR.ExibeMensagem(@$"
*************************
*                       *
*       System of       *
*        Product        *
*                       *
*************************   
                ");
                        ExibeMenuPrincipal(login);
                    }
                    else
                    {
                        senhaCorreta = false;
                        PeR.ExibeMensagemPulandoLinha(mensagemErroLogin);
                    }
                }
                else
                {
                    PeR.ExibeMensagemPulandoLinha(mensagemErroLogin);
                }
            } while ((!usuarioExiste || !senhaCorreta));
        }

        public void Deslogar(Login login)
        {
            char desejaDeslogar  = PeR.PerguntaChar("Deseja deslogar mesmo? (Digite (s) para sim e (n) para não)");
            if(desejaDeslogar == 's'){
                
                char logarNovamente = PeR.PerguntaChar("Deseja logar com outro usuario? (Digite (s) para sim e (n) para não)");
                if(logarNovamente == 's'){
                    login.Logar(login);
                }else{
                    PeR.ExibeMensagemPulandoLinha("Sistema sendo encerrado.");
                    Environment.Exit(0);
                }
                
            }else{
                PeR.ExibeMensagemPulandoLinha("Operação deslogar, cancelada.");
            }
        }

        public void ExibeMenuPrincipal(Login login)
        {
            
            int opcaoMenuPrincipal;
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
                        objUsuario.ExibeMenuUsuario(objUsuario.listaDeUsuarios, login);
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        objMarca.ExibeMenuMarca(objMarca,login);
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
                
            } while(opcaoMenuPrincipal == 4);
        }
    }
}
