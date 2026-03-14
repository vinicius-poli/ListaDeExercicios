// 18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Gerador de Números Ímpares de 100 a 200");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Aperte [ENTER] para iniciar...");
Console.ReadLine();
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");
Console.WriteLine("Números Ímpares:"); 

for (int i = 100;  i <= 200; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine($"{i}");
    }
}
