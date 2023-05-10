using Exemplo01;

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

float celsius = 30;
float fahrenheit = 86;

ExibeMensagemPulandoLinha($"A temperatura de {celsius}ºC convertida para fahrenheit fica {ConversorTemperatura.CelsiusParaFahrenheit(celsius)}ºF");
ExibeMensagemPulandoLinha($"A temperatura de {fahrenheit}ºF convertida para celsius fica {ConversorTemperatura.FahreinheitParaCelsius(fahrenheit)}ºC");