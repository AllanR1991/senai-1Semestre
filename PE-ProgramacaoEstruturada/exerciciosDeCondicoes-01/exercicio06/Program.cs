// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.
float nota1, nota2, nota3, nota4, nota5, media;
decimal frequência;


Console.WriteLine($"Digite a 1ª nota: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a 2ª nota: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a 3ª nota: ");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a 4ª nota: ");
nota4 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a 5ª nota: ");
nota5 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a Frequencia do aluno em porcentagem: ");
frequência = decimal.Parse(Console.ReadLine().Replace("%",""));

media = (nota1+nota2+nota3+nota4+nota5)/5;

if(frequência>75){
    if(media>7){
        Console.WriteLine($"Parabens, você foi aprovado.");
    }else if((media>=3) && (media<=7)){
        Console.WriteLine($"Atenção, você está em recuperação sera necessario estudar mais um pouco.");
    }else{
        Console.WriteLine($"Ops não foi dessa vez você acabou sendo reprovado, necessario refazer os estudo.");
    }
}else{
    Console.WriteLine($"O Aluno foi reprovado, pois não atingiu a frenquencia minima exigida.");
}