
namespace Banco.Classes
{
    public class ContaCorrente
    {
        public int NumeroConta;

        public string? Titular;

        public float Saldo;

     public void Depositar(float Valor)
     {
        Saldo = Saldo + Valor;
     }

     public void Sacar(float Valor)
     {
        Saldo = Saldo - Valor;
     }
    }
}