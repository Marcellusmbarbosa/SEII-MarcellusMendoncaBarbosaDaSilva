using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Abstracao
{
    class PF : Default
    {

        public override void LoanTax(double value)
        {
            Console.WriteLine("Loan tax for PF is R$ " + (value * 0.1));
        }

    }
}