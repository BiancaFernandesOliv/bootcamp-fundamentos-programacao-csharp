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

if (segundoNumero == 0) {
    Console.WriteLine("Não é possível dividir por zero.");
    return;
}

int soma = primeiroNumero + segundoNumero;
int subtracao = primeiroNumero - segundoNumero;
int multiplicacao = primeiroNumero * segundoNumero;
double divisao = (double)primeiroNumero / segundoNumero;

Console.WriteLine($"\nA soma é {soma}.");
Console.WriteLine($"A subtracao é {subtracao}.");
Console.WriteLine($"A multiplicacao é {multiplicacao}.");
Console.WriteLine($"A divisao é {divisao:F2}.");
