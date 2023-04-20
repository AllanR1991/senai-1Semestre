using exemploClasse;

/*Instaciamos um Objeto da Classe Personagem*/
Personagem tony = new Personagem();

Console.WriteLine(tony.nome);
Console.WriteLine(tony.idade);
Console.WriteLine(tony.armadura);
Console.WriteLine(tony.IA);

tony.Atacar();
tony.Defender();
tony.RestaurarArmadura();
