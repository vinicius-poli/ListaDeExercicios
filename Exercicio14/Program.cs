// 14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Ordenador de números");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o primeiro valor: ");
int valor1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
int valor2 = Convert.ToInt32(Console.ReadLine());
while (valor2 == valor1)
{
    Console.WriteLine("O valor não pode ser repetido!");
    Console.WriteLine("Digite o segundo valor: ");
    valor2 = Convert.ToInt32(Console.ReadLine());

    if (valor2 != valor1)
    {
        break;
    }
}

Console.WriteLine("Digite o terceiro valor: ");
int valor3 = Convert.ToInt32(Console.ReadLine());
while (valor3 == valor1 || valor3 == valor2)
{
    Console.WriteLine("O valor não pode ser repetido!");
    Console.WriteLine("Digite o terceiro valor: ");
    valor3 = Convert.ToInt32(Console.ReadLine());

    if (valor3 != valor1 && valor3 != valor2)
    {
        break;
    }
}

if (valor1 > valor2 && valor1 > valor3)
{
    if (valor2 > valor3)
    {
        Console.WriteLine($"Ordem Decrescente: {valor1}, {valor2}, {valor3}");
    }
    else
    {
        Console.WriteLine($"Ordem Decrescente: {valor1}, {valor3}, {valor2}");
    }
}

else if (valor2 > valor1 && valor2 > valor3)
{
    if (valor1 > valor3)
    {
        Console.WriteLine($"Ordem Decrescente: {valor2}, {valor1}, {valor3}");
    }
    else
    {
        Console.WriteLine($"Ordem Decrescente: {valor2}, {valor3}, {valor1}");
    }
}

else
{
    if (valor1 > valor2)
    {
        Console.WriteLine($"Ordem Decrescente: {valor3}, {valor1}, {valor2}");
    }
    else
    {
        Console.WriteLine($"Ordem Decrescente: {valor3}, {valor2}, {valor1}");
    }
}