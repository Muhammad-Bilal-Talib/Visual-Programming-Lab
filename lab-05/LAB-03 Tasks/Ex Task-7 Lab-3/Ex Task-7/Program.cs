using System;

namespace Findsmallestnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the third number: ");
                int num3 = int.Parse(Console.ReadLine());

               findsmallnum(num1, num2, num3);
               
    }
        private static void findsmallnum(int n1, int n2, int n3)
        {

            int min = n1;

            if (n2 < min)
            {
                min = n2;
            }

            if (n3 < min)
            {
                min = n3;
            }

            Console.WriteLine($"The smallest number is: {min}");

        }
    }

        
    }

