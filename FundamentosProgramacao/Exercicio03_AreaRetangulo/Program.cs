Console.Write("Digite a base do retângulo: ");
double baseRetangulo = double.Parse(Console.ReadLine());

Console.Write("Digite a altura do retângulo: ");
double alturaRetangulo = double.Parse(Console.ReadLine());


double areaRetangulo = baseRetangulo * alturaRetangulo;

double perimetroRetangulo = (baseRetangulo + alturaRetangulo) * 2;

Console.WriteLine($"\nA área do retângulo é: {areaRetangulo}");
Console.WriteLine($"O perímetro do retângulo é: {perimetroRetangulo}");

