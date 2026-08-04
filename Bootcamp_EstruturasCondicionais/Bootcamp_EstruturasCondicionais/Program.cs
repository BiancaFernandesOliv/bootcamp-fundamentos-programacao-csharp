Console.WriteLine("=== CARDÁPIO ===");
Console.WriteLine("1 - Hamburguer - R$ 25,00");
Console.WriteLine("2 - Pizza - R$ 40,00");
Console.WriteLine("3 - Salada - R$ 18,00");
Console.WriteLine("4 - Suco - R$ 8,00");

Console.Write("\nInforme o código do produto desejado: ");
string codigo = Console.ReadLine();

if (!int.TryParse(codigo, out int cod)) {
    Console.WriteLine(" Código inválido!");
    return;
}

Console.Write("Informe a quantidade desejada: ");
string qtd = Console.ReadLine();

if (!int.TryParse(qtd, out int quantidade)) {
    Console.WriteLine("Quantidade inválida!");
    return;
}

string nomeProduto = "";
decimal valorUnitario = 0;

switch (codigo) {
    case "1":
        nomeProduto = "Hamburguer";
        valorUnitario = 25;
        break;
    case "2":
        nomeProduto = "Pizza";
        valorUnitario = 40;
        break;
    case "3":
        nomeProduto = "Salada";
        valorUnitario = 18;
        break;
    case "4":
        nomeProduto = "Suco";
        valorUnitario = 8;
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

if (quantidade <= 0) {
    Console.WriteLine("Quantidade inválida");
}

decimal subtotal = valorUnitario * quantidade;
decimal percentualDesconto;
bool desconto;

if (subtotal > 500) {
    percentualDesconto = 15;
    desconto = true;
}
else if (subtotal >= 200 && subtotal <= 500) {
    percentualDesconto = 10;
    desconto = true;
}
else {
    percentualDesconto = 0;
    desconto = false;
}

decimal total = subtotal - (subtotal * percentualDesconto / 100);

Console.WriteLine("\n=== RESUMO DA COMPRA ===");
Console.WriteLine($"Produto comprado: {nomeProduto} \nPreço unitário: {valorUnitario:C2}");
Console.WriteLine($"Quantidade comprada: {quantidade} unidade(s).");
Console.WriteLine($"Subtotal: {subtotal:C2}");
Console.WriteLine($"Porcentual de desconto: {percentualDesconto}%");
Console.WriteLine($"Valor final: {total:C2}");
Console.WriteLine($"{(desconto ? "Compra com desconto!" : "Compra sem desconto!")}");
