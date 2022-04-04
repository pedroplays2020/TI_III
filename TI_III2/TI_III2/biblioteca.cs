using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_III2
{
    class biblioteca
    {
        public static bool EPrimo(int num)
        {
            int div = 2, quoc, r;
            if (num < 2) return false;
            div = 2;
            do
            {
                r = num % div;
                quoc = num / div++;
            } while (r != 0 && quoc >= div);
            return num == 2 || r != 0;
        }

    }
}
