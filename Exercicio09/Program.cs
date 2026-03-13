// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Área de Terreno");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a largura do terreno (m): ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terreno (m): ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

decimal area = largura * comprimento;

Console.WriteLine($"A area do terreno é de: {area.ToString("F2")} m²");
