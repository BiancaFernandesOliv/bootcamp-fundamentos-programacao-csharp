Console.Write("Digite a senha: ");
string senha = Console.ReadLine();

if (string.IsNullOrWhiteSpace(senha)) {
    Console.WriteLine("Senha informada é inválido.");
    return;
}

if (senha.Length >= 8) {
    Console.WriteLine($"A senha possui pelo menos 8 caracteres.");
}

else {
    Console.WriteLine($"A senha possui menos de 8 caracteres.");
}