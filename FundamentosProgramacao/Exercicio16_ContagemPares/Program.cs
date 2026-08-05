List<int> pares = new List<int>();

for (int i = 1; i <= 20; i++) {
    Console.Write("Digite um número: ");
    var numeroDigitado = Console.ReadLine();

    if (!int.TryParse(numeroDigitado, out int numero)) {
        Console.WriteLine("Valor informado é inválido.");
        return;
    }

    if (numero % 2 == 0) {
        pares.Add(numero);
    }
}

Console.WriteLine($"Quantidade de números pares: {pares.Count}");