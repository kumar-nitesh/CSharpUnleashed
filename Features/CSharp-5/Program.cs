using System;
using System.Runtime.CompilerServices;

namespace CSharp_5
{
    class Program
    {
        static void Main(string[] args)
        {
            CallerInformation("Sharp 5");
        }

        private static void CallerInformation(string str, [CallerMemberName]string memberName = "", [CallerLineNumber]int lineNumber = 0, [CallerFilePath]string filePath = "")
        {
            Console.WriteLine(str);
            Console.WriteLine("Caller Info : " + memberName + "\n" + lineNumber + "\n" + filePath);
        }
    }
}
