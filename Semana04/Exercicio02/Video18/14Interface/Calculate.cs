using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14Interface
{
    class Calculate : Default
    {
        
        public void sum(int n1, int n2)
        {
            Console.WriteLine("The sum is " + (n1 + n2));
        }

        public void sub(int n1, int n2)
        {
            Console.WriteLine("The sum is " + (n1-n2));
        }

    }
}