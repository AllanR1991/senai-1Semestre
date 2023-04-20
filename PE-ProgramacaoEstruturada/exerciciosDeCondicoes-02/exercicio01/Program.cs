// 1) 

// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.
const int anoAtual=2013, maximoDias=31, maximoMeses=12;
int dia,mes,ano;

string erroDia, erroMes, erroAno;


Console.WriteLine("Informe o dia em que nasceu: ");
dia = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o mês em que nasceu: ");
mes = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o ano em que nasceu: ");
ano = int.Parse(Console.ReadLine());


if((dia>0 && dia<=maximoDias) && (mes>0 &&mes<maximoMeses) && (ano>0 && ano<anoAtual)){
    Console.Write("A data digitada é uma data valida.");
}else{
    
    if(dia<0 || dia>maximoDias){
        erroDia = "O dia inserido está errado.";
    }else{
        erroDia = "O dia inserido está correto.";
    }
    
    if(mes<0 || mes>maximoMeses){
        erroMes = "O mês inserido está errado.";
    }else{
        erroMes = "O mês inserido está correto.";
    }
    
    if(ano<0 || ano>anoAtual){
        erroAno = "O ano inserido está errado.";
    }else{
        erroAno = "O ano inserido está Correto.";
    }

    Console.WriteLine(erroDia);
    Console.WriteLine(erroMes);
    Console.WriteLine(erroAno);

}





// if(dia>0 && dia<31){
//     if(mes>0 && mes<12){
//         if(ano>0 && ano <=2013){
//             Console.Write("A data digitada é uma data valida.");
//         }else{
//             Console.WriteLine("O Ano informafo está errado.")
//         }
//     }else{
//         Console.Write("O mês digitado está errado");
//     }
// }else{
//     Console.WriteLine("O dia inserido está errado.");    
// }

