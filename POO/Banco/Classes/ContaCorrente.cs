using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculador.Classes
{

}
    public class Calculadora
    {

        public float numero1;
        public float numero2;

        public void Somar (float x, float y)
        {
            float result = x + y;
            Console.WriteLine($"O resultado da soma e: {result}");
            
        }
        public void Subtrair (float x, float y)
        {
            float result = x - y;
            Console.WriteLine($"O resultado da subtração e: {result}");
            
        }
        public void Multiplicar (float x, float y)
        {
            float result = x * y;
            Console.WriteLine($"O resultado da multiplicação e: {result}");
            
        }
        public void Divisão (float x, float y)
        {
            float result = x / y;
            Console.WriteLine($"O resultado da divisão e: {result}");
            
        }
    }