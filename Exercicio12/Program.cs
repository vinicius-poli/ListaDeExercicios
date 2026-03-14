// 12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Salário");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o salário do funcionário (R$): ");
decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Salário Inicial: R${salarioInicial.ToString("F2")}");
Console.WriteLine($"Salário com Aumento: R${(salarioInicial * 1.15m).ToString("F2")}");
Console.WriteLine($"Salário Descontado: R${(salarioInicial * 1.15m * 0.92m).ToString("F2")}");

