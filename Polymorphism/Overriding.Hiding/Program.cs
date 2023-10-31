using System;

namespace Overriding.Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Super sObj = new Super();
            sObj.Foo();

            Base bObj = new Derived();
            bObj.Foo();

            Derived dObj = new Super();
            dObj.Foo();

            Base Obj = new Super();
            Obj.Foo();
        }
    }

    class Base
    {
        public virtual void Foo()
        {
            Console.WriteLine("Base.Foo called");
        }
    }

    class Derived : Base
    {
        public override void Foo()
        {
            Console.WriteLine("Derived.Foo called");
        }
    }

    class Super : Derived
    {
        public new void Foo()
        {
            Console.WriteLine("Super.Foo called");
        }
    }
}
