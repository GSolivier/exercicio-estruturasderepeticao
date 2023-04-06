// Pedir para que o usuário digite uma nota entre 0 e 10.
// Mostrar uma mensagem caso o valor seja inválido, e continuar perguntando a nota para o usuário.
// Ir repetindo até uma nota válida ser informada.

Console.WriteLine($"Digite uma nota entre 0 e 10: ");
int nota = int.Parse(Console.ReadLine());

while (nota > 10 || nota < 0)
{
    Console.WriteLine($"Valor inválido. Por favor, digite uma nota válida:");
    nota = int.Parse(Console.ReadLine());
}

Console.WriteLine($"a sua nota foi {nota}");

