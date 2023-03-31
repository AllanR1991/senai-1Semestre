// 4) Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:


// "Telefonou para a vítima?"


// "Esteve no local do crime?"


// "Mora perto da vítima?"


// "Devia para a vítima?"


// "Já trabalhou com a vítima?"



// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.


int nivelDeCulpa=0;
string telefonouParaVitima, esteveNolocal, pertoDaVitima, deviaParaVitima, trabalhouComAVitima;

Console.WriteLine(@$"

-------------------------------------
|                                   |
|   Sitema para Investigação        |
|          De um crime              |
|                                   |
-------------------------------------

");

Console.WriteLine("Favor responder sim ou não para cada pergunta a seguir: ");

Console.WriteLine("Telefonou para a vitima?");
telefonouParaVitima = Console.ReadLine().ToLower();

Console.WriteLine("Esteve no local do crime");
esteveNolocal = Console.ReadLine().ToLower();

Console.WriteLine("Mora perto da vítima?");
pertoDaVitima = Console.ReadLine().ToLower();

Console.WriteLine("Devia para a vítima?");
deviaParaVitima = Console.ReadLine().ToLower();

Console.WriteLine("Já trabalhou com a vítima?");
trabalhouComAVitima = Console.ReadLine().ToLower();

if(telefonouParaVitima=="sim"){
    nivelDeCulpa++;
}
if(esteveNolocal=="sim"){
    nivelDeCulpa++;
}
if(pertoDaVitima=="sim"){
    nivelDeCulpa++;
}
if(deviaParaVitima=="sim"){
    nivelDeCulpa++;
}
if(trabalhouComAVitima=="sim"){
    nivelDeCulpa++;
}

if(nivelDeCulpa>4){
    Console.WriteLine("Você é culapado, pelo crime, você está preso.");
}else if(nivelDeCulpa >= 3 && nivelDeCulpa<=4){
    Console.WriteLine("Você é cúmplice do crime.");
}else if(nivelDeCulpa == 2){
    Console.WriteLine("Você é suspeito do crime.");
}else{
    Console.WriteLine("Você é inocente do crime, esta livre");
}
