namespace EventoMVC
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
            bool inputErrado;
            char valor = ' ';
            Console.WriteLine(pergunta);
            do{
                inputErrado =false;
                try
                {
                   valor = char.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    ExibeMensagemPulandoLinha("\nValor inserido é invalido.\n");   
                    inputErrado = true;
                }
            }while(inputErrado);
            
            return valor;
            
        }
        public static int PerguntaInt(string pergunta)
        {
            
            bool inputErrado;
            int valor = 0;
            Console.WriteLine(pergunta);
            do{
                inputErrado =false;
                try
                {
                   valor = int.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    ExibeMensagemPulandoLinha("\nValor inserido é invalido.\n");   
                    inputErrado = true;
                }
            }while(inputErrado);
            return valor;
        }

        public static float PerguntaFloat(string pergunta)
        {
            bool inputErrado;
            float valor = 0.0f;
            Console.WriteLine(pergunta);
            do{
                inputErrado =false;
                try
                {
                   valor = float.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    ExibeMensagemPulandoLinha("\nValor inserido é invalido.\n");   
                    inputErrado = true;
                }
            }while(inputErrado);
            return valor;
        }

        public static double PerguntaDouble(string pergunta)
        {
            bool inputErrado;
            double valor = 0.0d;
            Console.WriteLine(pergunta);
            do{
                inputErrado =false;
                try
                {
                   valor = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    ExibeMensagemPulandoLinha("\nValor inserido é invalido.\n");   
                    inputErrado = true;
                }
            }while(inputErrado);
            return valor;
        }

        public static void ExibeMensagemPulandoLinha(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void ExibeMensagem(string texto)
        {
            Console.Write(texto);
        }


        public static DateTime PerguntaData(string pergunta)
        {
            bool inputErrado;
            DateTime valor = DateTime.Now ;
            Console.WriteLine(pergunta);
            do{
                inputErrado =false;
                try
                {
                   valor = DateTime.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    ExibeMensagemPulandoLinha("\nValor inserido é invalido.\n");   
                    inputErrado = true;
                }
            }while(inputErrado);
            
            return valor;
            
        }
    }
}