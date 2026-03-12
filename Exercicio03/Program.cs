/*3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
programa deve solicitar ao usuário:
● A quilometragem inicial do veículo no início da viagem.
● A quilometragem final ao término da viagem.
● A quantidade de combustível consumida durante a viagem (em litros).
 */

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculadora de Consumo de Combustível");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Digite a quilometragem inicial do veículo: ");
decimal KmInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quilometragem final do veículo: ");
decimal Kmfinal = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de litros consumidos: ");
decimal consumo = Convert.ToDecimal(Console.ReadLine());

decimal distanciaPercorrida = Kmfinal - KmInicial;

decimal consumoLitrosKm = distanciaPercorrida / consumo;

Console.WriteLine($"O consumo de combustível foi de: {consumoLitrosKm.ToString("F2")} Km/l.");