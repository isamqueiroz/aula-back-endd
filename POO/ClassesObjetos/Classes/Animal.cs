using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Animal
    {
        public string raça;
        public string Cor;

        public string nome;

        public int idade;

        public void FazerBarulho(string barulho)
        {
            Console.WriteLine($"Som do animal: {barulho}");
        }

        public void Envelhecer()
        {
            idade = idade + 1;
        }



    }
}