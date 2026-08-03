
Console.Write("Digite um valor em reais: ");
var realDigitado = Console.ReadLine();

if (!decimal.TryParse(realDigitado, out decimal valorReal)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

Console.Write("Digite cotação do dólar: ");
var cotacaoDigitada = Console.ReadLine();

if (!decimal.TryParse(cotacaoDigitada, out decimal cotacaoDolar)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

decimal cambio = valorReal / cotacaoDolar;

Console.Write($"\nO valor de {valorReal:C2} equivale a $ {cambio:F2}");