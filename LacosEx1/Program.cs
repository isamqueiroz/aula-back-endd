Console.WriteLine(@"
*------------------------*
*         Qual           *
*         Seu            *
*        Genero          *
*------------------------*");

int qtdHomem = 0;
int qtdMulher = 0;
int qtdEsportes = 0;
int qtdNao = 0;

Console.WriteLine($"quantas pessoas tem na sua mesa");
int qtddeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtddeEntrevistados; i++){

    Console.WriteLine($"qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"Você gosta de Esportes? s/n");
    string Esportes = Console.ReadLine();
    
    if (sexo == "f")

    {
        qtdMulher++;
    }else
    {
        qtdHomem++;
    }

    if(Esportes == "s")
    {
        qtdEsportes++;
        
    } else{
        qtdNao++;
    }


}
    Console.WriteLine($"quantidade de mulheres: {qtdMulher}");
    Console.WriteLine($"quantidade de homens: {qtdHomem}");
    Console.WriteLine($"total de entrevistados: {qtdMulher + qtdHomem}");
    Console.WriteLine($"Quantidade de pessoas que gostam de esportes: {qtdEsportes}");
    Console.WriteLine($"Quantidade de pessoas que nao gostam de esportes: {qtdNao}");
