Console.Write("Digite a base do retângulo: ");
var baseDigitada = Console.ReadLine();

if (!double.TryParse(baseDigitada, out double baseRetangulo)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

Console.Write("Digite a altura do retângulo: ");
var alturaDigitada = Console.ReadLine();

if (!double.TryParse(alturaDigitada, out double alturaRetangulo)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

double areaRetangulo = baseRetangulo * alturaRetangulo;

double perimetroRetangulo = (baseRetangulo + alturaRetangulo) * 2;

Console.WriteLine($"\nA área do retângulo é: {areaRetangulo}");
Console.WriteLine($"O perímetro do retângulo é: {perimetroRetangulo}");

