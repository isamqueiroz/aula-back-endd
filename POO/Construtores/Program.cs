using System.Runtime.InteropServices;
using Construtores.Classes;


Console.WriteLine($"---------------------Area de Veiculos------------------- ");

Veiculos Carro1 = new Veiculos("Ford", "Ka", 2000, "Vermelho");
Veiculos Carro2 = new Veiculos("Ford","Mustang", 2000, "Azul");


Carro1.ExibirDados();
Carro2.ExibirDados();

Console.WriteLine($"---------------------Area de Matriculas------------------- ");

Alunos aluno1 = new Alunos("Isadora",16, "0001110945607sp");
Alunos aluno2 = new Alunos("Matheus", 17, "0001103252501sp");

aluno1.ExibirDados();
aluno2.ExibirDados();


Console.WriteLine($"---------------------Area de Jogos------------------- ");

List<Jogo> estoqueJogos = new List<Jogo>();


Jogo jogo1 = new Jogo("Free Fire", 2015, "Acao", 2000);
Jogo jogo2 = new Jogo("Roblox", 2018, "entretenimento", 200);
Jogo jogo3 = new Jogo("c0dutty", 2003, "Acao", 2090);
Jogo jogo4 = new Jogo("minecraft", 2014, "entretenimento", 20087);

estoqueJogos.Add(jogo1);
estoqueJogos.Add(jogo2);  
estoqueJogos.Add(jogo3);  
estoqueJogos.Add(jogo4);  

// MERCADO, EXEMPLO:
List<Produto> ListaMercado = new List<Produto>();

Produto banana = new Produto("Banana", 5);
Produto laranja = new Produto("Laranja", 3);
Produto pera = new Produto("Pera", 4);


foreach (var jogo in estoqueJogos){
    jogo.ExibirDados();
    Console.WriteLine();
    
}

Console.WriteLine(@$"

------------------------------------------
|                Bem Vindo               |
------------------------------------------
|          Faça seu Cadastro!            |
|    1) Cadastrar Jogo                   |
|    2) Listar Jogos                     |
|    3) Sair                             |
|________________________________________| 
");

string resposta = Console.ReadLine();

if (resposta == "1"){

    // cadastrar um jogo

}else if (resposta == "2"){

    // listar os jogos

}else{
    // mensagem de tchau
}