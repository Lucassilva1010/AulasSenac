using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using ClassesMetodosNamespaceA;

namespace ClassesMetodosNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa objPessoa = new Pessoa();
           
            objPessoa._nome = "Lucas";
            objPessoa.ApresentaNaTela();
            Console.WriteLine(objPessoa.Frases());

            Animal objAnimal = new Animal();
            objAnimal.nomeAnimal = "Dory";
            objAnimal.tipoAnimal = "Cachorra";
        }
    }
}
