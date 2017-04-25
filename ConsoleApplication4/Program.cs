using System;

namespace CheckIfNumberIsSemiprime
{
    public class Jou
    {
        //check if number is semiprime
        static public bool Run(int number)
        {
            int a = 2, b = 0;
            while (b < 3 && number != 1)
            {
                if ((number % a) == 0)
                { number /= a; b++; }
                else a++;
            }

            bool isSemiprime = b == 2;
            return isSemiprime;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Jou.Run(2));
            Console.ReadKey();
        }
    }
}