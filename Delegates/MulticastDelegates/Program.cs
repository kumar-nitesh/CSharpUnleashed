using System;

namespace MulticastDelegates
{
    class Program
    {
        public delegate void MultiCastDelegateCalc(int a, int b);

        static void Main(string[] args)
        {
            MultiCastDelegateCalc calc = Calculate.Add;

            calc += Calculate.Sub;

            calc(10, 5);

            calc -= Calculate.Add;

            calc(8, 7);
        }
    }

    public class Calculate
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition Value: " + (a + b));
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("Substraction Value: " + (a - b));
        }
    }
}
