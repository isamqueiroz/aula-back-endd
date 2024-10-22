//faça um programa que rode 10 vezes e pergunte o sexo 
//das pessoas e ao final informeÇ

//quantidade de pessoas do sexo feminino
//quantidade de pessoas do sexo masculino


        int contFeminino = 0;
        int contMasculino = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o sexo da pessoa (f para feminino, m para masculino): ");
            string input = Console.ReadLine().ToLower(); // Lê a entrada e transforma em minúsculo

            if (input == "f")
            {
                contFeminino++;
            }
            else if (input == "m")
            {
                contMasculino++;
            }
            else
            {
                Console.WriteLine("Sexo inválido, por favor digite 'f' ou 'm'.");
                i--; 
            }
        }

        Console.WriteLine($"Quantidade de pessoas do sexo feminino: {contFeminino}");
        Console.WriteLine($"Quantidade de pessoas do sexo masculino: {contMasculino}");
    

