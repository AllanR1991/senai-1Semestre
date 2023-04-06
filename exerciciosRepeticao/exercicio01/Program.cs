/* Sistema que verifica se o numero digitado esta entre 0 e 10 */


Console.WriteLine($"Insira com uma nota entre 0 e 10: ");
float num = float.Parse(Console.ReadLine());
while(num<0 || num > 10){
    Console.WriteLine($"numero inserido está errado, insira uma nota entre 0 e 10: ");
    num = float.Parse(Console.ReadLine());
}

