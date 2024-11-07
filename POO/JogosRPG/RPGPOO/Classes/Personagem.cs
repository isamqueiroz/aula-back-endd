using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPOO.Classes
{
    public class Personagem
    {
        public string Nome;
        public int Idade;
        public string Armadura;
        public string IA;

        public void Atacar()
        {
            Console.WriteLine("O personagem atacou!");
        }

        public void Defender()
        {
            Console.WriteLine($"O personagem defendeu!");

        }

        public void RestaurarArmadura()
        {
            Console.WriteLine("O personagem restaurou a armadura!");
        }
    }
}
