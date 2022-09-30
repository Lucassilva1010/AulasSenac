using System;
namespace Aula02
{
    class Exemplo2
    {
        static void Main(string[] args)
        {
            int numero1, numero2;//variavel do tipo inteiro
            double resultado;//variavel do tipo real
            string nome;

            Console.WriteLine("Digite o 1ª numero ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2ª numero ");
            numero2 = int.Parse(Console.ReadLine());

            resultado = numero1 + numero2;
            Console.WriteLine("O resultado da soma é: "+resultado);

        }
    }
}
