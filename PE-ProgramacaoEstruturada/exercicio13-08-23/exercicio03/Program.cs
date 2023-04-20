/* 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
- Se quantidade <= 5 o desconto será de 2%
- Se quantidade > 5 e quantidade <=10 o desconto será de 3%
- Se quantidade > 10 o desconto será de 5%
Dica: utilize if / else if / else */


using System.Globalization;

static string PerguntaString(string pergunta){
    Console.WriteLine(pergunta);
    return Console.ReadLine();
}

static char PerguntaChar(string pergunta){
    Console.WriteLine(pergunta);
    return char.Parse(Console.ReadLine());
}

static int PerguntaInt(string pergunta){
    Console.WriteLine(pergunta);
    return int.Parse(Console.ReadLine());
}

static float PerguntaFloat(string pergunta){
    Console.WriteLine(pergunta);
    return float.Parse(Console.ReadLine());
}

static void ExibeMensagemPulandoLinha(string texto){
    Console.WriteLine(texto);
}

static void ExibeMensagem(string texto){
    Console.Write(texto);
}

string produto;
float qtdProduto, precoUnitario;

produto = PerguntaString("Informe o nome do produto : ");
qtdProduto = PerguntaFloat("Informe a quantidade comprada do produto : ");
precoUnitario = PerguntaFloat("Informe o valor unitario do produto: ");

static float CalculaValorTotalComDesconto(float qtdProduto, float precoUnitario){
    float desconto;
    
    if(qtdProduto<=5){
        desconto = (qtdProduto*precoUnitario)*0.98f;
    }else if(qtdProduto>5 && qtdProduto<=10){
        desconto = (qtdProduto*precoUnitario)*0.97f;
    }else{
        desconto = (qtdProduto*precoUnitario)*0.95f;
    }
    return desconto;
}

static float CalculaValorTotalSemDesconto(float qtdProduto, float precoUnitario){
    return qtdProduto*precoUnitario;
}

static float Desconto(float qtdProduto, float precoUnitario){
    float desconto;
    
    if(qtdProduto<=5){
        desconto = (qtdProduto*precoUnitario)*0.02f;
    }else if(qtdProduto>5 && qtdProduto<=10){
        desconto = (qtdProduto*precoUnitario)*0.03f;
    }else{
        desconto = (qtdProduto*precoUnitario)*0.05f;
    }
    return desconto;
}

ExibeMensagemPulandoLinha($"O valor total do {produto} é : {CalculaValorTotalSemDesconto(qtdProduto,precoUnitario).ToString("C",new CultureInfo("pt-BR"))}");
ExibeMensagemPulandoLinha($"A compra de {qtdProduto} unidade(s) lhe da desconto de : {Desconto(qtdProduto,precoUnitario).ToString("C",new CultureInfo("pt-BR"))}");
ExibeMensagemPulandoLinha($"O valor a pagar do produto com desconto é : {CalculaValorTotalComDesconto(qtdProduto,precoUnitario).ToString("C",new CultureInfo("pt-BR"))}");