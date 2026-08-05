Console.Write("Digite o valor para saque: ");
var saqueDigitado = Console.ReadLine();

if (!int.TryParse(saqueDigitado, out int saque)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

if (saque <= 0) {
    Console.WriteLine("O valor do saque deve ser maior que zero.");
    return;
}

int notas100 = saque / 100;
saque %= 100;

int notas50 = saque / 50;
saque %= 50;

int notas20 = saque / 20;
saque %= 20;

int notas10 = saque / 10;
saque %= 10;

int notas5 = saque / 5;
saque %= 5;

int notas2 = saque / 2;
saque %= 2;


Console.WriteLine($"Notas de R$100: {notas100}");
Console.WriteLine($"Notas de notas de R$50: {notas50}");
Console.WriteLine($"Notas de notas de R$20: {notas20}");
Console.WriteLine($"Notas de notas de R$10: {notas10}");
Console.WriteLine($"Notas de notas de R$5: {notas5}");
Console.WriteLine($"Notas de notas de R$2: {notas2}");

if (saque > 0) {
    Console.WriteLine($"\nNão foi possível sacar os R${saque} restantes.");
}

