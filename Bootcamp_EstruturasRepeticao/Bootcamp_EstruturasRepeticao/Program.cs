decimal[] vendas = new decimal[7];
decimal vendaDia = 0;
decimal vendaSemana = 0;
decimal maiorValor = 0;
decimal menorValor = 0;

for (int i = 0; i < vendas.Length; i++) {

    bool valorValido = false;

    do {
        Console.Write($"Digite o valor vendido no dia {i + 1}: ");
        vendaDia = decimal.Parse(Console.ReadLine());

        if (vendaDia < 0) {
            Console.WriteLine("Valor da venda não pode ser negativo");
        }
        else {
            valorValido = true;
        }

    } while (!valorValido);

    vendas[i] = vendaDia;
    vendaSemana += vendaDia;

    if (i == 0) {
        maiorValor = vendaDia;
        menorValor = vendaDia;
    }
    else {
        if (vendaDia > maiorValor) {
            maiorValor = vendaDia;
        }
        if (vendaDia < menorValor) {
            menorValor = vendaDia;
        }
    }
}

decimal mediaVendas = vendaSemana / vendas.Length;

int acimaMedia = 0;

foreach (decimal venda in vendas) {
    if (venda > mediaVendas) {
        acimaMedia++;
    }
}

Console.WriteLine($"\nTotal vendido na semana: {vendaSemana:C2}");
Console.WriteLine($"Média diária de vendas: {mediaVendas:C2}");
Console.WriteLine($"O maior valor vendido: {maiorValor:C2}");
Console.WriteLine($"O menor valor vendido: {menorValor:C2}");
Console.WriteLine($"Dias acima da média: {acimaMedia}");