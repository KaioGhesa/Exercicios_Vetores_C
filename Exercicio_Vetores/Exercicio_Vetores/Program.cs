using System;
using System.Globalization;

namespace Exercicio_Vetores
{
     class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Quantidade de quartos alugados: ");
            int n = int.Parse(Console.ReadLine());

            Client[] vect = new Client[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Client(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i= 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
