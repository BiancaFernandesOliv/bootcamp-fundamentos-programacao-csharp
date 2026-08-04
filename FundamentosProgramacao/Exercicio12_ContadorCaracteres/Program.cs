Console.Write("Digite um nome: ");
string nome = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nome)) {
    Console.WriteLine("Nome informado é inválido.");
    return;
}

Console.WriteLine($"O nome {nome} possui {nome.Length} caracteres.");