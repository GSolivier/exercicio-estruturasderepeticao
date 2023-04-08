int num1 = 0, num2 = 1, resultado = 0;
        
Console.Write("Série de Fibonacci até que o valor seja maior que 500:\n");
Console.Write($"{num1} {num2} ");
        
resultado = num1 + num2;
        
while (resultado < 650) 
{
    Console.Write($"{resultado} ");
    num1 = num2;
    num2 = resultado;
    resultado = num1 + num2;
 }
        