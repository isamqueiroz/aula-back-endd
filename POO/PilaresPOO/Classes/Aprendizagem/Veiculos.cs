using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Veiculos
    {
        public string Nome {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public string Cor {get; set;}
        public int Potencia {get; set;}
        public int qtdPassageiros {get; set;}


        public void Ligar(){
            Console.WriteLine($"o veiculo esta ligando");
        }

        public void Desligar(){
          Console.WriteLine($"o veiculo esta Desligando");  
        }

        public void Buzinar(){
            Console.WriteLine("o veiculo buzinou");
        }
}

}
