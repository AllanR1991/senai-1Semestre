int idade, meses, dias, horas, minutos;
string nome;

Console.WriteLine($"Digite seu nome: ");
nome = Console.ReadLine();
Console.WriteLine($"Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

meses = idade*12;
dias = idade*365;
horas = dias*24;
minutos = horas*60;

Console.Write($"{nome} sua idade de {idade} equivale a: {meses} meses, {dias} dias, {horas} horas, {minutos} minutos");
