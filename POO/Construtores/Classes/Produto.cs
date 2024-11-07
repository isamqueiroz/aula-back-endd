using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Produto
    {
        public string nome { get; set; }
        public int valor { get; set; }

        public Produto(string NOME, int VALOR)
        {
            nome = NOME;
            valor = VALOR;
            
        }
    }
}