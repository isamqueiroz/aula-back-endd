int qnthomem = 0;
int qntmulher = 0;
int gstesporte = 0;
int ngstesporte = 0;
Console.WriteLine("Quantas pessoas tem na sua mesa:");
int qntdenrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qntdenrevistados; i++)
{
    Console.WriteLine("Qual seu sexo:");
    string sexo = Console.ReadLine();
    if (sexo == "f")
    {
        qntmulher++;
    }
    else { qnthomem++; }

    Console.WriteLine("Você gosta de esporte:(s/n)");
    string qntesporte = Console.ReadLine();
    if (qntesporte == "s")
    {
        gstesporte++;
    }
    else
    {
        ngstesporte++;
    }
}
    float percentual = (100/ qntdenrevistados) * ngstesporte;

Console.Clear();

Console.WriteLine($"Quantidade de pessoas que responderam SIM: {qntmulher}");
Console.WriteLine($"Quantidade de pessoas que responderam NÃO: {qnthomem}");
Console.WriteLine($"Mulheres que responderam sim: {gstesporte}");
Console.WriteLine($"Homens que não responderam: {ngstesporte}");
Console.WriteLine($"{percentual}% das pessas gostam de esportes");


