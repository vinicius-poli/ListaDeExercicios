// 19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Somador de Números Ímpares Múltiplos de 3 de 1 a 500");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Aperte [ENTER] para iniciar...");
Console.ReadLine();
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

int somaImpares = 0;

for (int i = 1;  i <= 500; i++)
{
    if (i % 2 == 1 && i % 3 == 0)
    {
        somaImpares += i;        
    }
}

Console.WriteLine($"A soma dos números ímpares e múltiplos de 3 de 1 a 500 é de: {somaImpares}");
