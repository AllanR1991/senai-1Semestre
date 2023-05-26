

namespace EventoMVC.Model
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public DateTime DataEvento { get; set; }       

        /*Caminho da Pasta e arquivo a serem criados.*/
        private const string PATH = "BancoDeDados/Evento.csv";

        public Evento()
        {
            /*Divide a path no (/) e pega a primeira parte da divisão e armazena no conteudo pasta.*/
            string pasta = PATH.Split('/')[0];

            /*Verifica se existe uma pasta criada com esse com esse nome se não tiver criar, ele cria uma*/
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            /*Verifica se existe um arquivo criado dentro da pasta se não tiver criado , ele cria.*/
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
        }
        
        public List<Evento> PreparaDadosParaListar(){
            /*Criamos uma lista de Evento*/
            List<Evento> listaDeEvento = new List<Evento>();
            /*Criamos um array contendo todos os Registros do arquivo Evento.csv*/
            string [] registros = File.ReadAllLines(PATH);

            foreach(string registro in registros){
                /*Pegamos um registo arquivo Evento.cvs e separamos os dados para podermos armazenalos separadamente.*/
                string[] atributos = registro.Split(';');

                Evento capturaEvento = new Evento();

                capturaEvento.Nome = atributos[0];
                capturaEvento.Descricao = atributos[1];
                capturaEvento.DataEvento = DateTime.Parse(atributos[2]);

                listaDeEvento.Add(capturaEvento);
            }
            return listaDeEvento;
        } 

        public string PreparaDadosParaBancoDeDados(Evento ojbEvento){
            return $"{ojbEvento.Nome};{ojbEvento.Descricao};{ojbEvento.DataEvento}";
        }

        public void Inserir(Evento objEvento){
            string[] registro = {PreparaDadosParaBancoDeDados(objEvento)};

            File.AppendAllLines(PATH,registro);
        }
    }
}