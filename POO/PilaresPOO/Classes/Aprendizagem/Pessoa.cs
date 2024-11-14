namespace PilaresPOO.Classes.Aprendizagem
{
    public class Pessoa
    {
        public string? Nome;
        public int Idade;
        public string? CPF;
        public float Peso;
        public float Altura;

        public void Envelhecer()
        {
            Idade++;
        }

        public void Engordar(float kg)
        {
            Peso = Peso + kg;
        }

        public void Emagrecer(float kg)
        {
            Peso = Peso - kg;
        }
    }
}