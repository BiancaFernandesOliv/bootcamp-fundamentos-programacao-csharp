Random sorteador = new Random();

int numeroSorteado = sorteador.Next(1, 101);

int numero = 0;


do {
    Console.Write("Digite um número: ");
    var numeroDigitado = Console.ReadLine();

    if (!int.TryParse(numeroDigitado, out numero)) {
        Console.WriteLine("Valor informado é inválido.");
        return;
    }

    if (numero == numeroSorteado) {
        Console.WriteLine("Parabéns, você acertou!");
    }
    else if (numero < numeroSorteado) {
        Console.WriteLine("O número sorteado é maior que o número digitado!");
    }
    else {
        Console.WriteLine("O número sorteado é menor que o número digitado!");
    }
}
while (numero != numeroSorteado);

Console.WriteLine($"O número sorteado foi: {numeroSorteado}!");