using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncTask3
{
    internal class Func
    {
        public static bool Even(int number)
        {
            return number % 2 == 0;
        }

        public static bool Positive(int number)
        {
            return number > 0;
        }
    }
}
