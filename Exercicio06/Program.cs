// 6. Crie um programa para calcular a média harmônica das notas de um Aluno

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Média");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a primeira nota do aluno (0 a 10): ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

while (nota1 < 0 || nota1 > 10)
{
    Console.WriteLine("Digite uma nota válida!");
    Console.WriteLine("Digite a primeira nota do aluno (0 a 10): ");
    nota1 = Convert.ToDecimal(Console.ReadLine());

    if (nota1 >= 0 && nota1 <= 10)
    {
        break;
    }
}

Console.WriteLine("Digite a segunda nota do aluno (0 a 10): ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

while (nota2 < 0 || nota2 > 10)
{
    Console.WriteLine("Digite uma nota válida!");
    Console.WriteLine("Digite a segunda nota do aluno (0 a 10): ");
    nota2 = Convert.ToDecimal(Console.ReadLine());

    if (nota2 >= 0 && nota2 <= 10)
    {
        break;
    }
}

Console.WriteLine("Digite a terceira nota do aluno (0 a 10): ");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());

while (nota3 < 0 || nota3 > 10)
{
    Console.WriteLine("Digite uma nota válida!");
    Console.WriteLine("Digite a terceira nota do aluno (0 a 10): ");
    nota3 = Convert.ToDecimal(Console.ReadLine());

    if (nota3 >= 0 && nota3 <= 10)
    {
        break;
    }
}

Console.WriteLine("Digite a quarta nota do aluno (0 a 10): ");
decimal nota4 = Convert.ToDecimal(Console.ReadLine());

while (nota4 < 0 || nota4 > 10)
{
    Console.WriteLine("Digite uma nota válida!");
    Console.WriteLine("Digite a quarta nota do aluno (0 a 10): ");
    nota4 = Convert.ToDecimal(Console.ReadLine());

    if (nota4 >= 0 && nota4 <= 10)
    {
        break;
    }
}

decimal mediaH = (4 / ((1/nota1) + (1/nota2) + (1/nota3) + (1/nota4)));

Console.WriteLine($"A média harmônica do aluno é: {mediaH.ToString("F2")}");
