int posicao=0;

int[] idades = new int[5];
string[] nomes = new string[5];

for(int index = 0; index < nomes.Length;index++ ){
    Console.WriteLine($"\nDigite o {index+1}º nome : ");
    nomes[index] = Console.ReadLine();
    Console.WriteLine($"Srº(ª) {nomes[index]} o digite sua idade : ");
    idades[index] = int.Parse(Console.ReadLine());
}

foreach(string nome in nomes){
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\n {posicao+1}) nome: {nome}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"    idade: {idades[posicao]}");
    posicao++;
    Console.ResetColor();
}