// 1. Crie um programa para calcular o volume de uma caixa retangular

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Volume de Caixa Retangular");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o comprimento da caixa: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a largura da caixa: ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a altura da caixa: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal volume = comprimento * largura * altura;

Console.WriteLine($"O volume da caixa é de: {volume} cm³");
