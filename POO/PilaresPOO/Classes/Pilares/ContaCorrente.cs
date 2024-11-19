
namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {

        public float Limite { get; set; }

        public bool Transferir(float valor, Conta ContaDestino)
        {
            return false;
        }

        public override bool Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override float sacar(float valor)
        {

            if (valor <= 0)
            {
                Saldo = Saldo - valor;
                return valor;
            }
            else
            {
                return 0;
            }

        }
    }
}