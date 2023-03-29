string nome = "Allan Rodrigues dos Santos";
float peso = 90.00f, imc;
double altura = 1.90f;

// Console.BackgroundColor = ConsoleColor.DarkGreen;



Console.WriteLine(@$"
-------------------------------
|                             |
|    Programa para IMC        |                               
|                             |
-------------------------------
");

Console.WriteLine($"Digite o nome do paciente");
nome = Console.ReadLine(); /*Captura dados do teclado.*/


Console.Write($"Digite o peso do paciente");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"*(Para numero decimais utilizar \",\")");
Console.ResetColor();
peso = float.Parse(Console.ReadLine()); /*para converter é necessario utilizar o tipo da variavel mais a função parse.*/
Console.Write($"Digite a altura do paciente ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"*(Para numero decimais utilizar \",\")");
Console.ResetColor();
altura = double.Parse(Console.ReadLine()); 

// imc = peso/((float)Math.Pow(altura,2)*100);

imc = peso/((float)(altura*altura)); 

/*
Math.Round(imc,2), para arredondar o numero para 2 casas decimais.
*/
Console.WriteLine($"O IMC do(a) {nome}é de :{Math.Round(imc,2)}");

/*
************************************************************************
Para encerrar o aplicativo no console (CTRL + C).
No terminal C# não se usa ponto para casa decimal.
************************************************************************

*/