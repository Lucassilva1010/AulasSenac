using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Metodos
{
    class Program
    {
        static void Main(string[] args)//Principal
        {
            Console.WriteLine("Bom dia!");
            Frases();
                      
            Console.WriteLine("Aqui nova forma"+Soma(10,10));
           

            Console.WriteLine("Aqui é o multiplica: ");
            Multiplica();
        }

         static void Frases()//Metodo caracteristico
        {
            Console.WriteLine("Olá pessoal, seja" +
                " bem vindo a uma nova sexta!");
        }
        static double Soma(int n1, int n2)
        {
            double resultado;
            resultado = n1 + n2;
            return resultado;
            
        }

        static void Multiplica()
        {
            int n1 = 10;
            int n2 = 10;
            double resultado;

            resultado = n1 * n2;
            Console.WriteLine(resultado);
        }
    }
}
