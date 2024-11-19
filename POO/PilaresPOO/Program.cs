
using System.Runtime.Serialization;
using PilaresPOO.Classes.Pilares;

Console.Clear();

ContaCorrente ctIsa = new ContaCorrente();
ctIsa.Titular = "Isa diva meiismo😘";
ctIsa.Depositar(2000000f);

Console.WriteLine($"Titular da conta:  {ctIsa.Titular}");
Console.WriteLine($"Saldo da conta: {ctIsa.GetSaldo()} ");

float ValorSacado = ctIsa.sacar (1000f);

Console.WriteLine($"Valor do saque: {ValorSacado}");
Console.WriteLine($"Novo Saldo : {ValorSacado}");








