/* 15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
● IMC em adultos Condição
● Abaixo de 18,5 Abaixo do peso
● Entre 18,5 e 25 Peso normal
● Entre 25 e 30 Acima do peso
● Acima de 30 obeso*/

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de IMC");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o peso do indivíduo (Kg): ");
decimal peso = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a altura do indivíduo (m): ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal imc = peso / (altura * altura);

Console.WriteLine($"O IMC do indivíduo é: {imc.ToString("F2")} ");

if (imc < 18.5m)
{
    Console.WriteLine("ABAIXO DO PESO!");
}
else if (imc >= 18.5m && imc < 25)
{
    Console.WriteLine("PESO NORMAL!");
}
else if (imc >= 25 && imc <= 30)
{
    Console.WriteLine("ACIMA DO PESO!");
}
else
{
    Console.WriteLine("OBESO!");
}