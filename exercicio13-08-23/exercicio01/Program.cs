static string PerguntaString(string pergunta){
    Console.WriteLine(pergunta);
    return Console.ReadLine();
}

static int PerguntaInt(string pergunta){
    Console.WriteLine(pergunta);
    return int.Parse(Console.ReadLine());
}

static float PerguntaFloat(string pergunta){
    Console.WriteLine(pergunta);
    return float.Parse(Console.ReadLine());
}

static void ExibeMensagemPulandoLinha(string texto){
    Console.WriteLine(texto);
}

static void ExibeMensagem(string texto){
    Console.Write(texto);
}

int anoNascimento = 0, anoAtual=0;
string anoAtualString;
/* PerguntaInt("\nDigite o ano atual: "); */
anoAtualString = DateTime.Now.ToString("yyyy");
anoNascimento = PerguntaInt("Digite o ano em que nasceu : ");
anoAtual = int.Parse(anoAtualString);

if((anoAtual-anoNascimento)>=18){
    ExibeMensagem("\nVocê pode votar este ano.");
}else{
    ExibeMensagem("\nVocê não pode votar este ano. Pois ainda não atingiu a idade minima.");
}