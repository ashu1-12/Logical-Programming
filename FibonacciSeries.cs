using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class FibonacciSeries
    {

        public void fibonacciSeries(int n) 
        {
            int a=0; int b = 1; int c=0;
            for(int i=0; i<n; i++)
            {
                c = a + b;
                Console.WriteLine(a);
                a = b;
                b = c;
            }
        }
    }
}
