
int totalSim = 0;
int totalNao = 0;
int mulheresSim = 0;
int homensNao = 0;
int totalHomens = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Entrevista {i + 1} - Informe o sexo (M/F): ");
    string sexo = Console.ReadLine();

    Console.Write($"Entrevista {i + 1} - Você gostou do produto ? (sim/não): ");
    string resposta = Console.ReadLine();
    if (resposta == "sim")
    {
        totalSim++;

        if (sexo == "F")
        {
            mulheresSim++;
        }
    }
    else if (resposta == "não" || resposta == "nao")
    {
    }

}



Console.WriteLine($"quantidade de mulheres q gostaram: {mulheresSim}");
    Console.WriteLine($"quantidade de homens q nao gostaram : {homensNao}");
    Console.WriteLine($"total de entrevistados: {mulheresSim + homensNao}");
    Console.WriteLine($"Quantidade de pessoas que nao gostaram: {totalNao}");
    Console.WriteLine($"Quantidade de pessoas que gostaram: {totalSim}");
    Console.WriteLine($"Quantidade de homens: {totalHomens}");

