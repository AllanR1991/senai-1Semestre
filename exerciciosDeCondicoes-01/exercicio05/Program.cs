// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. 
//Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

string name;
int macas=0;
decimal preco=0m;

Console.WriteLine($"Favor inserir o nome: ");
name = Console.ReadLine();

Console.WriteLine($"Srº(ª) {name} quantas maças deseja comprar: ");
macas = int.Parse(Console.ReadLine());

if(macas>=12){
    preco = macas*0.25m;
    Console.WriteLine($"A quantidade de {macas} maçãs, tem um custo de total de R${Math.Round(preco,2)}");
}else{
    preco = macas*0.30m; 
    
    Console.WriteLine($"A quantidade de {macas} maçãs, tem um custo de total de R${Math.Round(preco,2)}");
}

