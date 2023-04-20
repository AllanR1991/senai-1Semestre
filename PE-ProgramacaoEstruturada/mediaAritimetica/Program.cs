float nota1, nota2, nota3, nota4, nota5, media;



Console.WriteLine(@$"
----------------------------------
|                                |
|                                |
|     Média Aritimética          |
|                                |
|                                |
----------------------------------
");

Console.WriteLine($"Digite a 1ª nota: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a 2ª nota: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a 3ª nota: ");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a 4ª nota: ");
nota4 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a 5ª nota: ");
nota5 = float.Parse(Console.ReadLine());

media = (nota1+nota2+nota3+nota4+nota5)/5;

Console.WriteLine($"A média aritimetica é: {media}");