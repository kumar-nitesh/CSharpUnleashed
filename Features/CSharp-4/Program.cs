using System;
using System.Collections.Generic;

namespace CSharp_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AddOptionalParameters(6);//Calling Optional Parameter.
            AddNamedParameters(5, comment: "...ans", b: 10);
            DynamicType();
        }

        // Optional Parameters.
        // Allows giving a method parameter a default value, so you don't have to specify it every time you call the method
        static void AddOptionalParameters(int a, int b = 5)
        {
            Console.WriteLine("Sum is: " + (a + b));
        }

        // Named Arguments.
        // A developer can skip parameters that have default values, and name only the parameters that have non-default values.
        static void AddNamedParameters(int a, int b = 7, string comment = "...Answer")
        {
            Console.WriteLine("Addition is: " + (a + b) + " " + comment);
        }

        static void SetObject(object objectParameter) { }

        // Covariance and Contravariance.
        static void Variance()
        {
            // Covariance.
            // Enables implicit reference conversion for array types, delegate types, and generic type arguments. 
            IEnumerable<string> ies = new List<string>();
            IEnumerable<object> ieo = ies;

            // Contravariance.
            Action<object> aobj = SetObject;
            Action<string> astr = aobj;
        }

        // Dynamic Type.
        static void DynamicType()
        {
            // Dynamic Type - Used as a Variable.
            dynamic foo = 1234567890;
            System.Console.WriteLine(foo);
            foo = "John Charles";
            System.Console.WriteLine(foo);
            foo = true;
            System.Console.WriteLine(foo);

            dynamic objEmp = new Employee();
            objEmp.FirstName = "John";
            objEmp.LastName = "Olamendy";
        }

    }
}
