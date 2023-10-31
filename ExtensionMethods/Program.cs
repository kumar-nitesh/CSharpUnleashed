using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            Console.WriteLine(x.factorial());
            Console.WriteLine(x.addOne());
            Console.ReadLine();
        }
    }
}
