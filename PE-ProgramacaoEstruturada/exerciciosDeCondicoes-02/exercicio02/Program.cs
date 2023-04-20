// 2) 

// Faça um programa que leia três números e mostre o maior e o menor deles.


float num1, num2,num3,numMaior, numMenor;

Console.WriteLine("Digite o 1º numero: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o 2º numero: ");
num2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o 3º numero: ");
num3 = float.Parse(Console.ReadLine());

if(num1>num2){
    numMaior=num1;
    if(num3>numMaior){
        numMaior=num3;
    }
}else{
    numMaior=num2;
    if(num3>numMaior){
        numMaior=num3;
    }
}

if(num1<num2){
    numMenor=num1;
    if(num3<numMenor){
        numMenor=num3;
    }
}else{
    numMenor=num2;
    if(num3<numMenor){
        numMenor=num3;
    }
}

Console.WriteLine($"Dentre os numeros inseridos o numero {numMaior} é o maior e o numero {numMenor} é o menor");