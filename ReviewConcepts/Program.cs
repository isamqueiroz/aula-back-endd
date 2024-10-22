Console.WriteLine(@"
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+
|               Boas-Vindas              |
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+
|       ▄▄▀▀▀▀▀▀▀▀▀▀▄▄█▄    ▄    █       |
|      █▀             ▀▀█▄   ▀         ▄ |
|    ▄▀                 ▀██   ▄▀▀▀▄▄  ▀  |
|  ▄█▀▄█▀▀▀▀▄     ▄▀▀█▄  ▀█▄  █▄   ▀█    |
| ▄█ ▄▀  ▄▄▄ █   ▄▀▄█▄ ▀█  █▄  ▀█    █   |
|▄█  █   ▀▀▀ █  ▄█ ▀▀▀  █   █▄  █    █   |
|██   ▀▄   ▄█▀   ▀▄▄▄▄▄█▀   ▀█  █▄   █   |
|██     ▀▀▀                  █ ▄█    █   |
|██                     █    ██▀    █▄   |
|██                     █    █       ▀▀█▄|
|██                    █     █       ▄▄██|
| ██                  ▄▀     █       ▀▀█▄|
| ▀█      █         ▄█▀      █       ▄▄██|
| ▄██▄     ▀▀▀▄▄▄▄▀▀         █       ▀▀█▄|
|  ▀▀▀▀                      █▄▄▄▄▄▄▄▄▄██|
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+");




Console.WriteLine($"Ola, digite seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Olá {nome}, Qual é o seu sobrenome?: ");
string sobrenome = Console.ReadLine()!;



Console.WriteLine($"Digite sua data de nascimento: ");
//   DateOnly dataNascimento = new DateOnly(2008, 2, 22);
DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());
        DateOnly dataAtual = DateOnly.FromDateTime(DateTime.Now);
  
        Console.WriteLine("Data de Nascimento: " + dataNascimento);
        Console.WriteLine("Data Atual: " + dataAtual);
  
        int idade = dataAtual.Year - dataNascimento.Year;
        if (dataAtual < dataNascimento.AddYears(idade))
        {
            idade--;
        }

        Console.WriteLine("Idade: " + idade);

    


Console.WriteLine($"Digite seu email: ");
string email = Console.ReadLine()!;

Console.WriteLine($"Digite seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu CPF: ");
UInt128 CPF = UInt128.Parse(Console.ReadLine()!);


Console.WriteLine($"Digite seu endereço: ");
string endereço = Console.ReadLine()!;

Console.WriteLine($"Qual é o seu Estado Civil?: ");
string EstadoCivil = Console.ReadLine()!;


Console.WriteLine($"Obrigado, {nome} {sobrenome} :) ");


Console.Clear();
Console.WriteLine(@$" ---------- CADASTRO CONCLUIDO ----------
 Nome: {nome} {sobrenome}
 Data de nascimento: {dataNascimento} 
 Idade: {idade}
 Contato: {telefone} 
 CPF: {CPF} 
 Endereço: {endereço} 
 Estado Civil: {EstadoCivil}
 ---------- Obrigado pelo cadastro ;) ----------");
