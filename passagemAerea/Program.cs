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


/* Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
O sistema deve exibir um menu com as seguintes opções:

1- Cadastrar passagem
2- Listar Passagens
0- Sair


Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N). */

int qtdMaxCadastro = 5;
string[] clientes = new string[qtdMaxCadastro];
string[] origens = new string[qtdMaxCadastro];
string[] destinos = new string[qtdMaxCadastro];
string[] dataVoos = new string[qtdMaxCadastro];
string senha = "123456";
string usuario, senhaDigitada;
char escolha;


/* usuario = PerguntaString("Digite seu nome de usuario : ");
senhaDigitada = PerguntaString("Digite a senha para acessar o sistema : ");

while (senhaDigitada != senha)
{
    senhaDigitada = PerguntaString("A senha digita esta erra, digite a senha para acessar o sistema : ");
}
 */
ExibeMensagem(@$"
-------------------------
|                       |
|      Bem-vindo        |
|    ao sistema de      |
|     Cadastro de       |
|    Passagem Aerea     |
|                       |
-------------------------
");


do
{
    ExibeMensagem(@$"
Escolha uma das opções abaixo:

-------------------------
|                       |
| 1- Cadastrar passagem |
|  2- Listar Passagens  |
|       0- Sair         |
|                       |
-------------------------
");


    escolha = char.Parse(Console.ReadLine());

    switch (escolha)
    {
        case '1':
            CadastroPassagem(qtdMaxCadastro,clientes,origens,destinos,dataVoos);
            break;
        case '2':
            break;
        case '0':
            break;
        default:
            break;
    }
} while (escolha != '0');


static void CadastroPassagem(int qtdMaxCadastro, string[] clientes, string[] origens, string[] destinos, string[] dataVoos){
    int qtdCadastro = PerguntaInt($"Digite quantos cadastro deseja realizar *O sistema suporta no maximo {qtdMaxCadastro}");
    for (int i = 0; i < qtdCadastro; i++)
    {
        clientes[i] = PerguntaString("Digite o nome do cliente : ");
        /* origens[i] = PerguntaString("Digite a origem da viagem : ");
        destinos[i] = PerguntaString("Digite o destino da Viagem : ");
        dataVoos[i] = PerguntaString("Digite data da viagem : "); */
    }


}

foreach (var item in clientes)
{
    ExibeMensagem($"Clientes {item}");
}