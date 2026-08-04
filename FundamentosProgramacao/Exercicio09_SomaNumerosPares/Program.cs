int soma = 0;

for (int i = 1; i <= 100; i++) {

    if (i % 2 == 0) {

        soma += i;
    }
}

Console.WriteLine($"A soma de todos os números pares entre 1 e 100 é: {soma}");