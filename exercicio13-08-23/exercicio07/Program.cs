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

/* 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
declarado. */

float[] numeros = new float[15];

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = PerguntaFloat($"Digite o {i+1}º número : ");
}

ExibeMensagemPulandoLinha($"Números digitados inversos: ");

for (int i = numeros.Length-1; i >= 0; i--)
{
    ExibeMensagemPulandoLinha($"{numeros[i]}");
}