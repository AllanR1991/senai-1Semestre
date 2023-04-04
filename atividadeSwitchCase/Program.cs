// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.
string gelo, bebida="";
int escolha = 0; 

Console.WriteLine(@$"

---------------------------------
|                               |
|                               |
|    Programa de escolha        |
|        de Bebida.             |
|                               |
|                               |
|                               |
---------------------------------

");

Console.WriteLine(@$"
Escolha uma das bebidas abaixo digitando apenas o numero ferente a bebida: 

1 - Água.
2 - Água com gás.
3 - Refigerante.
4 - Cerveja.
5 - Vinho.
");

escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case (1):
        Console.WriteLine("\nA opcáo escolhida foi Água.");
        bebida = "água";
        break;
    case (2):
        Console.WriteLine("\nA opcáo escolhida foi Agua com Água com gás.");
        bebida = "água com gás";
        break;
    case (3):
        Console.WriteLine("\nA opcáo escolhida foi Refigerante.");
        bebida = "refigerante";
        break;
    case (4):
        Console.WriteLine("\nA opcáo escolhida foi Cerveja.");
        bebida = "cerveja";
        break;
    case (5):
        Console.WriteLine("\nA opcáo escolhida foi Vinho.");
        bebida = "vinho";
        break;
    default:
        Console.WriteLine("\nOpção escolhida é invalida. ");
        break;
}

Console.WriteLine($"\nDeseja acresentar gelo em sua {bebida}: sim ou nao");
    gelo = Console.ReadLine().ToLower();

    if(gelo == "sim"){
        Console.WriteLine($"\nAcresentado gelo na(o) {bebida}.");
    }else{
        Console.WriteLine($"\n{bebida} sem adicional de gelo.");
    }