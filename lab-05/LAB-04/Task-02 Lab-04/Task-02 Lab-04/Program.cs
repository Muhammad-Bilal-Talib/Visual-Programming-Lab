using System;

namespace Ex_02_Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "Hello ", "and ", "Welcome ", "to ", "this ", "Demo!" };
            Console.WriteLine(merge_array(s));
        }
        private static string merge_array(string[] s)
        {
            string m = string.Concat(s);
            return m;
        }
    }
}