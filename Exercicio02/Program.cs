// Crie um programa para calcular o volume de um Cilindro

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Volume de Cilindro");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o raio cilindro: ");
decimal raio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a altura da caixa: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal areaBase = 3.14m * raio*raio;

decimal volume = areaBase * altura;

Console.WriteLine($"O volume da cilindro é de: {volume.ToString("F2")} cm³.");
