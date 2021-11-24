using System;

namespace BasicCoreProgramming
{
    class PowerOf2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int powerOfTwo = 1;
            while (i <= num)
            {
                Console.WriteLine(i + " " + powerOfTwo);
                powerOfTwo = 2 * powerOfTwo;
                i = i + 1;
            }

        }
    }
}