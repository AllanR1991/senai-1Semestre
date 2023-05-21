namespace projetoProdutos.classes
{
    public class Usuario
    {
        public List<Usuario> listaDeUsuarios = new List<Usuario>();
        public List<Usuario> listaExcluidos = new List<Usuario>();
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Usuario() { }

        public Usuario(
            int _codigo,
            string _nome,
            string _email,
            string _senha,
            DateTime _dataCadastro
        )
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;
            this.DataCadastro = _dataCadastro;
        }

        public void UsuarioPadrao()
        {
            Usuario objUsuario = new Usuario();
            listaDeUsuarios.Add(new Usuario(0, "admin", "admin@admin", "admin", DateTime.Now));
            listaDeUsuarios.Add(
                new Usuario(1, "kamille", "kamille@kamille.com", "kamille", DateTime.Now)
            );

            /*   foreach (Usuario usuario in listaDeUsuarios)
            {
              Console.WriteLine("Item na lista "+ usuario.Nome);
            }*/
        }

        public string Cadastrar()
        {
            int codigo = PeR.PerguntaInt("\nInforme o código do usuário :");
            string nome = PeR.PerguntaString("Infome o nome do Usuario :");
            string email = PeR.PerguntaString($"Informe o e-mail do usuario ({nome}) :");
            string senha = PeR.PerguntaString($"Srº(ª) {nome} digite sua senha :");
            DateTime dataAtual = DateTime.Now;

            PeR.ExibeMensagem("\n");

            listaDeUsuarios.Add(new Usuario(codigo, nome, email, senha, dataAtual));
            return "";
        }

        public void Deletar(List<Usuario> listaDeUsuarios, Login login)
        {
            bool codigoExiste;
            char desejaDeletar;
            int indice;
            int codigoSelecionado = PeR.PerguntaInt(
                "Digite o codigo do usuario que deseja deletar : "
            );
            codigoExiste = (listaDeUsuarios.Find(x => x.Codigo == codigoSelecionado) != null);
            if (codigoExiste)
            {
                Usuario codigoEcontrado = listaDeUsuarios.Find(x => x.Codigo == codigoSelecionado);

                indice = listaDeUsuarios.IndexOf(codigoEcontrado);

                desejaDeletar = PeR.PerguntaChar(
                    @$"
---------------------------------------------------------------------------------------------

                                Deseja realmente deletar:

Codigo : {listaDeUsuarios[indice].Codigo}
Nome : {listaDeUsuarios[indice].Nome}
Email : {listaDeUsuarios[indice].Email}

                        Pressione (s) para sim ou (n) para não.

---------------------------------------------------------------------------------------------
                            
                            "
                );

                if (desejaDeletar == 's')
                {
                    listaExcluidos.Add(listaDeUsuarios[indice]);
                    listaDeUsuarios.RemoveAt(indice);
                }
                else
                {
                    PeR.ExibeMensagemPulandoLinha(
                        $"\nOperação de deletar o Usuario {listaDeUsuarios[indice].Nome} foi cancelada com sucesso."
                    );
                }
            }
            else
            {
                PeR.ExibeMensagemPulandoLinha($"\nCodigo informado não encontrado.");
            }
        }

        public void Listar(List<Usuario> listaDeUsuarios)
        {
            if (listaDeUsuarios.Count > 0)
            {
                PeR.ExibeMensagemPulandoLinha(
                    @"

---------------------------------------------------------------------------------------------
                                     Lista de Usuarios
---------------------------------------------------------------------------------------------

"
                );
                int contador = 1;
                foreach (Usuario user in listaDeUsuarios)
                {
                    PeR.ExibeMensagemPulandoLinha(
                        $"{contador} Código : {user.Codigo} - Nome: {user.Nome} - Email: {user.Email}"
                    );
                    contador++;
                }
                PeR.ExibeMensagemPulandoLinha(
                    "---------------------------------------------------------------------------------------------\n"
                );
            }
        }

        public void RelatorioUsuariosExcluidos()
        {
            if (listaExcluidos.Count > 0)
            {
                PeR.ExibeMensagemPulandoLinha(
                    @"

---------------------------------------------------------------------------------------------
                                Lista de Usuarios Deletados
---------------------------------------------------------------------------------------------

"
                );
                int contador = 1;
                foreach (Usuario user in listaExcluidos)
                {
                    PeR.ExibeMensagemPulandoLinha(
                        $"{contador} Código : {user.Codigo} - Nome: {user.Nome} - Email: {user.Email}"
                    );
                    contador++;
                }
                PeR.ExibeMensagemPulandoLinha(
                    "---------------------------------------------------------------------------------------------\n"
                );
            }
            else
            {
                PeR.ExibeMensagemPulandoLinha("\nNão possui nenhum item excluido no sistema.\n");
            }
        }

        public Usuario SetUsuarioLogado(Usuario userLogado)
        {
            Usuario logado = new Usuario();
            logado.Codigo = userLogado.Codigo;
            logado.Nome = userLogado.Nome;
            logado.Email = userLogado.Email;
            logado.DataCadastro = DateTime.Now;

            return logado;
        }

        public void ExibeMenuUsuario(
            List<Usuario> listaDeUsuarios,
            Login login,
            Usuario usuarioLogado
        )
        {
            int opcaoMenuUsuario;

            do
            {
                opcaoMenuUsuario = PeR.PerguntaInt(
                    @$"
*************************
*                       *
*     Menu Usuario      *
*                       *
*************************
*                       *
*    1) Cadastar        *
*                       *
*    2) Deletar         *
*                       *
*    3) Lista de        * 
*       Usuarios        *
*                       *
*    4) Relatorio de    *
*       exclusão        *
*                       *
*    5) Deslogar        *
*                       *
*    6) Voltar ao Menu  *
*       Principal       *
*                       *
*    7) Fechar o        *
*       sistema         *
*                       *
*************************   
                "
                );
                switch (opcaoMenuUsuario)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        Listar(listaDeUsuarios);
                        Deletar(listaDeUsuarios, login);
                        break;
                    case 3:
                        Listar(listaDeUsuarios);
                        break;
                    case 4:
                        RelatorioUsuariosExcluidos();
                        break;
                    case 5:
                        login.Deslogar(login);
                        break;
                    case 6:
                        login.ExibeMenuPrincipal(usuarioLogado, login);
                        break;
                    case 7:
                        /*Para o sistema geral*/
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (opcaoMenuUsuario != 7);
        }
    }
}
