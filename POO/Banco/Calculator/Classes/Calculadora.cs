using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{

    public class Calculadora
    {
        public float Numero01;
        public float Numero02;
 
    }

    public void Somar(float Resultado)
    {
        Resultado = Numero01 + Numero02;
    }
    public void Subtrair (float Resultado)
    {
        Resultado = Numero01 - Numero02;
    }
    public void Multiplicar (float Resultado)
    {
        Resultado = Numero01 * Numero02;
    }
    public void Dividir (float Resultado)
    {
        Resultado = Numero01 / Numero02;
    }
 
}

