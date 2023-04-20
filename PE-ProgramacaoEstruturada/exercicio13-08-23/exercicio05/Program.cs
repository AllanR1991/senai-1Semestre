static string PerguntaString(string pergunta){
    Console.WriteLine(pergunta);
    return Console.ReadLine();
}

static char PerguntaChar(string pergunta){
    Console.WriteLine(pergunta);
    return char.Parse(Console.ReadLine());
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


ExibeMensagem(@$"
--------------------------
|                        |
|       Tabuada          |
|      do 1 ao 10        |
--------------------------");

for(int multiplicando = 1; multiplicando<=10;multiplicando++){
    ExibeMensagem(@$"
Tabuada do {multiplicando} : 

");
    for(int multiplicador = 1; multiplicador<=10;multiplicador++){
        ExibeMensagemPulandoLinha($"{multiplicando} x {multiplicador} = {multiplicando * multiplicador}");
    }
}