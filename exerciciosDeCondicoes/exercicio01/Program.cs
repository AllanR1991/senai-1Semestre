float salarioRecebido, gastoTotal;

Console.WriteLine("Informe o salário recebido");
salarioRecebido = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o gasto total");
gastoTotal = float.Parse(Console.ReadLine());

if(salarioRecebido>=gastoTotal){
    Console.WriteLine("Gastos dentro do orçamento");
}else{
    Console.WriteLine("Orçamento estourado");
}

