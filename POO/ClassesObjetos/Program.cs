// importando as classes de dentro da pasta classes.
using System.Net.Http.Headers;
using ClassesObjetos.Classes;



Animal Urso = new Animal();

Urso.nome = "Sky";
Urso.raça = "Urso Polar";
Urso.Cor = "branca";
Urso.idade = 7;

Animal gatinho = new Animal();

gatinho.nome = "Sol";
gatinho.raça = "vira-lata";
gatinho.Cor = "preta e branca";
gatinho.idade = 5;



Animal cachorro = new Animal();

cachorro.nome = "Mel";
cachorro.raça = "Lhasa apso";
cachorro.Cor = "branco e bege";
cachorro.idade = 12;


cachorro.FazerBarulho("AU AU AU");
Console.WriteLine($"Idade de {cachorro.nome} é {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"a nova Idade de {cachorro.nome} é {cachorro.idade}");

Console.WriteLine("");

Urso.FazerBarulho("UARRR UARRR UARRR");
Console.WriteLine($"Idade de {Urso.nome} é {Urso.idade}");
Urso.Envelhecer();
Console.WriteLine($"a nova Idade de {Urso.nome} é {Urso.idade}");

Console.WriteLine("");
gatinho.FazerBarulho("MIAU MIAUUUUUUUU MIAUUUUUUUUU");
Console.WriteLine($"Idade de {gatinho.nome} é {gatinho.idade}");
gatinho.Envelhecer();
Console.WriteLine($"a nova Idade de {gatinho.nome} é {gatinho.idade}");







