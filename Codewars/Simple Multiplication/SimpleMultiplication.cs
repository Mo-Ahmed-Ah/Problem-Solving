using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Multiplication
{
    public class SimpleMultiplication
    {
        public static int Multiply(int x)
        {
            if (x % 2 == 0)
                return 8 * x;
            return 9 * x;
        }
    }
}
