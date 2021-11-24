using System;

namespace BasicCoreProgramming
{
    class PrimeFactor
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your integer number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " is a prime factor of " + num);
                }
            }
        }
    }
}