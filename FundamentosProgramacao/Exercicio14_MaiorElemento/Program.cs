List<int> numeros = new List<int>();

for (int i = 1; i <= 10; i++) {
    Console.Write("Digite um número inteiro: ");
    var numeroDigitado = Console.ReadLine();

    if(!int.TryParse(numeroDigitado, out int numero)) {
        Console.WriteLine("Valor informado é inválido.");
        return;
    }

    numeros.Add(numero);
}

int maiorNumero = numeros.Max();

Console.WriteLine($"Maior valor: {maiorNumero}");

Console.WriteLine($"Posição em que ele aparece: {numeros.IndexOf(maiorNumero) + 1}");