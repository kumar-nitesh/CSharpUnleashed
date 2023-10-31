using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            object x = "hello";
            Foo(x);
        }

        static void Foo(object a)
        {
            Console.WriteLine("Object overload called");
        }

        static void Foo(string a)
        {
            Console.WriteLine("String overload called");
        }
    }
}
