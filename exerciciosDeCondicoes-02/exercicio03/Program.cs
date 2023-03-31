// 3)

// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

float raio, diametro, comprimento;


Console.WriteLine(@$"
    -------------------------
    |                       |
    |    Programa para      |
    |  Calcular o Diametro  |
    |  e o comprimento de   |
    |  uma circunferencia.  |
    |                       |
    -------------------------
");

Console.WriteLine($"Informe o raio da circunferencia: ");
raio = float.Parse(Console.ReadLine());

diametro = raio*2f;
comprimento = 2f * (float)Math.PI * raio;

Console.WriteLine($"O diametro da circunferencia sendo raio {raio} é \"{Math.Round(diametro,2)}\" e o comprimento da circunferencia é \"{Math.Round(comprimento,2)}\" ");


