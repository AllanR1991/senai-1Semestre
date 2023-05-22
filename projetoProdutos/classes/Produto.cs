using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace projetoProdutos.classes
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Marca Marca;

        public Usuario CadastradoPor;

        public List<Produto> ListaDeProdutos = new List<Produto>();

        public List<Produto> ListaDeProdutosExcluidos = new List<Produto>();

        /*-------------------------------------------------------*/

        Marca marca = new Marca();

        public Produto() { }

        public Produto(
            int _codigo,
            string _nomeProduto,
            float _preco,
            DateTime _dataCadastro,
            Marca _marca,
            Usuario _cadastradoPor
        )
        {
            this.Codigo = _codigo;
            this.NomeProduto = _nomeProduto;
            this.Preco = _preco;
            this.DataCadastro = _dataCadastro;
            this.Marca = _marca;
            this.CadastradoPor = _cadastradoPor;
        }

        public void Cadastrar(List<Marca> listaDeMarca, Usuario usuarioLogado)
        {
            bool codigoExiste;
            int indice;
            string escolha;
            char desejaCadastrarMarca;
            bool verificaRex;
            string nomeProduto;
           
            Console.ForegroundColor = ConsoleColor.Green;
            
            int codigo = PeR.PerguntaInt("\nInforme o número do Produto :");
           
            nomeProduto = PeR.PerguntaString("Infome o nome do produto :");
            

            float preco = PeR.PerguntaFloat($"Informe o o preço do produto ({nomeProduto}) :");
            DateTime dataAtual = DateTime.Now;
            Console.ResetColor();
            if (listaDeMarca.Count > 0)
            {
                bool deuCerto = true;
                marca.Listar(listaDeMarca);
                Console.ForegroundColor = ConsoleColor.Green;
                escolha = PeR.PerguntaString(
                    $"Esolha uma das marca na lista a acima digitando o numero do codigo correspondente ou digite \"criar\" para criar uma nova marca para o produto {nomeProduto}"
                );
                Console.ResetColor();

                if (escolha == "criar")
                {
                    marca = marca.Cadastrar(listaDeMarca);
                    listaDeMarca.Add(marca);
                }
                else
                {
                    do
                    {
                        deuCerto = int.TryParse(escolha, out var valor);
                        if (!deuCerto)
                        {
                            marca.Listar(listaDeMarca);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            PeR.ExibeMensagemPulandoLinha(
                                "Favor escolher uma das marca na lista a acima digitando o numero do codigo correspondente :"
                            );
                            Console.ResetColor();
                        }
                        else
                        {
                            codigoExiste = (listaDeMarca.Find(x => x.Codigo == valor) != null);
                            if (codigoExiste)
                            {
                                Marca codigoEcontrado = listaDeMarca.Find(x => x.Codigo == valor);

                                indice = listaDeMarca.IndexOf(codigoEcontrado);

                                marca = listaDeMarca[indice];
                            }
                        }
                    } while (!deuCerto);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                desejaCadastrarMarca = PeR.PerguntaChar(
                    $"O sistema ainda não possui uma marca cadastrada, deseja cadastrar a marca? (s) para sim e (n) para não. "
                );
                Console.ResetColor();
                if (desejaCadastrarMarca == 's')
                {
                    marca = marca.Cadastrar(listaDeMarca);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PeR.ExibeMensagemPulandoLinha(
                        "Não foi possivel continuar com o cadastro de Produto."
                    );
                    Console.ResetColor();
                    return;
                }
            }

            Usuario cadastrado = usuarioLogado;

            ListaDeProdutos.Add(
                new Produto(codigo, nomeProduto, preco, dataAtual, marca, cadastrado)
            );
        }

        public List<Produto> Listar(List<Produto> listaDeProduto, Marca marca)
        {
            if (listaDeProduto.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                PeR.ExibeMensagemPulandoLinha(
                    @"

---------------------------------------------------------------------------------------------
                                     Lista de Produtos
---------------------------------------------------------------------------------------------

"
                );
                int contador = 1;
                foreach (Produto produto in listaDeProduto)
                {
                    PeR.ExibeMensagemPulandoLinha(
                        @$"
{contador})
    Código : {produto.Codigo} 
    Nome: {produto.NomeProduto} 
    Preço: {produto.Preco:C} 
    Criado em : {produto.DataCadastro}
    Marca : {produto.Marca.NomeMarca}
    Cadastrado por : {produto.CadastradoPor.Nome}"
                    );
                    PeR.ExibeMensagem("\n");
                    if (contador > 1)
                    {
                        PeR.ExibeMensagemPulandoLinha(
                            "/*******************************************************************************************/\n"
                        );
                    }
                    contador++;
                }
                PeR.ExibeMensagemPulandoLinha(
                    "---------------------------------------------------------------------------------------------\n"
                );
            }
            Console.ResetColor();
            return ListaDeProdutos;
        }

        public string Deletar(List<Produto> listaDeProduto, Login login)
        {
            bool codigoExiste;
            char desejaDeletar;
            int indice;
            int codigoSelecionado = PeR.PerguntaInt(
                "Digite o codigo do produto que deseja deletar : "
            );
            codigoExiste = (listaDeProduto.Find(x => x.Codigo == codigoSelecionado) != null);
            if (codigoExiste)
            {
                Produto codigoEcontrado = listaDeProduto.Find(x => x.Codigo == codigoSelecionado);

                indice = listaDeProduto.IndexOf(codigoEcontrado);
                Console.ForegroundColor = ConsoleColor.Yellow;
                desejaDeletar = PeR.PerguntaChar(
                    @$"
---------------------------------------------------------------------------------------------

                        Deseja realmente deletar este produto:

Codigo : {listaDeProduto[indice].Codigo}
Produto : {listaDeProduto[indice].NomeProduto}
Preço : {listaDeProduto[indice].Preco:C}
Marca : {listaDeProduto[indice].Marca.NomeMarca}


                        Pressione (s) para sim ou (n) para não.

---------------------------------------------------------------------------------------------
                            
                            "
                );
                Console.ResetColor();
                if (desejaDeletar == 's')
                {
                    ListaDeProdutosExcluidos.Add(listaDeProduto[indice]);
                    listaDeProduto.RemoveAt(indice);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PeR.ExibeMensagemPulandoLinha(
                        $"\nOperação de deletar o Produto {listaDeProduto[indice].NomeProduto} foi cancelada com sucesso."
                    );
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                PeR.ExibeMensagemPulandoLinha($"\nCodigo informado não encontrado.");
                Console.ResetColor();
            }
            return "";
        }

        public void RelatorioProdutoExcluidos()
        {
            if (ListaDeProdutosExcluidos.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                PeR.ExibeMensagemPulandoLinha(
                    @"

---------------------------------------------------------------------------------------------
                                Lista de Usuarios Deletados
---------------------------------------------------------------------------------------------

"
                );
                int contador = 1;
                foreach (Produto objProduto in ListaDeProdutosExcluidos)
                {
                    PeR.ExibeMensagemPulandoLinha(
                        @$"
{contador}) Código : {objProduto.Codigo} - Nome: {objProduto.NomeProduto} - Preço: {objProduto.Preco:C} - Criado em : {objProduto.DataCadastro} - Marca : {objProduto.Marca.NomeMarca} - Cadastrado por : {objProduto.CadastradoPor.Nome}"
                    );
                    contador++;
                }
                PeR.ExibeMensagemPulandoLinha(
                    "---------------------------------------------------------------------------------------------\n"
                );
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                PeR.ExibeMensagemPulandoLinha("\nNão possui nenhum item excluido no sistema.\n");
                Console.ResetColor();
            }
        }

        public void ExibeMenuProduto(
            
            List<Marca> listaDeMarca,
            List<Produto> listaDeProduto,
            Login login,
            Usuario usuarioLogado
        )
        {
            Console.Clear();
            int opcaoMenuProduto;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                opcaoMenuProduto = PeR.PerguntaInt(
                    @$"
*************************
*                       *
*     Menu Produto      *
*                       *
*************************
*                       *
*    1) Cadastar        *
*                       *
*    2) Deletar         *
*                       *
*    3) Lista de        * 
*       Produtos        *
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

Opção:               "
                );
                Console.ResetColor();
                switch (opcaoMenuProduto)
                {
                    case 1:
                        Cadastrar(listaDeMarca, usuarioLogado);
                        break;
                    case 2:
                        Listar(listaDeProduto, marca);
                        Deletar(listaDeProduto, login);
                        break;
                    case 3:
                        Listar(listaDeProduto, marca);
                        break;
                    case 4:
                        RelatorioProdutoExcluidos();
                        break;
                    case 5:
                        Console.Clear();
                        login.Deslogar(login);
                        break;
                    case 6:
                        Console.Clear();
                        login.ExibeMenuPrincipal(usuarioLogado, login);
                        break;
                    case 7:
                        /*Para o sistema geral*/
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                
            } while (opcaoMenuProduto != 7);
        }
    }
}
