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
        public List<Marca> listaDeMarca = new List<Marca>();
        List<Marca> listaDeMarcaExcluidas = new List<Marca>();
        
        /* Marca marca = new Marca(); */

        public Marca() { }

        public Marca(int _codigo, string _nomeMarca, DateTime _dataCadastro)
        {
            this.Codigo = _codigo;
            this.NomeMarca = _nomeMarca;
            this.DataCadastro = _dataCadastro;
        }

        public Marca Cadastrar(List<Marca> listaDeMarca)
        {
            Marca objMarca = new Marca();

            objMarca.Codigo = PeR.PerguntaInt("\nInforme o código da Marca :");
            objMarca.NomeMarca = PeR.PerguntaString("Informe o nome da Marca :");
            objMarca.DataCadastro = DateTime.Now;

            PeR.ExibeMensagem("\n");

            listaDeMarca.Add(objMarca);
            return objMarca;
        }

        public void Listar(List<Marca> listaDeMarca)
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
                "Digite o codigo da marca que deseja deletar : "
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

        public void RelatorioMarcaExcluidas(){
            if (listaDeMarcaExcluidas.Count > 0)
            {
                PeR.ExibeMensagemPulandoLinha(
                    @"

---------------------------------------------------------------------------------------------
                                Lista de Usuarios Deletados
---------------------------------------------------------------------------------------------

"
                );
                int contador = 1;
                foreach (Marca objMarca in listaDeMarcaExcluidas)
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
                PeR.ExibeMensagemPulandoLinha("\nNão possui nenhum item excluido no sistema.\n");
            }
        }

        public void ExibeMenuMarca(List<Marca> listaDeMarca,Marca objMarca,Login login, Usuario usuarioLogado) { 
            int opcaoMenuMarca;
            
            do
            {
                opcaoMenuMarca = PeR.PerguntaInt(
                    @$"
                    
*************************
*                       *
*      Menu Marca       *
*                       *
*************************
*                       *
*    1) Cadastar        *
*                       *
*    2) Deletar         *
*                       *
*    3) Lista de        * 
*       Marcas          *
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
                switch (opcaoMenuMarca)
                {
                    case 1:
                        Cadastrar(listaDeMarca);
                        break;
                    case 2:
                        Listar(listaDeMarca);
                        Deletar(listaDeMarca,login);
                        break;
                    case 3:
                        Listar(listaDeMarca);
                        break;
                    case 4:
                        RelatorioMarcaExcluidas();
                        break;
                    case 5:
                        login.Deslogar(login);
                        break;
                    case 6:
                        login.ExibeMenuPrincipal(usuarioLogado,login);
                        break;
                    case 7:
                        /*Para o sistema geral*/
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (opcaoMenuMarca != 7);
        }
    }
}
