namespace projetoProdutos.classes
{
    public class Login
    {
        public bool Logado { get; private set; }

        public Usuario logado;
        Usuario objUsuario = new Usuario();

        Produto objProduto = new Produto();
        Marca objMarca= new Marca();
        public Login()
        {
        }

        public void InicializaUsuario(){
            objUsuario.UsuarioPadrao();
        }
        public void Logar(Login login)
        {
            Console.Clear();
            List<Usuario> objLista = objUsuario.listaDeUsuarios;
            string nomeUsuario;
            string senhaUsuario;
            int index;
            bool senhaCorreta = false;
            bool usuarioExiste = false;

            string mensagemErroLogin = "\nUsuario ou senha estão incorretos.\n";
            do
            {
                PeR.ExibeMensagemPulandoLinha("******** Login ********\n");

                nomeUsuario = PeR.PerguntaString("Digite o nome do usuario :");
                senhaUsuario = PeR.PerguntaString("\nDigite sua senha :");

                PeR.BarraCarregamento("\nVerificando acesso",10,100);
                PeR.ExibeMensagemPulandoLinha("");
                usuarioExiste = (objLista.Find(x => x.Nome == nomeUsuario) != null);

                if (usuarioExiste)
                {
                    /*Procura um objeto usuario que contem o nome digitado em "nomeUsuario"*/
                    Usuario usuarioEncontrado = objLista.Find(x => x.Nome == nomeUsuario);
                    /*Pega o indice do objeto encontrado e armazena em index*/
                    index = objLista.IndexOf(usuarioEncontrado);
                    /*vericia se a senha é igual o indice encontrado*/
                    senhaCorreta = (
                        objLista[index].Nome == nomeUsuario && objLista[index].Senha == senhaUsuario
                    );

                    if (senhaCorreta)
                    {
                        Usuario logado = objUsuario.SetUsuarioLogado(objLista[index]);
                        PeR.ExibeMensagemPulandoLinha("\nLogado com sucesso");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        PeR.ExibeMensagem(@$"                       
*************************
*                       *
*       System of       *
*        Product        *
*                       *
*************************   
                ");
                        Console.ResetColor();
                        ExibeMenuPrincipal(logado,login);

                    }
                    else
                    {

                        senhaCorreta = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        PeR.ExibeMensagemPulandoLinha(mensagemErroLogin);
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PeR.ExibeMensagemPulandoLinha(mensagemErroLogin);
                    Console.ResetColor();
                }
            } while ((!usuarioExiste || !senhaCorreta));

        }

        public void Deslogar(Login login)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            char desejaDeslogar  = PeR.PerguntaChar("\nDeseja deslogar mesmo? (Digite (s) para sim e (n) para não)");
            Console.ResetColor();
            if(desejaDeslogar == 's'){
                Console.ForegroundColor = ConsoleColor.Yellow;
                char logarNovamente = PeR.PerguntaChar("Deseja logar com outro usuario? (Digite (s) para sim e (n) para não)");
                Console.ResetColor();
                PeR.ExibeMensagemPulandoLinha("\n");
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

        public void ExibeMenuPrincipal(Usuario usuarioLogado,Login login)
        {
            
            int opcaoMenuPrincipal;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                opcaoMenuPrincipal = PeR.PerguntaInt(@$"
*************************
*                       *
*    Menu Principal     *
*                       *
*************************
*                       *
*    1) Usuario         *
*                       *
*    2) Produto         *
*                       *
*    3) Marca           *
*                       *
*    4) Deslogar        *
*                       *
*    5) Fechar o        *
*       sistema         *
*                       *
*************************  

Opção :                ");
                Console.ResetColor();
                switch (opcaoMenuPrincipal)
                {
                    case 1:
                        objUsuario.ExibeMenuUsuario(objUsuario.listaDeUsuarios, login, usuarioLogado);
                        break;
                    case 2:
                        objProduto.ExibeMenuProduto(objMarca.listaDeMarca, objProduto.ListaDeProdutos,login,usuarioLogado);
                        break;
                    case 3:
                        objMarca.ExibeMenuMarca(objMarca.listaDeMarca,objMarca,login,usuarioLogado);
                        break;
                    case 4:
                        login.Deslogar(login);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                

            } while(opcaoMenuPrincipal == 4);

        }
    }
}
