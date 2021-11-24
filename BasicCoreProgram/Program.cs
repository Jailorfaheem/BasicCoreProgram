using System;

namespace BasicCoreProgramming
{
    class SwapNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Nubers :");
            Console.Write("\nEnter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Swapping numbers
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\n AFTER SWAPPING NUMBER");
            Console.WriteLine("\nFirst Number :" + num1);
            Console.WriteLine("Second Number :" + num2);

        }
    }
}