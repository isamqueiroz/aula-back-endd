 using RPGPOO.Classes;
       
        Console.Write("Digite o nome do seu personagem: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade do seu personagem: ");
        int Idade = int.Parse(Console.ReadLine());

        Console.Write("Informe o nome da armadura do personagem: ");
        string Armadura = Console.ReadLine();

        Console.Write("Informe a I.A que o personagem utiliza: ");
        string IA = Console.ReadLine();

       
     

    
        Console.WriteLine();
        Console.WriteLine($"{nome},");
        Console.WriteLine($"{Idade},");
        Console.WriteLine($"{Armadura},");
        Console.WriteLine($"{IA}");

        Personagem guerreiro = new Personagem();

        guerreiro.Atacar();
        guerreiro.RestaurarArmadura();
        guerreiro.Defender();
    