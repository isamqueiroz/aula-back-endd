using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasses.Classes
{

    public class Veiculo
    {
       public string marca;
       public string modelo;
       public string cor;
       public string potencia;
       public int qtdPortas;


       public void acelerar(string acelerar = "barulho generico")
       {
        Console.WriteLine($"O veiculo da marca {marca} do modelo {modelo} está acelerando: {acelerar}");
       }

       public void ligar(string ligar = "Ligando")
        {
            Console.WriteLine($"O veiculo da marca {marca} do modelo {modelo} vai ligar : {ligar}");
        }

        public void Desligar (string desligar = "Desligando")
        {
            Console.WriteLine($"O veiculo da marca {marca} do modelo {modelo} vai desligar: {desligar}");
        }

        public void Freiar (string freiar = "Freiando")
        {
            Console.WriteLine($"O veiculo da marca {marca} do modelo {modelo} vai freiar: {freiar}");
            
        }
    }
}