using System.Globalization;
using CoversaoMoedaRealDollar;

namespace CoversaoMoedaRealDollar
{
    public static class Conversao
    {
        public static void RealParaDollar(float real){
            PeR.ExibeMensagemPulandoLinha($"O valor de {real.ToString("N2", new CultureInfo("pt-BR"))} para dollar é {(real * 5f).ToString("N2", new CultureInfo("en-US"))}");
        }
        public static void DollarParaReal(float dollar){
            PeR.ExibeMensagemPulandoLinha($"O valor de {dollar.ToString("N2", new CultureInfo("pt-BR"))} para dollar é {(dollar * 5f).ToString("N2", new CultureInfo("en-US"))}");
        }
    }
}