string[] carros = new string[3];

for(int index = 0; index<3; index++){
    Console.WriteLine("Informe o nome de um carro");
    carros[index] = Console.ReadLine();
}

foreach (string conteudo in carros)
{
    Console.WriteLine($"O carro cadastrado foi : {conteudo}");
}