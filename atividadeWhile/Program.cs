//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

string nome;
char estadoCivil;
int idade;
float salaraio;

Console.WriteLine($"Digite seu nome (*Não pode ser nulo ou vazio)");
nome = Console.ReadLine();

while(nome == "" || nome == " "){
    Console.WriteLine($"Digite seu nome (*Não pode ser nulo ou vazio)");
    nome = Console.ReadLine();
}

Console.WriteLine($"Digite sua idade (*Aceito valores entre 0 e 100)");
idade = int.Parse(Console.ReadLine());

while(idade<0 || idade >100){
    Console.WriteLine($"Digite sua idade (*Aceito valores entre 0 e 100)");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Digite seu salário (*Deve ser maior que 0)");
salaraio = float.Parse(Console.ReadLine());

while(salaraio<=0){
    Console.WriteLine($"Digite seu salário (*Deve ser maior que 0)");
    salaraio = float.Parse(Console.ReadLine());
}

Console.WriteLine($"Digite seu estado civil ('s'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)) )");
estadoCivil = char.Parse(Console.ReadLine());

while((estadoCivil != 's') && (estadoCivil != 'c') && (estadoCivil != 'v') && (estadoCivil != 'd') ){
    Console.WriteLine($"Digite seu estado civil ('s'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)) )");
    estadoCivil = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Registro realizado com sucesso.");


