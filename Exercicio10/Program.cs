// 10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular os dados solicitados.

Console.Clear();

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Depósito da Poupança");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

decimal valorPao = 0.12m;
decimal valorBroa = 1.5m;

Console.WriteLine("Digite o número de pães vendidos: ");
int totalPaes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o número de broas vendidas: ");
int totalBroas = Convert.ToInt32(Console.ReadLine());

decimal depositoPoupanca = ((totalPaes * valorPao) + (totalBroas * valorBroa)) / 10;

Console.WriteLine($"O total a ser depositado é: {depositoPoupanca.ToString("F2")}");
