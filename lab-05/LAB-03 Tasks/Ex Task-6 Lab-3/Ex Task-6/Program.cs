using System;

namespace Findaverage
{
    class Program
    {
        static void Main(string[] args)
        {
            average();
        }

        private static void average()
        {
            Console.Write("Number of Students are:");
            string num = Console.ReadLine();
            int n = int.Parse(num);
            int sum = 0;

            for (int i = 1; i<=n; i++)
            {
                Console.Write($"Enter marks of Students {i}:");
                string marks = Console.ReadLine();
                int m = int.Parse(marks);

                sum = sum + m; 
            }
            int avg = sum/ n;
            Console.Write($"\nAverage Result of class is {avg}\n");

        }
    }

}