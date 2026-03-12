// 5. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Salário");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite o salário base do vendedor (R$): ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o total de vendas do vendedor (R$): ");
decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o percentual da comissão: ");
decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

decimal salarioFinal = salarioBase + (totalVendas * percentualComissao / 100);

Console.WriteLine($"O salário final do vendedor é de: R${salarioFinal}");