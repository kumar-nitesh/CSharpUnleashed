using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();

            // Create Delegate.
            DelegateCalc delegateCalc = null;

            // Point Delegate to Add function.
            delegateCalc = calc.Add;

            int res = delegateCalc.Invoke(8, 4);
            Console.WriteLine("Addition : " + res);
            
            // Point Delegate to Sub function.
            delegateCalc = calc.Sub;
            res = delegateCalc.Invoke(8, 4);
            Console.WriteLine("Substraction : " + res);
        }
    }
}
