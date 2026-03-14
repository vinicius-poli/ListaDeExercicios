/* 20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a tabuada na forma:
● 0 x N = 0,
● 1 x N = 1N,
● 2 x N = 2N, . . .
● 10 x N = 10N. */


Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Tabuada");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Qual tabuada deseja ver? [0 a 10]");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

while (numero < 1 || numero > 10)
{
    Console.WriteLine("Digite um número entre 1 e 10");
    Console.WriteLine("Qual tabuada deseja ver? [0 a 10]");
    numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("");

    if (numero >= 1 && numero > 10)
    {
        break;
    }
}

for (int i = 1;  i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}
