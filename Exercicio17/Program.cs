// 17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Analisador de Números");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o valor de A: ");
int valorA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
int valorB = Convert.ToInt32(Console.ReadLine());
int valorC;

if (valorA == valorB)
{
    valorC = valorA + valorB;
}
else
{
    valorC = valorA * valorB;
}

Console.WriteLine($"O valor de C é: {valorC}");