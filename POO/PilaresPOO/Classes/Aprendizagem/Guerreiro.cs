

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Guerreiro : Personagem
    {

public override void Atacar ()
        {
            Console.WriteLine($"o Guerreiro ataca com sua espada!⚔️");
            
        }

         public override void Defender ()
        {
            Console.WriteLine($"o Guerreiro esta se defendendo com sua espada!⚔️");
            
        }

    }
}