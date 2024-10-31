// importando as classes de dentro da pasta classes.
using System.Net.Http.Headers;
using ClassesObjetos.Classes;



Animal Urso = new Animal();

Urso.nome = "Sky";
Urso.raça = "Urso Polar";
Urso.Cor = "branca";
Urso.idade = 7;




Animal cachorro = new Animal();

cachorro.nome = "Mel";
cachorro.raça = "Lhasa apso";
cachorro.Cor = "branco e bege";
cachorro.idade = 12;

Console.WriteLine($"Nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"raça do(a) {cachorro.nome}: {cachorro.raça}");
Console.WriteLine($"Cor do(a) {cachorro.nome} : {cachorro.Cor}");
Console.WriteLine($"Idade do(a) {cachorro.nome}: {cachorro.idade}");

Console.WriteLine("");



Console.WriteLine($"Nome do Urso: {Urso.nome}");
Console.WriteLine($"raça do(a) {Urso.nome}: {Urso.raça}");
Console.WriteLine($"Cor do(a) {Urso.nome} : {Urso.Cor}");
Console.WriteLine($"Idade do(a) {Urso.nome}: {Urso.idade}");