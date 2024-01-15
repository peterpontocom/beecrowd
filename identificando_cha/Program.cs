using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int tipoReal = int.Parse(Console.ReadLine());

            string[] respostasStr = Console.ReadLine().Split(' ');
            int[] respostas = new int[5];

            for (int i = 0; i < 5; i++)
            {
                respostas[i] = int.Parse(respostasStr[i]);
            }

            int corretas = 0;
            for (int i = 0; i < 5; i++)
            {
                if (respostas[i] == tipoReal)
                {
                    corretas++;
                }
            }

            Console.WriteLine(corretas);
        }
    }
}