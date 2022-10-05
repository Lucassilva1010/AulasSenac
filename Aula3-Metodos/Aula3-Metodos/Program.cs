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
                      
            Console.WriteLine("Aqui nova forma "+Soma(100,10));
            Console.WriteLine("Aqui é o multiplica: ");
            Multiplica();
            Console.WriteLine(" valor so salario");
            double salario = double.Parse(Console.ReadLine());
            Aumento(salario, 0.5);
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

        static double Aumento(double salario, double aumento)
        {
           

            if (salario>1000)
            {
               return salario = salario + (salario * aumento);
            }
            else
            {
                return salario = salario - (salario * 0.5);    
            }
            

        }
    }
}
