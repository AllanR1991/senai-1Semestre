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

int[] numeros = new numeros[10];

for(int index = 0; index<numeros.Length;index++ ){
    numeros[index] = PerguntaFloat()
}
/*Declaraçao de variavel*/
int kmAtual, kmPercorrido, kmTotal;


/* inicializaçao de uma variavel */
kmAtual=400;
kmPercorrido = PerguntaInt("Digite o quando percorreu: ");

/* processamento */
kmTotal = kmAtual + kmPercorrido;

/* saida */
ExibeMensagem("{kmTotal}");