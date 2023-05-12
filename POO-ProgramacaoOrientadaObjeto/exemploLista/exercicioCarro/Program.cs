using exercicioCarro;

List<Carro> carros = new List<Carro>();

string marca;
string cor;
string stop;

do
{
    marca = PeR.PerguntaString("Informe a marca do carro: ");
    cor = PeR.PerguntaString($"Informe a cor do carro modelo {marca}:");

    carros.Add(new Carro(marca, cor));
    do
    {
        stop = PeR.PerguntaString("Deseja para inserção (s)sim ou (n)nao");
        if (stop != "s" || stop != "n")
        {
            PeR.ExibeMensagemPulandoLinha($"Dado inserido não é valido digite, (s) para sim ou (n) para nao.");
        }
    } while (stop != "s" && stop != "n");

} while (stop!="s");

PeR.ExibeMensagemPulandoLinha($"Dados cadastrados : ");

foreach (var item in carros)
{
   Console.WriteLine($"Marca: {item.Marca}, Cor: {item.Cor}."); 
}