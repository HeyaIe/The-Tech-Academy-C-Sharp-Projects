using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Operations
    {
        public int operation(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
