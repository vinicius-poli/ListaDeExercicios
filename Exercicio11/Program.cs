// 11. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui. Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Contador de Idade em Dias");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o nome da pessoa: ");
string? nome = Console.ReadLine();

Console.WriteLine("Digite a idade da pessoa: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{nome}, você já viveu {idade * 365} dias.");