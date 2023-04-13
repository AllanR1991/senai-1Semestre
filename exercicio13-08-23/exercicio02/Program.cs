/* 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
Álcool:

. até 20 litros, desconto de 3% por litro Álcool
. acima de 20 litros, desconto de 5% por litro
Gasolina:
. até 20 litros, desconto de 4% por litro Gasolina
. acima de 20 litros, desconto de 6% por litro

Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
Dica: utilize switch case e funções/métodos para otimizar o algorítimo. */

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

char tipoCombustivel;
float qtdLitro;

static float CalculaDesconsto(char tipoCombustivel, float qtdLitro){
    float desconto=0,valorGasolina=5.30f,valorEtanol=4.90f;


    switch (tipoCombustivel)
    {
        case 'g':
            if(qtdLitro>20){
                desconto = (qtdLitro*valorGasolina)*0.94f;
            }else{
                desconto = (qtdLitro*valorGasolina)*0.96f;
            }
            break;
        case 'a':
            if(qtdLitro>20){
                desconto = (qtdLitro*valorEtanol)*0.95f;
            }else{
                desconto = (qtdLitro*valorEtanol)*0.97f;
            }
            break;
        default:
            ExibeMensagem($"Não foi selecionado um tipo de combustivel valido.");
            break;
    }
    return desconto;
}

qtdLitro = PerguntaFloat($"Digite a quantidade de combustivel que deseja armazenar : ");
tipoCombustivel = PerguntaChar($"Digite o tipo de combustivel (G)Gasolina e (A)Alcool : ");

ExibeMensagem($"O valor a ser pago é : " + CalculaDesconsto(tipoCombustivel,qtdLitro));