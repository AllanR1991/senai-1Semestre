/* Sistema que verifica se senha é igual a nome */


Console.WriteLine($"Insira seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Insira uma senha (*Deve ser difente do nome): ");
string senha = Console.ReadLine();

while(senha==nome){
    Console.WriteLine($"Senha digitada é invalida, favor insira uma senha: (*Deve ser difente do nome): ");
    senha = Console.ReadLine();
}