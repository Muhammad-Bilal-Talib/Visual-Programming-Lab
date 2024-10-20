using System;

namespace Findevenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value to check Even Odd:");
            string getval = Console.ReadLine();
            int num1 = int.Parse(getval);

            checknum(num1);
        }

        private static void checknum(int num)
        {
            if (num%2==0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }

        }
    }

}