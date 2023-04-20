// 5) 

// Faça um programa que verifique se uma letra digitada é vogal ou consoante


char caracter;
const char vogalA='a' ,vogalE='e',vogalI='i',volgalO='o',vogalU='u';

Console.WriteLine($"Digite um caracter para verificação se o mesmo é uma vogal: ");
caracter = Char.Parse(Console.ReadLine().ToLower());

if(caracter == 'a'){
    Console.WriteLine($"O caracter {caracter} é uma vogal. ");
}else if(caracter == 'e'){
    Console.WriteLine($"O caracter {caracter} é uma vogal. ");
}else if(caracter =='i'){
    Console.WriteLine($"O caracter {caracter} é uma vogal. ");
}else if(caracter == 'o'){
    Console.WriteLine($"O caracter {caracter} é uma vogal. ");
}else if(caracter == 'u'){
    Console.WriteLine($"O caracter {caracter} é uma vogal. ");
}else{
    Console.WriteLine($"O caracter {caracter} não é uma vogal. ");
}
