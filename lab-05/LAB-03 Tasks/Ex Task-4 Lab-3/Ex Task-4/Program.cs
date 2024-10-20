using System;

namespace Findfictorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value to find Fictorial:");
            string s = Console.ReadLine();
            int num = int.Parse(s);


            Console.WriteLine($"{num} Fictorial is: {Findfictorial(num)} ");
        }

        private static int Findfictorial(int num)
        {
            if (num==0 || num==1)
            {
                return 1;
            }

            int factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }

}