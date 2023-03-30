/*
Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
*/

string time1, time2;
int placarTime1, placarTime2;

/* Time 1 */
Console.WriteLine("Informe o nome do 1º time a jogar:");
time1 = Console.ReadLine();
Console.WriteLine($"Informe a quantidae de gols realizadas pelo time \"{time1}\":");
placarTime1 = int.Parse(Console.ReadLine());

/* Time 2 */
Console.WriteLine("Informe o nome do 1º time a jogar:");
time2 = Console.ReadLine();
Console.WriteLine($"Informe a quantidae de gols realizadas pelo time \"{time1}\":");
placarTime2 = int.Parse(Console.ReadLine());

if(placarTime1==placarTime2){
    Console.WriteLine($"Houve empate neste jogo entre os times {time1} e {time2}: {placarTime1} X {placarTime2}.");
}else if(placarTime1>placarTime2){
    Console.WriteLine($"O time {time1} é o campeão por {placarTime1} X {placarTime2}");
}else{
    Console.WriteLine($"O time {time2} é o campeão por {placarTime2} X {placarTime1}");
}