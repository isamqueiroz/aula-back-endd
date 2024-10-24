int [] num = new int[6];

int numPar = 0;
int numImpar = 0;

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Digite um numero:");
    num [i] = int.Parse(Console.ReadLine());


    if (num[i] %2 == 0)
    {
  
     numPar++;
     
    } else
    {
        numImpar++;
    }
}

Console.WriteLine($"Numeros pares: {numPar}");
Console.WriteLine($"Numeros impares: {numImpar}");