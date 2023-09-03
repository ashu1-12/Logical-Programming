using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public int  reversedNumber(int num) {
           int reverse = 0;
           while (num > 0)
            {
                int rem = num % 10;
                num /= 10;
                reverse = reverse*10 + rem;    
            }
           return reverse;
        }
    }
}
