using CoversaoMoedaRealDollar;



float valor;
string opcao;
PeR.PerguntaString(@"
********************************
*                              *
*       Sistema Conversão      *
*            de moeda          *
*                              *
********************************
");

do
{

    opcao = PeR.PerguntaString(@"
********************************
*                              *
*   1) Converter Dollar para   *
*      Real                    *
*                              *
*   2) Converter Real para     *
*      Dollar                  *
*                              *
*   3) Sair                    *
*                              *
********************************
");
    switch (opcao)
    {
        case "1":
            valor = PeR.PerguntaFloat("Digite o valor em Dollar para conveter em Reais.");
            Conversao.DollarParaReal(valor);
            break;
        case "2":
            valor = PeR.PerguntaFloat("Digite o valor em Real para conveter em Dollar.");
            Conversao.RealParaDollar(valor);
            break;
        case "3":
            PeR.ExibeMensagemPulandoLinha("Até logo...");
            break;
        default:
            break;
    }
} while (opcao != "3");