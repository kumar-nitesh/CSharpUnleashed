using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            A aObj = new A();
            aObj.methodA();

            //Finally_Not_Executed_1();
        }

        /// <summary>
        /// Finallies the not executed 1.
        /// </summary>
        /// <exception cref="System.SystemException">This is wrong</exception>
        static void Finally_Not_Executed_1()
        {
            try
            {
                throw new SystemException("This is wrong");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("i am inside finally");
                Console.Read();
            }
        }
    }

    #region Scenario 2 - Finally not Executed !!!
    public class A

    {
        public void methodA()
        {
            try
            {
                B test = new B();
                test.methodB();
            }
            catch (Exception e)
            {
                throw e;
                Console.WriteLine("Exception from Class A");
            }
            finally
            {
                Console.WriteLine("Inside Class A Finally");
            }
        }
    }

    public class B
    {
        public void methodB()
        {
            try
            {
                throw new Exception("Exception from Class B");
            }
            catch (Exception e)
            {
                throw;
                Console.WriteLine("Exception from Class A");
            }
            finally
            {
                Console.WriteLine("Inside Class B Finally");
            }
        }
    }
    #endregion
}
