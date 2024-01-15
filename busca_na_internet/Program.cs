using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int casosTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosTeste; i++)
            {
                int P3 = int.Parse(Console.ReadLine());

                int P2 = 2 * P3;
                int P1 = 2 * P2;

                Console.WriteLine(P1);
            }
        }
    }

}