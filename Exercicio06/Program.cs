// 6. Crie um programa para calcular a média harmônica das notas de um Aluno

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Média");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a primeira nota do aluno: ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno: ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a terceira nota do aluno: ");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quarta nota do aluno: ");
decimal nota4 = Convert.ToDecimal(Console.ReadLine());

decimal mediaH = (4 / ((1/nota1) + (1/nota2) + (1/nota3) + (1/nota4)));

Console.WriteLine($"A média harmônica do aluno é: {mediaH}.");
