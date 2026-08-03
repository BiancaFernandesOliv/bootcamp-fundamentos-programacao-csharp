
Console.Write("Digite um valor em reais: ");
var realDigitado = Console.ReadLine();

if (!decimal.TryParse(realDigitado, out decimal valorReal)) {
    Console.WriteLine("Valor inválido!");
    return;
}

Console.Write("Digite cotação do dólar: ");
var cotacaoDigitado = Console.ReadLine();

if (!decimal.TryParse(cotacaoDigitado, out decimal cotacaoDolar)) {
    Console.WriteLine("Valor inválido!");
    return;
}

decimal cambio = valorReal / cotacaoDolar;

Console.Write($"\nO valor de {valorReal:C2} equivale a $ {cambio:F2}");