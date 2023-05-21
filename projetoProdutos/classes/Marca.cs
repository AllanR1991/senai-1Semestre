using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoProdutos.classes
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Marca> listaDeMarca = new List<Marca>();
        List<Marca> listaDeMarcaExcluidas = new List<Marca>();
        
        /* Marca marca = new Marca(); */

        public Marca() { }

        public Marca(int _codigo, string _nomeMarca, DateTime _dataCadastro)
        {
            this.Codigo = _codigo;
            this.NomeMarca = _nomeMarca;
            this.DataCadastro = _dataCadastro;
        }

        public void Cadastrar(Marca objMarca)
        {
            int codigo = PeR.PerguntaInt("Informe o código da Marca :");
            string marca = PeR.PerguntaString("Informe o nome da Marca :");
            DateTime dataAtual = DateTime.Now;

            PeR.ExibeMensagem("\n");

            listaDeMarca.Add(new Marca(codigo, marca, dataAtual));
        }

        public void Listar()
        {
            if (listaDeMarca.Count > 0)
            {
                PeR.ExibeMensagemPulandoLinha(
                    @"

---------------------------------------------------------------------------------------------
                                     Lista de Marca
---------------------------------------------------------------------------------------------

"
                );
                int contador = 1;
                foreach (Marca objMarca in listaDeMarca)
                {
                    PeR.ExibeMensagemPulandoLinha(
                        $"{contador} Código : {objMarca.Codigo} - Marca: {objMarca.NomeMarca}"
                    );
                    contador++;
                }
                PeR.ExibeMensagemPulandoLinha(
                    "---------------------------------------------------------------------------------------------\n"
                );
            }else{
                PeR.ExibeMensagemPulandoLinha("Não há nenhum item cadastrado.");
            }
        }

        public void Deletar(List<Marca> listaDeMarca, Login login)
        {
            bool codigoExiste;
            char desejaDeletar;
            int indice;
            int codigoSelecionado = PeR.PerguntaInt(
                "Digite o codigo do usuario que deseja deletar : "
            );
            codigoExiste = (listaDeMarca.Find(x => x.Codigo == codigoSelecionado) != null);
            if (codigoExiste)
            {
                Marca codigoEcontrado = listaDeMarca.Find(x => x.Codigo == codigoSelecionado);

                indice = listaDeMarca.IndexOf(codigoEcontrado);

                desejaDeletar = PeR.PerguntaChar(
                    @$"
---------------------------------------------------------------------------------------------

                        Deseja realmente deletar este produto:

Codigo : {listaDeMarca[indice].Codigo}
Produto : {listaDeMarca[indice].NomeMarca}


                        Pressione (s) para sim ou (n) para não.

---------------------------------------------------------------------------------------------
                            
                            "
                );

                if (desejaDeletar == 's')
                {
                    listaDeMarcaExcluidas.Add(listaDeMarca[indice]);
                    listaDeMarca.RemoveAt(indice);
                }
                else
                {
                    PeR.ExibeMensagemPulandoLinha(
                        $"\nOperação de deletar o Usuario {listaDeMarca[indice].NomeMarca} foi cancelada com sucesso."
                    );
                }
            }
            else
            {
                PeR.ExibeMensagemPulandoLinha($"\nCodigo informado não encontrado.");
            }
        }

        public void ExibeMenuMarca(Marca objMarca,Login login) { 
            int opcaoMenuUsuario;
            
            do
            {
                opcaoMenuUsuario = PeR.PerguntaInt(
                    @$"
*************************
*                       *
*     Menu Produto      *
*                       *
*************************
*                       *
*    1) Cadastar        *
*    2) Deletar         *
*    3) Relatorio de    *
*       exclusão        *
*    4) Deslogar        *
*    5) Voltar ao Menu  *
*       Principal       *
*    6) Fechar o        *
*       sistema         *
*                       *
*************************   
                "
                );
                switch (opcaoMenuUsuario)
                {
                    case 1:
                        Cadastrar(objMarca);
                        break;
                    case 2:
                        Listar();
                        Deletar(listaDeMarca,login);
                        break;
                    case 3:
                        /* RelatorioUsuariosExcluidos(); */
                        break;
                    case 4:
                        /* login.Deslogar(login); */
                        break;
                    case 5:
                        /* login.ExibeMenuPrincipal(login); */
                        break;
                    case 6:
                        /*Para o sistema geral*/
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (opcaoMenuUsuario != 6);
        }
    }
}
