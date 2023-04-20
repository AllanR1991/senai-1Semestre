//Vamos calcular uma calculadora com switch

Console.WriteLine(@$"
---------------------------------------------
|                                           |
|         Programa Calculadora              |
|   Informe a operaçao que deseja efetuar:  |
|     '+' somar.                            |
|     '-' subtração.                        |
|     '*' multiplicação.                    |
|     '/' divisão.                          |
|                                           |
---------------------------------------------
");


Console.WriteLine($"Digite a operaçao desejada, somente o simbolo: ");
char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"DIgite o primeiro numero: ");
float num1 = float.Parse(Console.ReadLine());
Console.WriteLine($"DIgite o segundo numero: ");
float num2 = float.Parse(Console.ReadLine());

switch (operacao){
    case '+':
        Console.WriteLine($"{num1} + {num2} = {num1+num2}" );
        break;
    case '-':
        Console.WriteLine($"{num1} - {num2} = {num1-num2}" );
        break;
    case '*':
        Console.WriteLine($"{num1} * {num2} = {num1*num2}" );
        break;
    case '/':
        Console.WriteLine($"{num1} / {num2} = {num1/num2}" );
        break; 
    default:
        Console.WriteLine("A opção escolhida não é valida.");
        break;
}



//Entrada

