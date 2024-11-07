using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Alunos
    {     

            public Alunos (){
                Console.WriteLine($"Sua matricula foi realizada");
            } 

        public string Nome{ get; set; }
        
        public int Idade { get; set; }
        public string Matricula { get; set; }

        public Alunos(string nm,int Id , string ma){

        Nome = nm;
        Idade = Id;
        Matricula = ma;


        }

    public void ExibirDados()
    {
        Console.WriteLine(@$"
        Nome : {Nome}
        Idade : {Idade}
        Matricula : {Matricula}
      
         ");
        
    }

    }
    }
