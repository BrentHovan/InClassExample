using System;

namespace InClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name);
            }
            catch
            {
                Console.WriteLine("Invalid name lol.");
                Console.ReadKey();
            }
        }
    }
}
