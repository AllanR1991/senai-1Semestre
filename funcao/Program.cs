/* Um método é um bloco de código que só é executado quando é chamado.

Você pode passar dados, conhecidos como parâmetros, para um método.

Os métodos são usados ​​para executar determinadas ações e também são conhecidos como funções .

Por que usar métodos? Para reutilizar o código: defina o código uma vez e use-o várias vezes.*/

/*
Paschal Case
camelCase
snake_case
*/

static float Somar(float n1, float n2){
    return n1+n2;
}

static float Subtracao(float n1, float n2){
    return n1-n2;
}

static float Multiplicacao(float n1, float n2){
    return n1*n2;
}

static float Divisao(float n1, float n2){
    return n1/n2;
}

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

static void ExibeMensagem(string texto){
    Console.WriteLine(texto);
}

float num1, num2;

num1 = PerguntaFloat($"Digite o primeiro número: ");
num2 = PerguntaFloat($"Digite o segundo número: ");

ExibeMensagem($"A soma do {num1} + {num2} = {Somar(num1,num2)}");
ExibeMensagem($"A subtração do {num1} - {num2} = {Subtracao(num1,num2)}");
ExibeMensagem($"A multiplicação do {num1} * {num2} = {Multiplicacao(num1,num2)}");
ExibeMensagem($"A divisão do {num1} / {num2} = {Divisao(num1,num2)}");
