

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
            BarraCarregamento("\nCarregando",10,500);
        }

        public void Desligar()
        {
            BarraCarregamento("\nDesligando",10,250);
        }

        public void FazerLigacao()
        {
            PerguntaString("Digite o número : ");
            BarraCarregamento("Ligando",10,250);
        }

        public void EnviarMensagem()
        {
            string mesnsagem = PerguntaString("Digite a mensagem a enviar");
            if(mesnsagem!=""){
                BarraCarregamento("\nEnviando mensagem",10,250);
            }
            
        }
    }
}