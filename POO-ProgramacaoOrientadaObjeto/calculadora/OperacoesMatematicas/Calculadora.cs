namespace calculadora.OperacoesMatematicas
{
    public class Calculadora
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

        public float Soma(float n1, float n2)
        {
            return n1 + n2;
        }

        public float Subtracao(float n1, float n2)
        {
            return n1 - n2;
        }

        public float Multiplicacao(float n1, float n2)
        {
            return n1 * n2;
        }
        public float Divisao(float n1, float n2)
        {
            /*this.name - > this se refere a propria classe.*/
            return n1 / n2;
        }

    }
}