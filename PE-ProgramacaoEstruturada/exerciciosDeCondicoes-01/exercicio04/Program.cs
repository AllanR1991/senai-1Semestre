// 4)Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
// A     senha     válida     é     o     número     1234. 
// Devem     ser    impressas     as    seguintes     mensagens:
// ACESSO    PERMITIDO    caso    a    senha    seja    válida.
// ACESSO    NEGADO    caso    a    senha    seja    inválida.

string name, senhaDigitada, senhaValida = "1234";

Console.WriteLine($"Favor inserir o nome de ususario: ");
name = Console.ReadLine();

Console.WriteLine($"{name} favor inserir a senha para acessar o sistema: ");
senhaDigitada = Console.ReadLine();

if(senhaDigitada==senhaValida){
    Console.WriteLine($"Acesso permitido! Bem vindo ao sistema {name}.");
}else{
    Console.WriteLine($"Acesso negado! Srº(ª) {name}, favor tentar novamente houve inconsistência nos dados informados.");
}


