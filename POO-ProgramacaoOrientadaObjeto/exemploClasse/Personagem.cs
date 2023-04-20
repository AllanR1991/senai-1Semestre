/* Para criar uma clase clicar na pasta com botao esquerdo e selecionar new C# */
namespace exemploClasse
{
    public class Personagem
    {
       /*
       Declaração de propriedades
       1 assinatua ,2 tipo, 3 nome.
       */ 
       public string nome = "Tony Stark";
       public int idade = 35;
       public string armadura = "Bleeding Edge";

       public string IA = "Jarvis";

       //Declaração de metodos
       public void Atacar(){
            Console.WriteLine($"O personagem atacou!");
       }
       public void Defender(){
            Console.WriteLine($"O personagem defendeu!");
       }

       public void RestaurarArmadura(){
            Console.WriteLine($"O personagem restaurou a armadura!");
       }
    }
}