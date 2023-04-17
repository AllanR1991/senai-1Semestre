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

/* 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
menor valor lido. */

/* Declaraçao de variavel */
float[] numeros = new float[10];
float numMenor=0f,numMaior=0f;
/* Entrada de Dados */
for(int index = 0; index<numeros.Length;index++ ){
    numeros[index] = PerguntaFloat($"Digite o {index}º numero : ");
    if(numeros[index]>numMaior){
        numMaior=numeros[index];
    }
}
numMenor = numMaior;
for(int index = 0; index<numeros.Length;index++ ){
    
    ExibeMensagem($"valor num Menor antes do IF {numMenor}");
    if(numeros[index]<numMenor){
        numMenor = numeros[index];
    }
}

ExibeMensagem($"O maior numero digitado foi : {numMaior}");
ExibeMensagem($"O menor numero digitado foi : {numMenor}");
