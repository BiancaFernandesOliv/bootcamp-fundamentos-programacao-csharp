int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++) {
    Console.Write("Digite um número: ");
    var numeroDigitado = Console.ReadLine();

    if (!int.TryParse(numeroDigitado, out int numero)) {
        Console.WriteLine("Valor informado é inválido.");
        return;
    }

    numeros[i] = numero;
}

for (int i = numeros.Length - 1; i >= 0; i--) {
    Console.Write($"{numeros[i]} ");
}