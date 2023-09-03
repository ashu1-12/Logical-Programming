using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumber
    {
        public bool IsPrimeNumber(int n) {
            for(int div = 2; div*div <= n; div++)
            {
                if(n % div == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
