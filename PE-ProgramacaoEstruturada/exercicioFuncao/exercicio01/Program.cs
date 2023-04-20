/* Calcula imposto */
using System.Globalization;

float renda = 0;

static string PerguntaString(string pergunta){
    Console.WriteLine(pergunta);
    return Console.ReadLine();
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

static float CalculaImposto(float renda){
    float imposto = 0;
    if(renda<=1500){
        imposto = 0;
    }else if(renda>=1501 && renda<=3500){
        imposto = renda * 0.20f;
    }else if(renda>=3501 && renda<=6000){
        imposto = renda * 0.25f;
    }else{
        imposto = renda * 0.30f;
    }

    return imposto;
}

renda = PerguntaFloat("Digite a sua renda");
var imposto = CalculaImposto(renda);
ExibeMensagem("O imposto cobrado sobre a sua renda é " + imposto.ToString("C", new CultureInfo("pt-BR")));