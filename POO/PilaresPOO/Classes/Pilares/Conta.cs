
using System.Security.Cryptography.X509Certificates;

namespace PilaresPOO.Classes.Pilares
{
    public abstract class Conta
    {

        protected float Saldo;
        public string? Titular;

        public abstract float sacar(float sacar);


        public abstract bool Depositar(float valor);

        public float GetSaldo()
        {
            return Saldo;
        }
    }
}
