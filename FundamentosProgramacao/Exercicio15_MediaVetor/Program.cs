double[] notas = new double[8];
double soma = 0;

for (int i = 0; i < 8; i++) {
    Console.Write("Digite a nota: ");
    var notaDigitada = Console.ReadLine();

    if (!double.TryParse(notaDigitada, out double nota)) {
        Console.WriteLine("Valor informado é inválido.");
        return;
    }

    notas[i] = nota;
    soma += nota;
}

double media = soma / notas.Length;

Console.WriteLine($"A média das notas é: {media}");