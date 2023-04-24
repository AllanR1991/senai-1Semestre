using calculadora.OperacoesMatematicas;

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

string opcao;
float n1,n2;

Calculadora calculadora = new Calculadora();

do{

opcao = PerguntaString(@"
Escolha uma das opções abaixo no menu:

(1) - Soma
(2) - Subtrair
(3) - Multiplicar
(4) - Dividir
(0) - Sair

");

n1 = PerguntaFloat("Digite o primeiro numero :");
n2 = PerguntaFloat("Digite o segundo numero :");

switch(opcao){
    case "1":
        ExibeMensagemPulandoLinha($"\nO resultado da soma de {n1} + {n2} = {calculadora.Soma(n1,n2)}");
        break;
    case "2":
        ExibeMensagemPulandoLinha($"\nO resultado da subtração de {n1} - {n2} = {calculadora.Subtracao(n1,n2)}");
        break;
    case "3":
        ExibeMensagemPulandoLinha($"\nO resultado da multiplicação de {n1} * {n2} = {calculadora.Multiplicacao(n1,n2)}");
        break;
    case "4":
        if(n2==0){
            ExibeMensagemPulandoLinha($"\nNenhum valor pode ser divido por 0, tente novamente.");
        }else{
            ExibeMensagemPulandoLinha($"\nO resultado da multiplicação de {n1} / {n2} = {calculadora.Divisao(n1,n2)}");
        }
        break;
    case "0":
        ExibeMensagemPulandoLinha("\nObrigado por utilizar a calculadora e até logo...");
        break;
    default:
        ExibeMensagemPulandoLinha("\nNenhuma opção selecionada, tente novamente.");
        break;
}
}while(opcao!="0");