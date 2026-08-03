Console.Write("Digite o primeiro número: ");
var primeiroDigitado = Console.ReadLine();

if (!int.TryParse(primeiroDigitado, out int primeiroNumero)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

Console.Write("Digite o segundo número: ");
var segundoDigitado = Console.ReadLine();

if (!int.TryParse(segundoDigitado, out int segundoNumero)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

int soma = primeiroNumero + segundoNumero;

Console.WriteLine($"A soma é {soma}.");
