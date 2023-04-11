// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

char sexo;
int qtMulher=0, qtHomem=0, idadeHomem=0, idadeMulher=0,somaIdadeHomem=0, somaIdadeMulher=0;
float mediaIdadeHomem, mediaIdadeMulher, peso;

for(int pessoas = 1; pessoas<=3; pessoas++){
    Console.WriteLine($"Informe se você é mulher (m) ou homem (h): ");
    sexo = char.Parse(Console.ReadLine());
    if(sexo == 'h'){
        qtHomem++;
        Console.WriteLine($"Digite dua idade: ");
        idadeHomem = int.Parse(Console.ReadLine());
        somaIdadeHomem+=idadeHomem;
        Console.WriteLine($"Digite seu peso: ");
        peso = int.Parse(Console.ReadLine());
    }else{
        qtMulher++;
        Console.WriteLine($"Digite dua idade: ");
        idadeMulher = int.Parse(Console.ReadLine());
        somaIdadeMulher+=idadeMulher;
        Console.WriteLine($"Digite seu peso: ");
        peso = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine($"Total de Homens : {qtHomem}");
Console.WriteLine($"Total de Mulheres : {qtMulher}");
Console.WriteLine($"Média de idade dos homens: {somaIdadeHomem/qtHomem}");
Console.WriteLine($"Média de idade dos Mulheres: {somaIdadeMulher/qtMulher}");
