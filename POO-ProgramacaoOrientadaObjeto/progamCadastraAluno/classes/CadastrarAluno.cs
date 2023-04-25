namespace progamCadastraAluno.classes
{
    public class CadastrarAluno
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
        public string nome;
        public string curso;

        public string idade;

        public string rg;

        public bool bolsista = false;

        public float mediaFinal;

        public float valorMensalidade;

        public void VerMediaFinal()
        {
            ExibeMensagemPulandoLinha(@$"A media final do {this.nome} é igual a : {this.mediaFinal}");
        }
        public void VerMensalidade()
        {
            if(bolsista && mediaFinal>=8 ){
                ExibeMensagemPulandoLinha(@$"O valor a pagar da mensalidade para o aluno {this.nome} é de 50% do valor {this.valorMensalidade}, totalizando em: {this.valorMensalidade*0.50}");
            }else if(bolsista && (mediaFinal>=6 && mediaFinal<8)){
                ExibeMensagemPulandoLinha(@$"O valor a pagar da mensalidade para o aluno {this.nome} é de 70% do valor {this.valorMensalidade}, totalizando em: {this.valorMensalidade*0.70}");
            }else{
                ExibeMensagemPulandoLinha(@$"O valor a pagar da mensalidade para o aluno {this.nome} é de 100% do valor {this.valorMensalidade}, totalizando em: {this.valorMensalidade}");
            }
        }
    }
}