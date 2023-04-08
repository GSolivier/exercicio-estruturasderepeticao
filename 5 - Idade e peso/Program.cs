// Ler a idade, o peso, e o sexo de 10 pessoas diferentes.
// Calcular o total de homens
// Total de mulheres
// Media de idade dos homens
// media de idade das mulheres

int idadeH;
int idadeM;
int idadeTotalHomens = 0;
int idadeTotalMulheres = 0;
int contadorMulheres = 0;
int contadorHomens = 0;
int mediaIdadeHomens = 0;
int mediaIdadeMulheres = 0;
bool loopBreak = true;
string gen;

for (var i = 1; i <=10; i++)
{
    do
    {
        
    Console.WriteLine($"Qual o sexo que você se identifica? 'm' para masculino - 'f' para feminino");
    gen =(Console.ReadLine().ToLower());

    switch (gen)
    {
        case "m":
        contadorHomens++;
        loopBreak = false;
            break;

        case "f":
        contadorMulheres++;
        loopBreak = false;
            break;

        default:
        Console.WriteLine($"Digite uma letra válida.");
        loopBreak = true;
            break;
    }
    } while (loopBreak || gen.Length > 1);

    if (gen == "m")
    {
        Console.WriteLine($"Qual a sua idade?");
        idadeH = int.Parse(Console.ReadLine());

               
        idadeTotalHomens = idadeTotalHomens+=idadeH;
        
        Console.WriteLine($"Qual o seu peso?");
        Console.ReadLine();
    }
    
    else if(gen == "f")
    {
        Console.WriteLine($"Qual a sua idade?");
        idadeM = int.Parse(Console.ReadLine());

        idadeTotalMulheres = idadeTotalMulheres+=idadeM;

        Console.WriteLine($"Qual o seu peso?");
        Console.ReadLine();
        
    }

}
mediaIdadeHomens = idadeTotalHomens / contadorHomens;
mediaIdadeMulheres = idadeTotalMulheres / contadorMulheres;

Console.WriteLine($"{contadorHomens} homens respoderam a essa pesquisa. A média de idade dos homens é de {mediaIdadeHomens}");
Console.WriteLine($"{contadorMulheres} mulheres respoderam a essa pesquisa. A média de idade das mulheres é de {mediaIdadeMulheres}");


