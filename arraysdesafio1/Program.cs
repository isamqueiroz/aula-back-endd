int [] numeros = new int[6];
int par = 0, impar = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite um {i + 1}ª numero:");
    int NumeroDigitado = int.Parse(Console.ReadLine());


    if (NumeroDigitado %2 == 0)
    {
  
     par++;
     
    } else
    {
        impar++;
    }
}



Console.WriteLine($"Numeros pares: {par}");
for (int i = 0; i < numeros.length; i++) 
{
    if(numeros[i] % 2 == 0 ){
        Console.Write($"{numeros[i]}");
        
    }
}

Console.WriteLine();
Console.WriteLine();


Console.WriteLine($"Numeros impares: {impar}");
for (int i = 0; i < numeros.length; i++) {
    if(numeros[i] % 2 == 1){
        Console.WriteLine($"{numeros[i]}");
        
    }
}


