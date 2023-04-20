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

/* 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário. */

string[] nomes = new string [10];
string buscaNome;
int contador = 1;

for (int i = 0; i < nomes.Length; i++)
{
    nomes[i] = PerguntaString($"Digite o {i+1}º nome : ");
}

buscaNome = PerguntaString($"Digite um nome para verificar se tem na lista : ");

foreach (var nome in nomes)
{
    if(nome == buscaNome){
        ExibeMensagem($"O nome {buscaNome} foi encontrado.");
        break;
    }else if(contador == nomes.Length){
        ExibeMensagem($"O nome {buscaNome} não foi encontrado.");
    }
    contador++;
}