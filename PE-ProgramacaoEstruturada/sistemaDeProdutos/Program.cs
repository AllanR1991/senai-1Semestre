
using System.Globalization;

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


/* Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

Os produtos terão os seguintes atributos:
string Nome
float Preco
bool Promocao (se está em promoção ou não)

O sistema deverá ter as seguintes funcionalidades:
CadastrarProduto
ListarProdutos
MostrarMenu
Crie função(ões) para otimizar o código.
Incremente o que achar necessário. Utilize sua lógica e sua criatividade. */

static bool ConverteRespostaPromoEmBool(string[] nomeProdutos, int contador)
{

    string resposta = PerguntaString($"O produto \"{nomeProdutos[contador]}\" está em promoção? ");
    bool valorBoleano;
    if (resposta == "sim")
    {
        valorBoleano = true;
    }
    else
    {
        valorBoleano = false;
    }

    return valorBoleano;
}

static int CadastroProduto(int qtdMaxCadastro, string[] nomeProdutos, float[] precoProduto, bool[] promocao, int contador)
{
    char cadastrarMais = ' ', sobreEscrever = ' ';
    string valorPromo = "";
    do
    {
        if (nomeProdutos[contador] == null)
        {

            nomeProdutos[contador] = PerguntaString($"\nDigite o nome do produto : ");
            precoProduto[contador] = PerguntaFloat($"Qual o valor do produto : {nomeProdutos[contador]}: ");
            promocao[contador] = ConverteRespostaPromoEmBool(nomeProdutos, contador);
            ;
            contador++;
            if (contador > 4)
            {
                contador = 0;
            }

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ExibeMensagemPulandoLinha($"\nCadastro cheio deseja sobrescrever a passagem cadastrada para o cliente : {nomeProdutos[contador]}");
            sobreEscrever = PerguntaChar("Deseja prosseguir com o cadastro (s) para sim e (n) para não");
            Console.ResetColor();
            if (sobreEscrever == 's')
            {
                nomeProdutos[contador] = PerguntaString($"\nDigite o nome do produto : ");
                precoProduto[contador] = PerguntaFloat($"Qual o valor do produto : {nomeProdutos[contador]}: ");
                promocao[contador] = ConverteRespostaPromoEmBool(nomeProdutos, contador);
                ;
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

static void ExibeProdutos(string[] nomeProdutos, float[] precoProduto, bool[] promocao)
{
    string promo;
    int contadorLista = 0;
    foreach (var produto in nomeProdutos)
    {

        if (produto != null)
        {
            if(promocao[contadorLista]==true){
                promo="sim";
            }else{
                promo="não";
            }
            ExibeMensagemPulandoLinha(@$"
----------------------------------------------
┊┊┊┊┊┊┊╱▏┊┊┊┊┊┊┊
┊┊┊┊┊┊▕╱┊┊┊┊┊┊┊┊
┊┊┊╱▔▔╲┊╱▔▔▔\┊┊┊┊       MERCEARIA DO
┊┊|┈┈┈┈┈▔┈┈┈┈┈┈╱┊┊┊┊        TITIO Allan
┊┊|┈┈┈┈┈┈┈┈┈┈┈┈╲┊┊┊┊
┊┊┊╲┈┈┈┈┈┈┈┈┈┈┈╱┊┊┊┊
┊┊┊┊╲▂▂▂▂▂╱┊┊┊┊┊


Produto: {produto}
Preço: {precoProduto[contadorLista].ToString("C", new CultureInfo("pt-BR"))}
Está com promoção: {promo}


----------------------------------------------
");
            contadorLista++;
        }
    }
}

int qtdMaxCadastro = 5;
string[] nomeProdutos = new string[qtdMaxCadastro];
float[] precoProduto = new float[qtdMaxCadastro];
bool[] promocao = new bool[qtdMaxCadastro];

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
|       Bem-vindo       |
|     ao sistema de     |
|      Cadastro de      |
|       Produtos        |
|                       |
-------------------------
");


do
{
    ExibeMensagem(@$"

Escolha uma das opções abaixo:

-------------------------
|                       |
| 1- Cadastrar produto  |
|  2- Listar produto    |
|       0- Sair         |
|                       |
-------------------------

");


    escolha = char.Parse(Console.ReadLine());

    switch (escolha)
    {
        case '1':
            contadorCadastro = CadastroProduto(qtdMaxCadastro, nomeProdutos, precoProduto, promocao, contadorCadastro);
            break;
        case '2':
            ExibeProdutos(nomeProdutos, precoProduto,promocao);
            break;
        case '0':
            break;
        default:
            break;
    }
} while (escolha != '0');
