using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas = {"Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};

            int numeroInicial, numeroFinal;
            Console.Write("Digite o número inicial: ");
            numeroInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite o número final: ");
            numeroFinal = int.Parse(Console.ReadLine());

            for(int i = numeroInicial; i <= numeroFinal; i++)
            {
                if (i > 6)
                {
                    Console.Write($"{notas[(i % 6) - 1]} ");
                    continue;
                }
                
                Console.Write($"{notas[i]} ");
            }
        }
    }
}
