using System;
using System.Globalization;

namespace Vetores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            //Metodo de criar um novo vetor e escolher quantidade

            for (int i = 0; i < n; i++)
                //nesse for a quantidade de vezes escolhida pelo usuario vai ser repetida
            {
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                //metodo para ver o vetor da variavel i
            }

            double sum = 0.00;
            //responsavel por fazer a soma 

            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
                //faz a soma da ultima a ultima altura que o programa deu
            }

            double avg = sum / n;
            //faz a divisao pelos numeros fornecidos para dar a media


            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2",CultureInfo.InvariantCulture));
            

        }
    }
}
