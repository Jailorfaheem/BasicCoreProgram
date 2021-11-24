using System;

namespace BasicCoreProgramming
{
    class HarmonicNumber
    {
        public static void Main(string[] args)
        {
            double sum = 0;

            Console.Write("Enter number of terms : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nHarmonic series is    ");
            for (int i = 1; i <= num; i++)
            {
                Console.Write("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.WriteLine("\n\nsum of harmonic series upto {0} terms : {1}", num, sum);
        }
    }
}