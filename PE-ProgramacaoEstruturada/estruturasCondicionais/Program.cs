bool sol = false;

// if(Condicao)
// {
//     //acao
// }


/* Estrutura de Condicional Simples */

if (sol)
{
    Console.WriteLine($"Vou para praia.");
}

/* Estrutura de Condicional Composta */

if (sol)
{
    Console.WriteLine($"Vou para praia.");
}
else
{
    Console.WriteLine($"Não vou para praia.");
}

int x = 2, y = 3;

if (x == y)
{
    Console.WriteLine($"Sáo iguais.");
}
else
{
    Console.WriteLine($"São diferentes.");
}

/* Forma diferente de se fazer condicao composta */
// ? -> é verdade
// Se sim : Se não -> o dois pontos faz sim ou se não
string eIgual = (x == y) ? "São iguais" : "São diferentes";
Console.WriteLine(eIgual);

int idade = 0;
bool responsavel = true;

if (idade > 18)
{
    Console.WriteLine($"Pode entrar na festa.");
}
else if (idade>16 && idade<18 && responsavel)
{
    Console.WriteLine($"Pode entrar na festa.");
}
else
{
    Console.WriteLine($"Não pode entrar na festa.");
}