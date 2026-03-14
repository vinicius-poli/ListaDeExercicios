// 8. Crie um programa para verificar se um número é primo.


int numeroPrimos = 0;
int i;

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Verficador de Números Primos");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o número a ser verificado: ");
int numero = Convert.ToInt32(Console.ReadLine());

for (i = numero; i > 0; i--)
//LEMBRAR: o segundo parâmetro é a condição para SE MANTER no laço e não para SAIR!
{
    if (numero % i == 0)
    {
        numeroPrimos++;
    }
}

if (numeroPrimos == 2)
{
    Console.WriteLine($"O número {numero} é primo.");
}
else
{
    Console.WriteLine($"O número {numero} não é primo.");
}

