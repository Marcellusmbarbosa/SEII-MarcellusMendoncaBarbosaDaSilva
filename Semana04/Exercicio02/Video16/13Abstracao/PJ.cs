using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Abstracao
{
    class PJ : Default
    {
        public override void LoanTax(double value)
        {
            Console.WriteLine("Loan tax for PJ is R$ " + (value * 0.2));
        }
    }
}