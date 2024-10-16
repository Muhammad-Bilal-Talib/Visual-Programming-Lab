using System;

namespace Ex_Task
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            char ch;
            do
            {
                Console.Write("Enter Your Choice:");
                string choice = Console.ReadLine();
                ch = char.Parse(choice);

                switch (ch)
                {
                    case '1':
                        sum();
                        break;
                    case '2':
                        subtract();
                        break;
                    case '3':
                        multiply();
                        break;
                    case '4':
                        division();
                        break;
                    case '5':
                        break;

                }
            } while (ch != '5');


        }

        private static void sum()
        {
            Console.Write("Enter a Value:");
            string num1 = Console.ReadLine();
            Console.Write("Enter a Value:");
            string num2 = Console.ReadLine();

            int a = int.Parse(num1);
            int b = int.Parse(num2);


            Console.WriteLine($"Sum of {num1} and {num2} is:{a + b}\n\n");


        }
        private static void subtract()
        {
            Console.Write("Enter a Value:");
            string num1 = Console.ReadLine();
            Console.Write("Enter a Value:");
            string num2 = Console.ReadLine();

            int a = int.Parse(num1);
            int b = int.Parse(num2);


            Console.WriteLine($"Sum of {num1} and {num2} is:{a - b}\n\n");


        }
        private static void multiply()
        {
            Console.Write("Enter a Value:");
            string num1 = Console.ReadLine();
            Console.Write("Enter a Value:");
            string num2 = Console.ReadLine();

            int a = int.Parse(num1);
            int b = int.Parse(num2);


            Console.WriteLine($"Sum of {num1} and {num2} is:{a * b}\n\n");


        }
        private static void division()
        {
            Console.Write("Enter a Value:");
            string num1 = Console.ReadLine();
            Console.Write("Enter a Value:");
            string num2 = Console.ReadLine();

            int a = int.Parse(num1);
            int b = int.Parse(num2);


            Console.WriteLine($"Sum of {num1} and {num2} is:{a / b}\n\n");


        }

    }
}

