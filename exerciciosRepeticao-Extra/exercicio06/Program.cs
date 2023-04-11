/* Sistema que imprimi uma tabuada */


Console.WriteLine($"Tabuadas de 1 a 10: ): ");

for(int multiplicador=1; multiplicador<=10;multiplicador++){

    Console.WriteLine($"\n Tabuada do {multiplicador} \n");

    for(int multiplicando=0; multiplicando<=10;multiplicando++){
        Console.WriteLine($"{multiplicador} x {multiplicando} = {multiplicador*multiplicando}");
    }
}