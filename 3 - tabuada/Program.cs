// Pedir um numero inteiro para o usuário
// Mostrar a tabuada daquele número.

int resultado;

Console.WriteLine($"Digite um número para obter sua tabuada");
int num = int.Parse(Console.ReadLine());

for (var i = 0; i <= 10; i++)
{
    resultado = num * i;
    Console.WriteLine($"{num} X {i} = {resultado}");
    
}
