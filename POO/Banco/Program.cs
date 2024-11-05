using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem Vindo ao nubanquinho");
Console.WriteLine();

ContaCorrente ContaIsa = new ContaCorrente();
ContaCorrente ContaEmilly = new ContaCorrente();

ContaIsa.Titular = "Isa";
ContaIsa.Depositar(10000000000f) ;
 
ContaIsa.Titular = "Emilly";
ContaEmilly.Depositar(10000000000f) ;

Console.WriteLine($"Conta da {ContaIsa} tem R${ContaIsa.Saldo}");

Console.WriteLine($"Conta da {ContaEmilly} tem R${ContaEmilly.Saldo}");


ContaIsa.Sacar(250f) ;

Console.WriteLine($"Voce sacou e sua conta ficou com R${ContaIsa.Saldo}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Conta da {ContaIsa.Titular} tem R$ {ContaIsa.Saldo}");
Console.WriteLine($"Conta da {ContaEmilly.Titular} tem R$ {ContaEmilly.Saldo}");
Console.WriteLine();


