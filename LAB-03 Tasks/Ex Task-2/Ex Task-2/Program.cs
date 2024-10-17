using System;

namespace Ex_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square();
        }

        private static void Square()
        {
            for(int i=1;i<=10;i++)
            {
                int n = i * i;
                Console.WriteLine($"Square of {i} is {n}");
            }

        }
    }
}
