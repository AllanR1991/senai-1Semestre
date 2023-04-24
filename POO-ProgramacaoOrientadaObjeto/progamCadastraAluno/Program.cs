using progamCadastraAluno.classes;

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

CadastrarAluno aluno = new CadastrarAluno();

aluno.nome = PerguntaString("Digite o nome do Aluno(a): ");
aluno.idade = PerguntaString($"Digite a idade do(a) {aluno.nome}: ");
aluno.rg = PerguntaString($"Digite o rg do(a) {aluno.nome}: ");
string boleano = PerguntaString("Aluno é bosista (sim) ou (não): ");
if(boleano=="sim"){
    aluno.bolsista = true;
}else{
    aluno.bolsista = false;
}
aluno.mediaFinal = PerguntaFloat($"Digite a média final do {aluno.nome}");
aluno.valorMensalidade = PerguntaFloat($"Digite o valor da mensalidade a ser paga pelo(a) {aluno.nome}");


do{

opcao = PerguntaString(@"
Escolha uma das opções abaixo no menu:

(1) - Visualizar a média
(2) - Valor da mensalidade
(0) - Sair

");

switch(opcao){
    case "1":
        aluno.VerMediaFinal();
        break;
    case "2":
        aluno.VerMensalidade();
        break;
    case "0":
        ExibeMensagemPulandoLinha("\nObrigado por utilizar o programa de cadastro de aluno, até logo...");
        break;
    default:
        ExibeMensagemPulandoLinha("\nNenhuma opção selecionada, tente novamente.");
        break;
}
}while(opcao!="0");