// 13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Analisador de Números");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o valor de A: ");
int valorA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
int valorB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de C: ");
int valorC = Convert.ToInt32(Console.ReadLine());

if (valorA + valorB < valorC)
{
    Console.WriteLine("O valor de A + B é menor que o valor de C");
}
else
{
    Console.WriteLine("O valor de A + B não é menor que o valor de C");
}


