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

/* Carregando............. */

static void BarraCarregamento(string texto, int quantidadePontinhos,int tempo){
    ExibeMensagem(texto);
    for (int i = 0; i <= quantidadePontinhos; i++){
        ExibeMensagem(".");
        Thread.Sleep(tempo);
    }
}

BarraCarregamento("Carregando",10,1000);