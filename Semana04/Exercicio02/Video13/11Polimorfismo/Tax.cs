using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11Polimorfismo
{
    public class Tax
    {
        public virtual void AlimentationVoucher(double salary)
        {
            Console.WriteLine("Default discount of Alimenation Voucher: R$ " + (salary * 0.1));
        }

        public void TransportVoucher(double salary)
        {
            Console.WriteLine("Defaunt discount of Transport Voucher: R$ " + (salary * 0.06));
        }
    }
}