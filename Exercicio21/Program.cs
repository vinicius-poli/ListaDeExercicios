// 21. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Fatorial");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite um valor para calcular o fatorial: ");
int a = Convert.ToInt32(Console.ReadLine());
int fatorial = 1;

while (a < 0)
{
    Console.WriteLine("O número não deve ser negativo!");
    Console.WriteLine("Digite um valor para calcular o fatorial: ");
    a = Convert.ToInt32(Console.ReadLine());

    if (a >= 0)
    {
        break;
    }
}

    
Console.Write($"{a}! = ");

for (int i = a; i >= 1; i--)
{
    fatorial *= i;
    
    if (i > 1)
    {
        Console.Write($"{i} x ");
    }
    else
    {
        Console.Write($"{i} = ");
    }
}

Console.WriteLine(fatorial);

