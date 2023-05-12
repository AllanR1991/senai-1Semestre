using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex01
{
    public static class PeR
    {
        public static string PerguntaString(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine();
        }

        public static char PerguntaChar(string pergunta)
        {
            Console.WriteLine(pergunta);
            return char.Parse(Console.ReadLine());
        }
        public static int PerguntaInt(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine());
        }

        public static float PerguntaFloat(string pergunta)
        {
            Console.WriteLine(pergunta);
            return float.Parse(Console.ReadLine());
        }

        public static void ExibeMensagemPulandoLinha(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void ExibeMensagem(string texto)
        {
            Console.Write(texto);
        }
    }
}