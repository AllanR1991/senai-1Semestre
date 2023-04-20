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
static int CadastroPassagem(int qtdMaxCadastro, string[] clientes, string[] origens, string[] destinos, string[] dataVoos, int contador)
{
    char cadastrarMais = ' ', sobreEscrever = ' ';

    do
    {
        if (clientes[contador] == null)
        {
            clientes[contador] = PerguntaString($"\nDigite o nome do cliente : ");
            origens[contador] = PerguntaString($"Qual a cidade a origem da viagem do Srº(ª) {clientes[contador]}: ");
            destinos[contador] = PerguntaString($"Qual a cidade de destino da viagem do Srº(ª) {clientes[contador]}: ");
            dataVoos[contador] = PerguntaString($"Informe a data que o Srº(ª) {clientes[contador]} deseja Viajar : ");
            contador++;
            if (contador > 4)
            {
                contador = 0;
            }

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ExibeMensagemPulandoLinha($"\nCadastro cheio deseja sobrescrever a passagem cadastrada para o cliente : {clientes[contador]}");
            sobreEscrever = PerguntaChar("Deseja prosseguir com o cadastro (s) para sim e (n) para não");
            Console.ResetColor();
            if (sobreEscrever == 's')
            {
                clientes[contador] = PerguntaString($"Digite o nome do cliente : ");
                origens[contador] = PerguntaString($"Qual a cidade a origem da viagem do Srº(ª) {clientes[contador]}: ");
                destinos[contador] = PerguntaString($"Qual a cidade de destino da viagem do Srº(ª) {clientes[contador]}: ");
                dataVoos[contador] = PerguntaString($"Informe a data que o Srº(ª) {clientes[contador]} deseja Viajar : ");
                contador++;
                if (contador > 4)
                {
                    contador = 0;
                }
            }
            else
            {
                break;
            }

        }
        cadastrarMais = PerguntaChar("Deseja cadastra mais uma passagem (s) para sim e (n) para não");
    } while (cadastrarMais != 'n');

    return contador;
}

static void exibePassagemCliente(string[] clientes, string[] origens, string[] destinos, string[] dataVoos)
{
    int contadorLista = 0;
    foreach (var cliente in clientes)
    {

        if (cliente != null)
        {
            ExibeMensagemPulandoLinha(@$"
----------------------------------------------
        @@@@@      @@       @      @@@@@
     @@@@@@@@@@@  @@@@@@@@@@    @@@@@@@@@@@
        @@@@@       @@             @@@@@

              Pasagem Aerea Latam

Nome: {cliente}
Origem: {origens[contadorLista]}
Destino: {destinos[contadorLista]}
Data: {dataVoos[contadorLista]}

----------------------------------------------
");
            contadorLista++;
        }
    }
}

int qtdMaxCadastro = 5;
string[] clientes = new string[qtdMaxCadastro];
string[] origens = new string[qtdMaxCadastro];
string[] destinos = new string[qtdMaxCadastro];
string[] dataVoos = new string[qtdMaxCadastro];
string senha = "123456";
string usuario, senhaDigitada;
char escolha;
int contadorCadastro = 0;



usuario = PerguntaString("Digite seu nome de usuario : ");
senhaDigitada = PerguntaString("Digite a senha para acessar o sistema : ");

while (senhaDigitada != senha)
{
    senhaDigitada = PerguntaString("A senha digita esta erra, digite a senha para acessar o sistema : ");
}




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
            contadorCadastro = CadastroPassagem(qtdMaxCadastro, clientes, origens, destinos, dataVoos, contadorCadastro);
            break;
        case '2':
            exibePassagemCliente(clientes, origens, destinos, dataVoos);
            break;
        case '0':
            break;
        default:
            break;
    }
} while (escolha != '0');