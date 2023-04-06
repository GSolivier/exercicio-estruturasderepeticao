// Ler o nome do usuário e a senha
// Não permitir que a senha seja igual ao numero de usuario.
// e voltar a pedir as informações.

Console.WriteLine($"Digite seu nome de usuário:");
string? user = Console.ReadLine().ToLower();

Console.WriteLine($"Digite sua senha: ");
string? pass = Console.ReadLine().ToLower();

while (user == pass)
{
    Console.WriteLine($"Sua senha não pode ser seu nome de usuário. Por favor, digite uma senha válida.");

Console.WriteLine($"Digite seu nome de usuário:");
user = Console.ReadLine().ToLower();

Console.WriteLine($"Digite sua senha: ");
 pass = Console.ReadLine().ToLower();
}

Console.WriteLine($"Usuário cadastrado com sucesso!");



