// Perguntar aos usuário 10 vezes o sexo( m - masculino ou f - feminino)
// e se gostou do produto (sim ou não)
//Depois, calcular quantas pessoas responderam sim
// quantas pessoas responderam não
// quantas mulheres responderam sim
// a porcentagem de homens que responderam não
// quantos homens foram analisados

int contadorM = 0;
int contadorF = 0;
int contadorSM = 0;
int contadorNM = 0;
int contadorSF = 0;
int contadorNF = 0;
bool loopBreak = true;
string gen;
string respM;

for (var i = 1; i <= 10; i++)
{
    do
    {
        
    Console.WriteLine($"Qual o sexo que você se identifica? 'm' para masculino - 'f' para feminino");
    gen =(Console.ReadLine().ToLower());

    switch (gen)
    {
        case "m":
        contadorM++;
        loopBreak = false;
            break;

        case "f":
        contadorF++;
        loopBreak = false;
            break;

        default:
        Console.WriteLine($"Digite uma letra válida.");
        loopBreak = true;
            break;
    }
    } while (loopBreak || gen.Length > 1);



    if(gen == "m")
    {
        do
        {
            
        Console.WriteLine($"Você gostou do nosso produto? 's' para sim - 'n' para não");
        respM = Console.ReadLine();

        switch (respM)
        {
            case "s":
            contadorSM++;
            loopBreak = false;
                break;

            case "n":
            contadorNM++;
            loopBreak = false;
                break;

            default:
            Console.WriteLine($"Digite uma letra válida.");
            loopBreak = true;
                break;
        }
        
        } while (loopBreak || respM.Length > 1 );
    }

        else if(gen == "f")
    {
        do
        {
            
        Console.WriteLine($"Você gostou do nosso produto? 's' para sim - 'n' para não");
        respM = Console.ReadLine();

        switch (respM)
        {
            case "s":
            contadorSF++;
            loopBreak = false;
                break;

            case "n":
            contadorNF++;
            loopBreak = false;
                break;

            default:
            Console.WriteLine($"Digite uma letra válida.");
            loopBreak = true;
                break;
        }
        
        } while (loopBreak || respM.Length > 1);
    }
}

double porcentagem = (((double)contadorNM / contadorM))*100;

Console.WriteLine($"{contadorSM + contadorSF} pessoas respoderam sim.");
Console.WriteLine($"{contadorNM + contadorNF} pessoas respoderam não.");
Console.WriteLine($"{contadorSF} mulheres respoderam sim.");
Console.WriteLine($"{porcentagem}% de homens respoderam não.");
Console.WriteLine($"{contadorM} homens respoderam a pesquisa.");


// Console.WriteLine($"{contadorM}, {contadorF}, {contadorSM}, {contadorNM}, {contadorSF}, {contadorNF}");




    
    

    