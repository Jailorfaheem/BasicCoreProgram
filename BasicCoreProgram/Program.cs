using System;

namespace BasicCoreProgramming
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            //Convert user input into integer
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}