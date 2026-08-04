Console.Write("Digite um número: ");
var numeroDigitado = Console.ReadLine();

if (!int.TryParse(numeroDigitado, out int numero)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

for (int i = 1; i <= 10; i++) {
    Console.WriteLine($"{numero} * {i} = {numero * i}");
}