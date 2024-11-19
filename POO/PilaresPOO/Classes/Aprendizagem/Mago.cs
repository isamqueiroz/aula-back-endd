
namespace PilaresPOO.Classes.Aprendizagem
{
    public class Mago : Personagem
    {
        public override void Atacar ()
        {
            Console.WriteLine($"o Mago lança o seu feitiço!🧙‍♂️");
            
        }

         public override void Defender ()
        {
            Console.WriteLine($"o Mago esta lançando um feitiço de defesa!🧙‍♂️");
            
        }

    }
}