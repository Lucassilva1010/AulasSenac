using System;// essa é responsavel por aplicar comandos de entrada e saida de dados; 

namespace Aula01 { //é o espaço entre as chaves
 class Exemplo01// representação de um container
    {
       static void Main(string[] args)//metodo Principal
        {
            int numero;
            double dinheiro;
          
            Console.WriteLine("Digite um numero! ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor em dinheiro com virgula! ");
            dinheiro = double.Parse(Console.ReadLine());
        }
     
    }

}

