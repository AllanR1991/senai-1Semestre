// string name = "Allan Rodrigues dos Santos";

// Console.WriteLine(name);

// // int idade = 32;

// // string idade=35;
// const int idade = 40;
// Console.WriteLine("A idade do "+name+" é "+idade+" anos.");

// //nota1

// /* 
// como declara
// float = 5.98F
// double = 4.98D*/

// int nota1 = 5, nota2 = 5, nota3 = 5;
// float  media;

// media = (nota1 + nota2 + nota3)/3;

// Console.WriteLine(media);

// /* Operadores */

// //atribuiçao

// int x = 15;

// //operadores aritméticos
// //soma
// Console.WriteLine(5+4);
// Console.WriteLine(5+x);
// Console.WriteLine(5+"4");
// //subtraçao
// Console.WriteLine(15-3);
// //multiplicação
// Console.WriteLine(5*5);
// //divisão
// Console.WriteLine(10/10);
// //modulo
// Console.WriteLine(5%2);

// //Operadores de comparação

// //igual a
// Console.WriteLine(5==5);
// //maior ou igual a
// Console.WriteLine(5>=4);
// Console.WriteLine(5>=10);
// //menor ou igual a\
// Console.WriteLine(4<=2);
// Console.WriteLine(4<=10);
// //maior que
// Console.WriteLine(150>95);
// //menor que 
// Console.WriteLine(54<25);
// //diferente de
// Console.WriteLine(5!=4);

//Programa para calcular o IMC de uma pessoa

string nome = "Allan Rodrigues dos Santos";
int idade = 31;
float peso = 90.00f, altura = 1.90f, imc;

imc = peso/(altura*altura);
/*
Math.Round(imc,2), para arredondar o numero para 2 casas decimais.
*/
Console.WriteLine("O IMC do(a) "+nome+" é de :"+ Math.Round(imc,2));
