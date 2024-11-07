using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Veiculos
    {     

            public Veiculos (){
                Console.WriteLine($"O seu carro foi Criado");
            } 

        public string  Marca { get; set; }
        
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }

        public Veiculos(string ma, string md, int an, string cr){

        Marca = ma;
        Modelo = md;
        Ano = an;
        Cor = cr;
        }

    public void ExibirDados()
    {
        Console.WriteLine(@$"
        Marca : {Marca}
        Modelo : {Modelo}
        Ano : {Ano}
        Cor : {Cor}
         ");
        
    }

    }
}