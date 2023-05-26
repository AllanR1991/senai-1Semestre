
using EventoMVC.Model;

namespace EventoMVC.View
{
    public class EventoView
    {
        public void Exibe(List<Evento> listaDeEventos){
            Console.Clear();
            int qtdEvento = 1;
            foreach (var evento in listaDeEventos)
            {
                PeR.ExibeMensagemPulandoLinha($"Evento {qtdEvento}\n");

                PeR.ExibeMensagemPulandoLinha($"Nome: {evento.Nome}");
                PeR.ExibeMensagemPulandoLinha($"Descrição do evento: {evento.Descricao}");
                PeR.ExibeMensagemPulandoLinha($"Data do Evento: {evento.DataEvento.ToString("dd/MM/yyyy")}\n");
                qtdEvento++;
            }            
        }

        public Evento Cadastrar()
        {
            Evento novoObjEvento = new Evento();
            novoObjEvento.Nome = PeR.PerguntaString("Digite o nome do Evento : ");
            novoObjEvento.Descricao = PeR.PerguntaString("Digite a descrição do Evento : ");
            novoObjEvento.DataEvento = PeR.PerguntaData("Digite a data do evento : ");
            return novoObjEvento;
        }

        public void MenuPrincipal()
        {
            int opcao;
            do
            {
                opcao = PeR.PerguntaInt(@$"
*************************
*                       *
*     Menu Principal    *
*                       *
*************************
*                       *
*    1) Cadastrar       *
*                       *
*    2) Listar          *
*                       *
*    3) Deletar         *
*                       *
*    4) Listar          *
*                       *
*************************

                ");
            } while (opcao != 6);
        }
    }
}