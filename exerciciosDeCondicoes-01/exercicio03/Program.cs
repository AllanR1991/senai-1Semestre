// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

float ladoA, ladoB, ladoC;

Console.WriteLine("Sistema para verificar se um triangulo é equilátero, isósceles ou escaleno.");

Console.WriteLine("Informe o lado A de um triangulo: ");
ladoA = float.Parse(Console.ReadLine());
Console.WriteLine("Informe o lado B de um triangulo: ");
ladoB = float.Parse(Console.ReadLine());
Console.WriteLine("Informe o lado C de um triangulo: ");
ladoC = float.Parse(Console.ReadLine());

if((ladoA == ladoB) && (ladoB== ladoC)){
    Console.WriteLine($"O triangulo é um triangulo equilátero pois os tres lados são iguais: ladoA = {ladoA}, ladoB = {ladoB}, ladoC = {ladoC}.");
}else if((ladoA == ladoB)||(ladoA == ladoC)||(ladoB==ladoC)){
    Console.WriteLine($"O triangulo é um triangulo isóceles pois pelo menos 2 lados são iguais: ladoA = {ladoA}, ladoB = {ladoB}, ladoC = {ladoC}.");
}else{
    Console.WriteLine($"O triangulo é um triangulo Escaleno pois todos os lados diferentes: ladoA = {ladoA}, ladoB = {ladoB}, ladoC = {ladoC}.");
}

