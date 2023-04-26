using programCelular.classes;

/*
Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
Só será possível executar tais métodos se o celular estiver ligado.
Envie o link do repositório como entrega desta atividade. 
*/


static string PerguntaString(string pergunta)
{
    Console.WriteLine(pergunta);
    return Console.ReadLine();
}

static char PerguntaChar(string pergunta)
{
    Console.WriteLine(pergunta);
    return char.Parse(Console.ReadLine());
}

static int PerguntaInt(string pergunta)
{
    Console.WriteLine(pergunta);
    return int.Parse(Console.ReadLine());
}

static float PerguntaFloat(string pergunta)
{
    Console.WriteLine(pergunta);
    return float.Parse(Console.ReadLine());
}

static void ExibeMensagemPulandoLinha(string texto)
{
    Console.WriteLine(texto);
}

static void ExibeMensagem(string texto)
{
    Console.Write(texto);
}

string opcao;

Celular novoCelular = new Celular();

/* novoCelular.Cor = PerguntaString("Qual a cor do celular : ");
novoCelular.Modelo = PerguntaString("Qual o modelo do celular : ");
novoCelular.Tamanho = PerguntaString("Qual o tamanho do celular : "); */
string celularLigado = PerguntaString("Celular Desligado, deseja Ligar: ");
novoCelular.Ligado = celularLigado.ToLower()=="sim";

if(celularLigado=="sim"){
    novoCelular.Ligar();
    Console.WriteLine(@$"
*********************
*                   *
*   Hello Moto!!!   *
*                   *
*********************
");
}


while(celularLigado=="sim"){

opcao = PerguntaString(@$"
-----------------------------
|       Escolha uma         |
|       das opçoes:         |
|                           |
|   1)  Desligar            |
|   2)  Fazer Ligação       |
|   3)  Enviar Mensagem     |
|                           |
-----------------------------
");

switch(opcao){
    case "1":
        novoCelular.Desligar();
        celularLigado="nao";
        break;
    case "2":
        novoCelular.FazerLigacao();
        break;
    case "3":
        novoCelular.EnviarMensagem();
        break;
    default:
        ExibeMensagemPulandoLinha("Nenhuma opção disponivel selecionada.");
        break;
}

}