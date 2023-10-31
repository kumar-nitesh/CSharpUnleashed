using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Decalre a Delegate.
    public delegate int DelegateCalc(int a, int b);

    public class Calculate : ICalculate
    {
        #region ICalculate Members

        public int Add(int a, int b)
        {
            return a + b;
        }

        #endregion

        #region ICalculate Members


        public int Sub(int a, int b)
        {
            return a - b;
        }

        #endregion
    }
}
