using EventoMVC.Model;
using EventoMVC.View;

namespace EventoMVC.Controller
{
    public class EventoController
    {
        /*Instanciar tanto obj do Evento que esta na model quanto EventoView que esta na view.*/
        Evento objEvento = new Evento();

        EventoView objEventoView = new EventoView();

        public void ListarEventos()
        {
            List<Evento> listaDeEventos = objEvento.PreparaDadosParaListar();

            objEventoView.Exibe(listaDeEventos);
        }

        public void AcessaCadastrarEvento(){
            Evento objEventoCadastrado = objEventoView.Cadastrar();
            objEvento.Inserir(objEventoCadastrado);
        }
    }
}
