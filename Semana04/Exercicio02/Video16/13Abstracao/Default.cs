using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Abstracao
{
    abstract class Default
    {

        public abstract void LoanTax (double value);

        public void SavingsCalculate (double value, double tax)
        {
            Console.WriteLine("Gains obtained with savings R$ " + (value*tax));
        }

    }
}