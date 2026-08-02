Console.Write("Digit um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

int antecessor = numero - 1;
int sucessor = numero + 1;

Console.WriteLine($"Número antecessor: {antecessor}");
Console.WriteLine($"Número informado: {numero}");
Console.WriteLine($"Número sucessor: {sucessor}");

