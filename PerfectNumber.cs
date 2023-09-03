using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
        public  PerfectNumber(int n) {
            int sum = 0;
            int i = 1;
            while (i <= n/2) {
                if(n%i == 0)
                {
                    sum += i;
                }
                i++;
            }
            if(sum == n)
            {
                Console.WriteLine("perfect Number");
            }else { Console.WriteLine("Not perfetc Number"); }
        
        }
    }
}
