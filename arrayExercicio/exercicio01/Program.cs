int posicao=1;
int[] numeros = new int[5];

for(int index = 0; index < numeros.Length;index++ ){
    Console.WriteLine($"Digite o {index+1}  numero: ");
    numeros[index] = int.Parse(Console.ReadLine());
}

foreach(int index in numeros){
    Console.WriteLine($"O {posicao}º numero digitado foi {index} e o dobro dele é : {index*2}.");
    posicao++;
}
