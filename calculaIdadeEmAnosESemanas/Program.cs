float semanas, qtSemanaAno;
int anoNascimento,anoAtual,anos;
const float diasAno=365f, diasSemana=7f;


Console.WriteLine(@$"
----------------------------------
|                                |
|     Sotware para calcular      |
|    Idade em Anos e semanas     |
|                                |
----------------------------------
");

anoAtual = int.Parse(DateTime.UtcNow.ToString("yyyy"));


Console.WriteLine($"Digite o ano em que nasceu ");
anoNascimento = int.Parse(Console.ReadLine());

anos = anoAtual - anoNascimento;
qtSemanaAno = diasAno/diasSemana;
semanas = (qtSemanaAno*anos);

Console.WriteLine($"Você tem {anos} anos, que convertidos em semanas fica {Math.Round(semanas,2)} semanas.");