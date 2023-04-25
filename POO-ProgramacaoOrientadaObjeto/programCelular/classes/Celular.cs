

namespace programCelular.classes
{
    public class Celular
    {
        static string PerguntaString(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine();
        }

        static char PerguntaChar(string pergunta)
        {
            Console.WriteLine(pergunta);
            return char.Parse(Console.ReadLine());
        }

        static int PerguntaInt(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine());
        }

        static float PerguntaFloat(string pergunta)
        {
            Console.WriteLine(pergunta);
            return float.Parse(Console.ReadLine());
        }

        static void ExibeMensagemPulandoLinha(string texto)
        {
            Console.WriteLine(texto);
        }

        static void ExibeMensagem(string texto)
        {
            Console.Write(texto);
        }

        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {
            ExibeMensagem(texto);
            for (int i = 0; i <= quantidadePontinhos; i++)
            {
                ExibeMensagem(".");
                Thread.Sleep(tempo);
            }
        }
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;

        public void Ligar()
        {
            ExibeMensagemPulandoLinha
        }

        public Desligar()
        {

        }

        public FazerLigacao()
        {

        }

        public EnviarMensagem()
        {

        }
    }
}