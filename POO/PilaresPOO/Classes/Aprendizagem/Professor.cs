using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa
    {

        public string Nome { get; set;}
        public int Idade { get; set; }
        public int NIF { get; set; }
        public float Salario { get; set;}

        public Professor (int _nif)
        {
            
            NIF = _nif;
        }
    }
}