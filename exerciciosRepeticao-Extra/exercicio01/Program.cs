/* Sistema que verifica se o numero digitado esta entre 0 e 10 */
// 1. Uma certa empresa fez uma
// pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.    
// O número de pessoas que responderam SIM.

// B.    
// O número de pessoas que responderam NÃO;

// C.   
// O número de mulheres que responderam SIM;

// D.   
// A porcentagem de homens que responderam NÃO entre todos

// E.    
// os homens analisados.

Console.WriteLine("Pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado");
char sexo, gosta;
int qtMulherSim = 0, qtHomem = 0, qtMulher = 0, gostaSim=0, qtHomemNao=0, gostaNao=0;
double porcentagemDeHomens = 0d;

for(int qtEntrevistados=1;qtEntrevistados<=3;qtEntrevistados++){
    Console.WriteLine("Digite o seu Sexo (M) para Masculino, (F) para Feminino");
    sexo = char.Parse(Console.ReadLine());
    
    if(sexo=='f'){
        Console.WriteLine("Você gosta do Shampo Dove? (s) para sim, (n) para não.");
        gosta = char.Parse(Console.ReadLine());
        qtMulher++;
        if(gosta == 's'){
            qtMulherSim++;
            gostaSim++;
        }else{
            gostaNao++;
        }
    }else{
        Console.WriteLine("Você gosta do Shampo Dove? (s) para sim, (n) para não.");
        gosta = char.Parse(Console.ReadLine());
        qtHomem++;        
        if(gosta == 's'){
            gostaSim++;
        }else{
            qtHomemNao++;
            gostaNao++;
        }
    }
}

porcentagemDeHomens =((double)gostaNao/(double)qtHomem)*100d;

Console.WriteLine($"{gostaSim} pessoas gostaram do produto.");
Console.WriteLine($"{gostaNao} pessoas não gostaram do produto.");
Console.WriteLine($"{qtMulherSim} mulheres gostaram do produto.");
            qtHomemNao++;
Console.WriteLine($"A porcentagem de homens que responderam não foi: {porcentagemDeHomens}%.");

