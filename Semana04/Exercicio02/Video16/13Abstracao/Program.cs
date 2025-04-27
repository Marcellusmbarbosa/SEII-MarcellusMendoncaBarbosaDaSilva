using System;

namespace _13Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {

            PF pf = new PF();
            pf.LoanTax(1000);

            PJ pj = new PJ();
            pj.LoanTax(1000);

        }
    }
}