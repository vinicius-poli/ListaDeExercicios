// 4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Conversor de Temperatura");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a temperatura em °C: ");
decimal tC = Convert.ToDecimal(Console.ReadLine());

decimal tF = (tC * 9/5) + 32;

Console.WriteLine($"A temperatura em °F é de: {tF}");
