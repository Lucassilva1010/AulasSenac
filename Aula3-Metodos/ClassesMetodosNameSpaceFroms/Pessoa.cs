using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosNameSpaceFroms
{
    internal class Pessoa
    {
        internal string nome;

        public string Nomes()
        {

            return teste1();
          
        }
        public  string  teste1()
        {
            return teste2(); ;
        }

        private string teste2()
        {
            return "Brenda" + Numero();
        }

        private double Numero()
        {
            double numero = 10.0;
            return numero;
        }
    }
}
