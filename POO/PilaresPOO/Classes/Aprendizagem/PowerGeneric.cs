using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class PowerGeneric : Personagem
    {
         public override void Atacar ()
         {
            Console.WriteLine($"o Personagem Generic esta atacando!💪");
            
         }

         public override void Defender ()
         {
             Console.WriteLine($"o Personagem Generic esta se defendendo!💪");
            
        }
    }
}