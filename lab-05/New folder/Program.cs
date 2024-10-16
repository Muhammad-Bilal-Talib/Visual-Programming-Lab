using System;
using System.Linq;

namespace act1
{
    class hello
{
    static void Main(string[] args)
    {
            double a = 98, b = 0;

             double result = 0;


            try
            {
                result = SafeDivision(a,b);
                Console.WriteLine($"{a} divided by {b} = {result}");

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Attempt Divided by Zero");
            }
    }

        static double SafeDivision(double x, double y)
        {
            if (y != 0)
            {
                return x / y; // This line will be executed if y is not 0
            }
            else
            {
                throw new System.DivideByZeroException();
            }
        }
    }


}
