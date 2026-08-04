string usuario = "usuario123";
string senha = "123456";
string usuarioDigitado;
string senhaDigitada;

do {
    Console.Write("Digite usuário: ");
    usuarioDigitado = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(usuarioDigitado)) {
        Console.WriteLine("Valor informado é inválido.");
    }

    if (usuarioDigitado == usuario) {

        do {
            Console.Write("Digite senha: ");
            senhaDigitada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(senhaDigitada)) {
                Console.WriteLine("Valor informado é inválido.");
            }

            if (senhaDigitada == senha) {
               break;
            }
            else {
                Console.WriteLine("Senha incorreta. Digite novamente!");
            }
        }
        while (senhaDigitada != senha);
    }
    else {
        Console.WriteLine("Usuário incorreto. Digite novamente!");
    }
}
while (usuarioDigitado != usuario);

Console.WriteLine($"Olá, {usuario}! Login realizado com sucesso!");
