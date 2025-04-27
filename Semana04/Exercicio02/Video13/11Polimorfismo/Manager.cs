using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11Polimorfismo
{
    public class Manager : Tax
    {
        
        public override void AlimentationVoucher(double salary)
        {
            Console.WriteLine("Manager discount of Alimenation Voucher: R$ " + (salary * 0.15));
        }

    }
}