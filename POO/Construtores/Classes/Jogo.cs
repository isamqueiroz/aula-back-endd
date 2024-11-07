using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
           public Jogo (){
                Console.WriteLine($"O seu Jogo foi Criado");
            } 

        public string Nome{ get; set; }
        
        public int Lancamento { get; set; }
        public string Genero { get; set; }
        public float Preco { get; set; }

        public Jogo(string nm,int lc , string gn, float pc){

        Nome = nm;
        Lancamento = lc;
        Genero = gn;
        Preco = pc;



        }

    public void ExibirDados()
    {
        Console.WriteLine(@$"
        Nome do jogo : {Nome}
        data de Lancamento : {Lancamento}
        Genero do jogo : {Genero} 
        Preco do jogo: {Preco}
      
         ");
        
    }
    }
}