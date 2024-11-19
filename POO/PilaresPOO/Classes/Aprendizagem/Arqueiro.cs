

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Arqueiro : Personagem
    {
        public override void Atacar ()
        {
            Console.WriteLine($"o Arqueiro dispara uma flecha!🏹");
            
        }
        public override void Defender ()
        {
            Console.WriteLine($"o Arqueiro se defende com uma flecha!🏹");
            
        }
    }
}