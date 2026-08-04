/*
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

Console.WriteLine($"\nA soma é {primeiroNumero + segundoNumero}.");
Console.WriteLine($"A subtracao é {primeiroNumero - segundoNumero}.");
Console.WriteLine($"A multiplicacao é {primeiroNumero * segundoNumero}.");
Console.WriteLine($"A divisao é {primeiroNumero / segundoNumero}.");
Console.WriteLine($"O resto é {primeiroNumero % segundoNumero}.");
*/

//
//Console.Write("Digite um número: ");
//var numeroDigitado = Console.ReadLine();

//if (!int.TryParse(numeroDigitado, out int numero)) {
//    Console.WriteLine("Valor informado é inválido.");
//    return;
//}

//bool numeroPar = numero % 2 == 0;

//Console.WriteLine($"O número digitado é par? {numeroPar}");


/*

Console.Write("Digite sua idade: ");
var idadeDigitada = Console.ReadLine();

if (!int.TryParse(idadeDigitada, out int idade)) {
    Console.WriteLine("Idade informada é inválida.");
    return;
}

if (idade >= 18) {

    bool podeDirigir;

    Console.Write("Você possui carteira de motorista? (S/N): ");
    string carteira = Console.ReadLine().ToLower();

    if (carteira == "s") {
        podeDirigir = true;
    }
    else {
        podeDirigir = false;
    }

    if (podeDirigir) {
        Console.WriteLine("Você pode dirigir!");
    }
    else {
        Console.WriteLine("Você não pode dirigir!");
    }
}
else {
    Console.WriteLine("Você não pode dirigir!");
}
*/

/*
Console.Write("Digite primeira nota do aluno: ");
var nota1Digitada = Console.ReadLine();

if (!double.TryParse(nota1Digitada, out double nota1)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

Console.Write("Digite segunda nota do aluno: ");
var nota2Digitada = Console.ReadLine();

if (!double.TryParse(nota2Digitada, out double nota2)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

Console.WriteLine();
Console.Write("Digite frequência do aluno (%): ");
var frequenciaDigitada = Console.ReadLine();

if (!double.TryParse(frequenciaDigitada, out double frequencia)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

double media = (nota1 + nota2) / 2;

if (media >= 6 && frequencia >= 75) {
    Console.WriteLine("Aluno aprovado!");
}
else {
    Console.WriteLine("Aluno reprovado!");
}
*/

/*
Console.Write("Digite valor da compra: ");
var compraDigitada = Console.ReadLine();

if (!decimal.TryParse(compraDigitada, out decimal valorCompra)) {
    Console.WriteLine("Valor informado é inválido.");
    return;
}

bool assinantePremium;

Console.Write("Você é assinante premium? (S/N): ");
string premium = Console.ReadLine().ToLower();

if (premium == "s") {
    assinantePremium = true;
} else {
    assinantePremium = false;
}

if (valorCompra >= 200 || assinantePremium) {
    Console.WriteLine("Você conseguiu frete grátis!");
} else {
    Console.WriteLine("Você não conseguiu frete grátis!");
}
*/