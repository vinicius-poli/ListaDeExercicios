// 22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Sequência Fibonacci");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Até qual termo da sequência Fibonacci deseja ver?");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

int fibo;
int a = 0;
int b = 1;

while (numero <= 0)
{
    Console.WriteLine("Digite um número maior que zero!");
    Console.WriteLine("Até qual termo da sequência Fibonacci deseja ver?");
    numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("");

    if (numero > 0)
    {
        break;
    }
}

for (int i = 1;  i <= numero; i++)
{
    if (i == 1)
    {
        fibo = a;
    }

    else if (i == 2)
    {
        fibo = b;
    }
    else
    {
        fibo = a + b;
        a = b;
        b = fibo;
    }
    if (i < numero)
    {
        Console.Write($"{fibo}, ");
    }
    else
    {
        Console.Write($"{fibo}.");
    }    
}

