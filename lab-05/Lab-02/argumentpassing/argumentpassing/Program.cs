using System;

namespace argumentpassing
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length>0)
            {
                Console.WriteLine(args[0]);
                Console.WriteLine(args[1]);
                Console.WriteLine(args[2]);
            }
        }
    }
}
