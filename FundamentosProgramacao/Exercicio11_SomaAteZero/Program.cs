int soma = 0;
int numero;

do {
    Console.Write("Digite um número inteiro: ");
    var numeroDigitado = Console.ReadLine();

    if (!int.TryParse(numeroDigitado, out numero)) {
        Console.WriteLine("Valor informado é inválido.");
        return;
    }
    soma += numero;
}
while (numero != 0);

Console.WriteLine($"A soma dos números digitados é: {soma}");