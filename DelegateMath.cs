using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask1
{
    public delegate int MathOperation(int a, int b);
    public class MathOperations
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;

        public static int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("0 belme olmaz");
            return a / b;
        }
    }
}
