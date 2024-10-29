
  // Cria um vetor para armazenar as temperaturas de cada mês
        double[] temperaturas = new double[12];
        
        // Entrada de dados
        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Digite a temperatura média do mês {i + 1}: ");
            temperaturas[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Inicializa as variáveis para maior e menor temperatura
        double maiorTemperatura = temperaturas[0];
        double menorTemperatura = temperaturas[0];

        // Calcula a maior e a menor temperatura
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > maiorTemperatura)
            {
                maiorTemperatura = temperaturas[i];
            }
            if (temperaturas[i] < menorTemperatura)
            {
                menorTemperatura = temperaturas[i];
            }
        }

        // Saída dos resultados
        Console.WriteLine($"A maior temperatura do ano foi: {maiorTemperatura}°C");
        Console.WriteLine($"A menor temperatura do ano foi: {menorTemperatura}°C");
    