

using Calculador.Classes;

Console.WriteLine($"Bem Vindo ao programa Calculador ");

Calculadora calculadora = new Calculadora();


Console.WriteLine($"Digite o primeiro numero:");
float numero1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo numero:");
float numero2 = float.Parse(Console.ReadLine()!);

Console.WriteLine(@$"Escolha uma operação:
1-Somar
2-Subtrair
3-Multiplicar
4-Divisão");
int operação = int.Parse(Console.ReadLine()!);
if (operação == 1)
{
    calculadora.Somar (numero1, numero2);
    Console.WriteLine($"");
}
else if (operação == 2)
{
    calculadora.Subtrair (numero1, numero2);
    Console.WriteLine($"");
}
else if (operação == 3)
{
    calculadora.Multiplicar (numero1, numero2);
    Console.WriteLine($"");
}
else
{
    calculadora.Divisão (numero1, numero2);
    Console.WriteLine($"");
}

// calculadora.Somar(numero1, numero2);
// calculadora.Subtrair(numero1, numero2);
// calculadora.Multiplicar(numero1,numero2);
// calculadora.Divisão(numero1, numero2);



        

