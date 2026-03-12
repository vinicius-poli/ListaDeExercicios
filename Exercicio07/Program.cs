// 7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

decimal nota1;
decimal nota2;

Console.Clear();
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Média");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

while (true)
{ 
    Console.WriteLine("Digite a primeira nota do aluno (0 a 10): ");
    nota1 = Convert.ToDecimal(Console.ReadLine());
    if (nota1 < 0 || nota1 > 10)
    {
        Console.WriteLine("Digite uma nota válida!");
        continue;
    }

    else
    {
        break;
    }
}

Console.WriteLine("Digite o peso da primeira nota do aluno (1 a 9): ");
decimal peso1 = Convert.ToDecimal(Console.ReadLine());

decimal peso2 = 10 - peso1;

while (true)
{
    Console.WriteLine("Digite a segunda nota do aluno (0 a 10): ");
    nota2 = Convert.ToDecimal(Console.ReadLine());

    if (nota2 < 0 || nota2 > 10)
    {
        Console.WriteLine("Digite uma nota válida!");
        continue;
    }

    else
    {
        break;
    }
}

decimal mediaP = ((nota1 * peso1 / 10) + (nota2 * peso2 / 10)) / ((peso1 / 10) + (peso2 / 10));

Console.WriteLine($"A média ponderada do aluno é: {mediaP}.");
