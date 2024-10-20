using System;

namespace ConvertintoCelsius
{
    class Program
{
    static void Main(string[] args)
    {
            Console.Write("Enter value in Fahrenheit:");
            string value = Console.ReadLine();
            double f = double.Parse(value);

            
            Console.WriteLine($"{f} into  degrees Celsius is: {FahrenheitToCelsius(f);}");
        }

    public static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}

}