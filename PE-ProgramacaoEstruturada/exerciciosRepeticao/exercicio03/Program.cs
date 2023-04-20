/* Sistema que imprimi uma tabuada */


Console.WriteLine($"Insira um numero para obter a tabuada de 1 a 10: ): ");
int num = int.Parse(Console.ReadLine());

for(int i=0; i<=10;i++){
    Console.WriteLine($"{num} x {i} = {num*i}");
}